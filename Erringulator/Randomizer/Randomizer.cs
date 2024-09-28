using SoulsFormats;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Erringulator.Randomizer
{
    // To whom it may concern:
    // I already know there's a lot of slow, sloppy code in here,
    // so you don't need to tell me.
    internal partial class Randomizer
    {
        private readonly RandomizerSettings Settings;

        private readonly Random Rand;

        private IEnumerable<PARAMDEF> Paramdefs;

        private Dictionary<string, (BinderFile File, PARAM Param)> ParamFiles;

        public Randomizer(RandomizerSettings settings)
        {
            Settings = settings;
            Rand = new Random(Settings.Seed.GetHashCode());
        }

        public void Randomize()
        {
            Paramdefs = ReadParamdefs();
            BND4 regulation = ReadRegulation(Settings.InputPath);
            RandomizeParams();
            WriteRegulation(Settings.OutputPath, regulation);
        }

        private IEnumerable<PARAMDEF> ReadParamdefs()
        {
            return Directory.GetFiles(Settings.ParamdefDir, "*.xml")
                .Select(PARAMDEF.XmlDeserialize).ToArray();
        }

        private BND4 ReadRegulation(string path)
        {
            BND4 bnd = SFUtil.DecryptERRegulation(path);
            ParamFiles = [];
            foreach (BinderFile file in bnd.Files)
            {
                string name = Path.GetFileNameWithoutExtension(file.Name);
                ParamFiles[name] = (file, PARAM.Read(file.Bytes));
            }
            return bnd;
        }

        private static void WriteRegulation(string path, BND4 regulation)
        {
            // zstd is slow
            regulation.Compression = DCX.Type.DCX_DFLT_11000_44_9_15;
            SFUtil.EncryptERRegulation(path, regulation);
        }

        private PARAM LazyLoad(PARAM param)
        {
            if (param.AppliedParamdef == null)
            {
                param.ApplyParamdef(Paramdefs.Where(pd => pd.ParamType == param.ParamType && pd.GetRowSize() == param.DetectedSize).First());
            }
            return param;
        }

        private void RandomizeParams()
        {
            void go(string name, Action<PARAM> action)
                => RandomizeParam(ParamFiles[name], action);

            //go("AssetEnvironmentGeometryParam", ProcessGeneric);
            //go("AssetMaterialSfxParam", ProcessGeneric);
            //go("MapDefaultInfoParam", ProcessGeneric);
            //go("MapNameTexParam", ProcessGeneric);
            //go("MapPieceTexParam", ProcessGeneric);
            //go("MaterialExParam", ProcessGeneric);
            //go("NpcParam", ProcessGeneric);

            //go("CharaInitParam", ProcessCharaInit);

            if (Settings.RandomizeArmor)
            {
                go("EquipParamProtector", ProcessProtector);
            }

            if (Settings.RandomizeDecals)
            {
                go("DecalParam", ProcessDecal);
            }

            if (Settings.RandomizeFaces)
            {
                go("FaceParam", ProcessFace);
            }

            if (Settings.RandomizeGrass)
            {
                go("GrassTypeParam", ProcessGrass);
                go("GrassTypeParam_Lv1", ProcessGrass);
                go("GrassTypeParam_Lv2", ProcessGrass);
            }

            if (Settings.RandomizePhantoms)
            {
                go("PhantomParam", ProcessPhantom);
            }

            if (Settings.RandomizeProjectiles)
            {
                go("Bullet", ProcessBullet);
                go("BulletCreateLimitParam", ProcessBulletCreateLimit);
            }

            if (Settings.RandomizePropEffects)
            {
                go("AssetModelSfxParam", ProcessAssetModelSfx);
            }

            if (Settings.RandomizeRings)
            {
                go("EquipParamAccessory", ProcessAccessory);
            }

            if (Settings.RandomizeSpells)
            {
                go("Magic", ProcessMagic);
            }

            if (Settings.RandomizeUsableItems)
            {
                go("EquipParamGoods", ProcessGoods);
            }

            if (Settings.RandomizeWeapons)
            {
                go("EquipParamWeapon", ProcessWeapon);
                go("WepAbsorpPosParam", ProcessWepAbsorpPos);
            }

            if (Settings.RandomizeWeather)
            {
                go("WeatherAssetCreateParam", ProcessGeneric);
                go("WeatherAssetReplaceParam", ProcessWeatherAssetReplace);
                go("WeatherLotTexParam", ProcessWeatherLotTex);
                go("WeatherParam", ProcessWeather);
                go("WeatherLotParam", ProcessWeatherLot);
            }

            if (Settings.RandomizeWetness)
            {
                go("WetAspectParam", ProcessWetAspect);
            }
        }

        private void RandomizeParam((BinderFile File, PARAM Param) paramFile, Action<PARAM> action)
        {
            PARAM param = LazyLoad(paramFile.Param);
            action(param);
            paramFile.File.Bytes = param.Write();
        }

        private void ProcessGeneric(PARAM param) => ProcessGeneric(param.Rows, param.AppliedParamdef);

        private void ProcessGeneric(IEnumerable<PARAM.Row> rows, PARAMDEF paramdef)
        {
            Dictionary<string, object[]> options = GetAllOptions(rows, paramdef);

            foreach (PARAM.Row row in rows)
            {
                for (int i = 0; i < paramdef.Fields.Count; i++)
                {
                    PARAMDEF.Field field = paramdef.Fields[i];
                    if (field.DisplayType != PARAMDEF.DefType.dummy8)
                    {
                        row.Cells[i].Value = options[field.InternalName].Random(Rand);
                    }
                }
            }
        }

        private static PARAM.Row[] FilterRows(IEnumerable<PARAM.Row> rows, HashSet<int> blacklist)
        {
            return rows.Where(row => !blacklist.Contains(row.ID)).ToArray();
        }

        private static Dictionary<string, List<object>> GetAllValues(PARAM param) => GetAllValues(param.Rows, param.AppliedParamdef);

        private static Dictionary<string, List<object>> GetAllValues(IEnumerable<PARAM.Row> rows, PARAMDEF paramdef)
        {
            var values = new Dictionary<string, List<object>>();
            for (int i = 0; i < paramdef.Fields.Count; i++)
            {
                PARAMDEF.Field field = paramdef.Fields[i];
                values[field.InternalName] = rows.Select(r => r.Cells[i].Value).ToList();
            }
            return values;
        }

        private static Dictionary<string, object[]> GetAllOptions(PARAM param) => GetAllOptions(param.Rows, param.AppliedParamdef);

        private static Dictionary<string, object[]> GetAllOptions(IEnumerable<PARAM.Row> rows, PARAMDEF paramdef)
        {
            var values = new Dictionary<string, object[]>();
            for (int i = 0; i < paramdef.Fields.Count; i++)
            {
                PARAMDEF.Field field = paramdef.Fields[i];
                values[field.InternalName] = rows.Select(r => r.Cells[i].Value).Distinct().ToArray();
            }
            return values;
        }

        private void ShuffleFieldSets(IEnumerable<PARAM.Row> rows, params string[] fields)
        {
            List<object[]> valueSets = rows.Select(row =>
            {
                var valueSet = new object[fields.Length];
                for (int i = 0; i < fields.Length; i++)
                    valueSet[i] = row[fields[i]].Value;
                return valueSet;
            }).ToList();
            valueSets.Shuffle(Rand);

            foreach (PARAM.Row row in rows)
            {
                object[] valueSet = valueSets.Pop();
                for (int i = 0; i < fields.Length; i++)
                {
                    row[fields[i]].Value = valueSet[i];
                }
            }
        }

        private void SetRandomIfNot<T>(PARAM.Cell cell, object[] options, params T[] reject)
        {
            cell.Value = GetRandomIfNot((T)cell.Value, options, reject);
        }

        private T GetRandomIfNot<T>(T value, object[] options, params T[] reject)
        {
            if (reject.Contains(value))
            {
                return value;
            }
            else
            {
                // TODO
                options = options.Where(o => !reject.Contains((T)o)).ToArray();
                return (T)options.Random(Rand);
            }
        }
    }
}

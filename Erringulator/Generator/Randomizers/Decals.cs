using SoulsFormats;
using System.Collections.Generic;

namespace Erringulator.Randomizer
{
    internal partial class Randomizer
    {
        private void ProcessDecal(PARAM param)
        {
            Dictionary<string, object[]> options = GetAllOptions(param.Rows, param.AppliedParamdef);
            foreach (PARAM.Row row in param.Rows)
            {
                void r(string field) => row[field].Value = options[field].Random(Rand);
                //r("textureId");
                //r("dmypolyId");
                r("pitchAngle");
                r("yawAngle");
                r("nearDistance");
                r("farDistance");
                //r("nearSize");
                //r("farSize");
                //r("maskSpeffectId");
                //r("replaceTextureId_byMaterial");
                //r("dmypolyCategory");
                r("useDeferredDecal");
                r("usePaintDecal");
                r("bloodTypeEnable");
                //r("bUseNormal");
                r("usePom");
                //r("useEmissive");
                r("putVertical");
                //r("randomSizeMin");
                //r("randomSizeMax");
                r("randomRollMin");
                r("randomRollMax");
                r("randomPitchMin");
                r("randomPitchMax");
                r("randomYawMin");
                r("randomYawMax");
                r("pomHightScale");
                r("pomSampleMin");
                r("pomSampleMax");
                //r("blendMode");
                r("appearDirType");
                r("emissiveValueBegin");
                r("emissiveValueEnd");
                r("emissiveTime");
                //r("bIntpEnable");
                //r("intpIntervalDist");
                //r("beginIntpTextureId");
                //r("endIntpTextureId");
                r("appearSfxId");
                r("appearSfxOffsetPos");
                //r("maskTextureId");
                //r("diffuseTextureId");
                //r("reflecTextureId");
                //r("maskScale");
                //r("normalTextureId");
                //r("heightTextureId");
                //r("emissiveTextureId");
                r("diffuseColorR");
                r("diffuseColorG");
                r("diffuseColorB");
                r("reflecColorR");
                r("reflecColorG");
                r("reflecColorB");
                //r("bLifeEnable");
                r("siniScale");
                //r("lifeTimeSec");
                //r("fadeOutTimeSec");
                r("priority");
                r("bDistThinOutEnable");
                //r("bAlignedTexRandomVariationEnable");
                r("distThinOutCheckDist");
                r("distThinOutCheckAngleDeg");
                r("distThinOutMaxNum");
                r("distThinOutCheckNum");
                r("delayAppearFrame");
                //r("randVaria_Diffuse");
                //r("randVaria_Mask");
                //r("randVaria_Reflec");
                //r("randVaria_Normal");
                //r("randVaria_Height");
                //r("randVaria_Emissive");
                r("fadeInTimeSec");
                r("thinOutOverlapMultiRadius");
                r("thinOutNeighborAddRadius");
                r("thinOutOverlapLimitNum");
                r("thinOutNeighborLimitNum");
                r("thinOutMode");
                r("emissiveColorR");
                r("emissiveColorG");
                r("emissiveColorB");
                r("maxDecalSfxCreatableSlopeAngleDeg");

                //row["randomSizeMin"].Value = 1000;
                //row["randomSizeMax"].Value = 10000;
                //row["randVaria_Diffuse"].Value = 0;
                //row["randVaria_Mask"].Value = 0;
                //row["randVaria_Reflec"].Value = 0;
                //row["randVaria_Normal"].Value = 0;
                //row["randVaria_Height"].Value = 0;
                //row["randVaria_Emissive"].Value = 0;
            }
        }
    }
}

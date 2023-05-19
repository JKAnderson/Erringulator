﻿using SoulsFormats;
using System.Collections.Generic;
using System.Linq;

namespace Erringulator.Generator
{
    internal partial class Generator
    {
        private void ProcessProtector(PARAM param)
        {
            PARAM.Row[] rows = FilterRows(param.Rows, GeneratorData.Static.BlacklistProtector);
            foreach (PARAM.Row[] group in rows.GroupBy(row => row["protectorCategory"].Value).Select(g => g.ToArray()))
            {
                Dictionary<string, List<object>> values = GetAllValues(group, param.AppliedParamdef);
                foreach (List<object> list in values.Values)
                    list.Shuffle(Rand);

                foreach (PARAM.Row row in group)
                {
                    void r(string field) => row[field].Value = values[field].Pop();
                    //r("disableParam_NT");
                    //r("disableParamReserve1");
                    //r("disableParamReserve2");
                    //r("sortId");
                    //r("wanderingEquipId");
                    r("resistSleep");
                    r("resistMadness");
                    r("saDurability");
                    r("toughnessCorrectRate");
                    r("fixPrice");
                    r("basicPrice");
                    r("sellValue");
                    r("weight");
                    r("residentSpEffectId");
                    r("residentSpEffectId2");
                    r("residentSpEffectId3");
                    //r("materialSetId");
                    r("partsDamageRate");
                    r("corectSARecover");
                    //r("originEquipPro");
                    //r("originEquipPro1");
                    //r("originEquipPro2");
                    //r("originEquipPro3");
                    //r("originEquipPro4");
                    //r("originEquipPro5");
                    //r("originEquipPro6");
                    //r("originEquipPro7");
                    //r("originEquipPro8");
                    //r("originEquipPro9");
                    //r("originEquipPro10");
                    //r("originEquipPro11");
                    //r("originEquipPro12");
                    //r("originEquipPro13");
                    //r("originEquipPro14");
                    //r("originEquipPro15");
                    r("faceScaleM_ScaleX");
                    r("faceScaleM_ScaleZ");
                    r("faceScaleM_MaxX");
                    r("faceScaleM_MaxZ");
                    r("faceScaleF_ScaleX");
                    r("faceScaleF_ScaleZ");
                    r("faceScaleF_MaxX");
                    r("faceScaleF_MaxZ");
                    //r("qwcId");
                    //r("equipModelId");
                    //r("iconIdM");
                    //r("iconIdF");
                    r("knockBack");
                    r("knockbackBounceRate");
                    r("durability");
                    r("durabilityMax");
                    r("defFlickPower");
                    r("defensePhysics");
                    r("defenseMagic");
                    r("defenseFire");
                    r("defenseThunder");
                    r("defenseSlash");
                    r("defenseBlow");
                    r("defenseThrust");
                    r("resistPoison");
                    r("resistDisease");
                    r("resistBlood");
                    r("resistCurse");
                    //r("reinforceTypeId");
                    //r("trophySGradeId");
                    //r("shopLv");
                    r("knockbackParamId");
                    r("flickDamageCutRate");
                    //r("equipModelCategory");
                    //r("equipModelGender");
                    //r("protectorCategory");
                    //r("rarity");
                    //r("sortGroupId");
                    r("partsDmgType");
                    //r("isDeposit");
                    //r("headEquip");
                    //r("bodyEquip");
                    //r("armEquip");
                    //r("legEquip");
                    //r("useFaceScale");
                    r("isSkipWeakDamageAnim");
                    r("defenseMaterialVariationValue_Weak");
                    r("autoFootEffectDecalBaseId2");
                    r("autoFootEffectDecalBaseId3");
                    r("defenseMaterialVariationValue");
                    //r("isDiscard");
                    //r("isDrop");
                    //r("disableMultiDropShare");
                    //r("simpleModelForDlc");
                    //r("showLogCondType");
                    //r("showDialogCondType");
                    r("neutralDamageCutRate");
                    r("slashDamageCutRate");
                    r("blowDamageCutRate");
                    r("thrustDamageCutRate");
                    r("magicDamageCutRate");
                    r("fireDamageCutRate");
                    r("thunderDamageCutRate");
                    r("defenseMaterialSfx1");
                    r("defenseMaterialSfx_Weak1");
                    r("defenseMaterial1");
                    r("defenseMaterial_Weak1");
                    r("defenseMaterialSfx2");
                    r("defenseMaterialSfx_Weak2");
                    r("footMaterialSe");
                    r("defenseMaterial_Weak2");
                    r("autoFootEffectDecalBaseId1");
                    r("toughnessDamageCutRate");
                    r("toughnessRecoverCorrection");
                    r("darkDamageCutRate");
                    r("defenseDark");
                    //r("invisibleFlag48");
                    //r("invisibleFlag49");
                    //r("invisibleFlag50");
                    //r("invisibleFlag51");
                    //r("invisibleFlag52");
                    //r("invisibleFlag53");
                    //r("invisibleFlag54");
                    //r("invisibleFlag55");
                    //r("invisibleFlag56");
                    //r("invisibleFlag57");
                    //r("invisibleFlag58");
                    //r("invisibleFlag59");
                    //r("invisibleFlag60");
                    //r("invisibleFlag61");
                    //r("invisibleFlag62");
                    //r("invisibleFlag63");
                    //r("invisibleFlag64");
                    //r("invisibleFlag65");
                    //r("invisibleFlag66");
                    //r("invisibleFlag67");
                    //r("invisibleFlag68");
                    //r("invisibleFlag69");
                    //r("invisibleFlag70");
                    //r("invisibleFlag71");
                    //r("invisibleFlag72");
                    //r("invisibleFlag73");
                    //r("invisibleFlag74");
                    //r("invisibleFlag75");
                    //r("invisibleFlag76");
                    //r("invisibleFlag77");
                    //r("invisibleFlag78");
                    //r("invisibleFlag79");
                    //r("invisibleFlag80");
                    r("postureControlId");
                    r("saleValue");
                    r("resistFreeze");
                    //r("invisibleFlag_SexVer00");
                    //r("invisibleFlag_SexVer01");
                    //r("invisibleFlag_SexVer02");
                    //r("invisibleFlag_SexVer03");
                    //r("invisibleFlag_SexVer04");
                    //r("invisibleFlag_SexVer05");
                    //r("invisibleFlag_SexVer06");
                    //r("invisibleFlag_SexVer07");
                    //r("invisibleFlag_SexVer08");
                    //r("invisibleFlag_SexVer09");
                    //r("invisibleFlag_SexVer10");
                    //r("invisibleFlag_SexVer11");
                    //r("invisibleFlag_SexVer12");
                    //r("invisibleFlag_SexVer13");
                    //r("invisibleFlag_SexVer14");
                    //r("invisibleFlag_SexVer15");
                    //r("invisibleFlag_SexVer16");
                    //r("invisibleFlag_SexVer17");
                    //r("invisibleFlag_SexVer18");
                    //r("invisibleFlag_SexVer19");
                    //r("invisibleFlag_SexVer20");
                    //r("invisibleFlag_SexVer21");
                    //r("invisibleFlag_SexVer22");
                    //r("invisibleFlag_SexVer23");
                    //r("invisibleFlag_SexVer24");
                    //r("invisibleFlag_SexVer25");
                    //r("invisibleFlag_SexVer26");
                    //r("invisibleFlag_SexVer27");
                    //r("invisibleFlag_SexVer28");
                    //r("invisibleFlag_SexVer29");
                    //r("invisibleFlag_SexVer30");
                    //r("invisibleFlag_SexVer31");
                    //r("invisibleFlag_SexVer32");
                    //r("invisibleFlag_SexVer33");
                    //r("invisibleFlag_SexVer34");
                    //r("invisibleFlag_SexVer35");
                    //r("invisibleFlag_SexVer36");
                    //r("invisibleFlag_SexVer37");
                    //r("invisibleFlag_SexVer38");
                    //r("invisibleFlag_SexVer39");
                    //r("invisibleFlag_SexVer40");
                    //r("invisibleFlag_SexVer41");
                    //r("invisibleFlag_SexVer42");
                    //r("invisibleFlag_SexVer43");
                    //r("invisibleFlag_SexVer44");
                    //r("invisibleFlag_SexVer45");
                    //r("invisibleFlag_SexVer46");
                    //r("invisibleFlag_SexVer47");
                    //r("invisibleFlag_SexVer48");
                    //r("invisibleFlag_SexVer49");
                    //r("invisibleFlag_SexVer50");
                    //r("invisibleFlag_SexVer51");
                    //r("invisibleFlag_SexVer52");
                    //r("invisibleFlag_SexVer53");
                    //r("invisibleFlag_SexVer54");
                    //r("invisibleFlag_SexVer55");
                    //r("invisibleFlag_SexVer56");
                    //r("invisibleFlag_SexVer57");
                    //r("invisibleFlag_SexVer58");
                    //r("invisibleFlag_SexVer59");
                    //r("invisibleFlag_SexVer60");
                    //r("invisibleFlag_SexVer61");
                    //r("invisibleFlag_SexVer62");
                    //r("invisibleFlag_SexVer63");
                    //r("invisibleFlag_SexVer64");
                    //r("invisibleFlag_SexVer65");
                    //r("invisibleFlag_SexVer66");
                    //r("invisibleFlag_SexVer67");
                    //r("invisibleFlag_SexVer68");
                    //r("invisibleFlag_SexVer69");
                    //r("invisibleFlag_SexVer70");
                    //r("invisibleFlag_SexVer71");
                    //r("invisibleFlag_SexVer72");
                    //r("invisibleFlag_SexVer73");
                    //r("invisibleFlag_SexVer74");
                    //r("invisibleFlag_SexVer75");
                    //r("invisibleFlag_SexVer76");
                    //r("invisibleFlag_SexVer77");
                    //r("invisibleFlag_SexVer78");
                    //r("invisibleFlag_SexVer79");
                    //r("invisibleFlag_SexVer80");
                    //r("invisibleFlag_SexVer81");
                    //r("invisibleFlag_SexVer82");
                    //r("invisibleFlag_SexVer83");
                    //r("invisibleFlag_SexVer84");
                    //r("invisibleFlag_SexVer85");
                    //r("invisibleFlag_SexVer86");
                    //r("invisibleFlag_SexVer87");
                    //r("invisibleFlag_SexVer88");
                    //r("invisibleFlag_SexVer89");
                    //r("invisibleFlag_SexVer90");
                    //r("invisibleFlag_SexVer91");
                    //r("invisibleFlag_SexVer92");
                    //r("invisibleFlag_SexVer93");
                    //r("invisibleFlag_SexVer94");
                    //r("invisibleFlag_SexVer95");
                }

                ShuffleFieldSets(group,
                    "residentSpEffectId",
                    "residentSpEffectId2",
                    "residentSpEffectId3"
                );
            }
        }
    }
}

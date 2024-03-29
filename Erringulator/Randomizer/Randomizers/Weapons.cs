﻿using SoulsFormats;
using System.Collections.Generic;
using System.Linq;

namespace Erringulator.Randomizer
{
    internal partial class Randomizer
    {
        private void ProcessWeapon(PARAM param)
        {
            PARAM.Row[] rows = FilterRows(param.Rows, RandomizerData.Static.BlacklistWeapon);
            foreach (HashSet<ushort> weaponGroup in RandomizerData.Static.WepTypeGroups)
            {
                PARAM.Row[] group = rows.Where(r => weaponGroup.Contains((ushort)r["wepType"].Value)).ToArray();
                Dictionary<string, List<object>> values = GetAllValues(group, param.AppliedParamdef);
                foreach (List<object> list in values.Values)
                    list.Shuffle(Rand);

                foreach (PARAM.Row row in group)
                {
                    void r(string field) => row[field].Value = values[field].Pop();
                    r("behaviorVariationId");
                    //r("sortId");
                    //r("wanderingEquipId");
                    r("weight");
                    r("weaponWeightRate");
                    r("fixPrice");
                    r("reinforcePrice");
                    r("sellValue");
                    r("correctStrength");
                    r("correctAgility");
                    r("correctMagic");
                    r("correctFaith");
                    r("physGuardCutRate");
                    r("magGuardCutRate");
                    r("fireGuardCutRate");
                    r("thunGuardCutRate");
                    r("spEffectBehaviorId0");
                    r("spEffectBehaviorId1");
                    r("spEffectBehaviorId2");
                    r("residentSpEffectId");
                    r("residentSpEffectId1");
                    r("residentSpEffectId2");
                    //r("materialSetId");
                    //r("originEquipWep");
                    //r("originEquipWep1");
                    //r("originEquipWep2");
                    //r("originEquipWep3");
                    //r("originEquipWep4");
                    //r("originEquipWep5");
                    //r("originEquipWep6");
                    //r("originEquipWep7");
                    //r("originEquipWep8");
                    //r("originEquipWep9");
                    //r("originEquipWep10");
                    //r("originEquipWep11");
                    //r("originEquipWep12");
                    //r("originEquipWep13");
                    //r("originEquipWep14");
                    //r("originEquipWep15");
                    r("weakA_DamageRate");
                    r("weakB_DamageRate");
                    r("weakC_DamageRate");
                    r("weakD_DamageRate");
                    r("sleepGuardResist_MaxCorrect");
                    r("madnessGuardResist_MaxCorrect");
                    r("saWeaponDamage");
                    //r("equipModelId");
                    //r("iconId");
                    r("durability");
                    r("durabilityMax");
                    r("attackThrowEscape");
                    r("parryDamageLife");
                    r("attackBasePhysics");
                    r("attackBaseMagic");
                    r("attackBaseFire");
                    r("attackBaseThunder");
                    r("attackBaseStamina");
                    r("guardAngle");
                    r("saDurability");
                    r("staminaGuardDef");
                    //r("reinforceTypeId");
                    //r("trophySGradeId");
                    //r("trophySeqId");
                    r("throwAtkRate");
                    r("bowDistRate");
                    //r("equipModelCategory");
                    //r("equipModelGender");
                    r("weaponCategory");
                    r("wepmotionCategory");
                    r("guardmotionCategory");
                    r("atkMaterial");
                    r("defSeMaterial1");
                    r("correctType_Physics");
                    r("spAttribute");
                    r("spAtkcategory");
                    r("wepmotionOneHandId");
                    r("wepmotionBothHandId");
                    r("properStrength");
                    r("properAgility");
                    r("properMagic");
                    r("properFaith");
                    r("overStrength");
                    r("attackBaseParry");
                    r("defenseBaseParry");
                    r("guardBaseRepel");
                    r("attackBaseRepel");
                    r("guardCutCancelRate");
                    r("guardLevel");
                    r("slashGuardCutRate");
                    r("blowGuardCutRate");
                    r("thrustGuardCutRate");
                    r("poisonGuardResist");
                    r("diseaseGuardResist");
                    r("bloodGuardResist");
                    r("curseGuardResist");
                    r("atkAttribute");
                    //r("rightHandEquipable");
                    //r("leftHandEquipable");
                    //r("bothHandEquipable");
                    //r("arrowSlotEquipable");
                    //r("boltSlotEquipable");
                    //r("enableGuard");
                    //r("enableParry");
                    //r("enableMagic");
                    //r("enableSorcery");
                    //r("enableMiracle");
                    //r("enableVowMagic");
                    r("isNormalAttackType");
                    r("isBlowAttackType");
                    r("isSlashAttackType");
                    r("isThrustAttackType");
                    //r("isEnhance");
                    r("isHeroPointCorrect");
                    //r("isCustom");
                    r("disableBaseChangeReset");
                    //r("disableRepair");
                    //r("isDarkHand");
                    //r("simpleModelForDlc");
                    //r("lanternWep");
                    r("isVersusGhostWep");
                    r("baseChangeCategory");
                    //r("isDragonSlayer");
                    //r("isDeposit");
                    //r("disableMultiDropShare");
                    //r("isDiscard");
                    //r("isDrop");
                    //r("showLogCondType");
                    //r("enableThrow");
                    //r("showDialogCondType");
                    //r("disableGemAttr");
                    r("defSfxMaterial1");
                    r("wepCollidableType0");
                    r("wepCollidableType1");
                    r("postureControlId_Right");
                    r("postureControlId_Left");
                    r("traceSfxId0");
                    r("traceDmyIdHead0");
                    r("traceDmyIdTail0");
                    r("traceSfxId1");
                    r("traceDmyIdHead1");
                    r("traceDmyIdTail1");
                    r("traceSfxId2");
                    r("traceDmyIdHead2");
                    r("traceDmyIdTail2");
                    r("traceSfxId3");
                    r("traceDmyIdHead3");
                    r("traceDmyIdTail3");
                    r("traceSfxId4");
                    r("traceDmyIdHead4");
                    r("traceDmyIdTail4");
                    r("traceSfxId5");
                    r("traceDmyIdHead5");
                    r("traceDmyIdTail5");
                    r("traceSfxId6");
                    r("traceDmyIdHead6");
                    r("traceDmyIdTail6");
                    r("traceSfxId7");
                    r("traceDmyIdHead7");
                    r("traceDmyIdTail7");
                    r("defSfxMaterial2");
                    r("defSeMaterial2");
                    r("absorpParamId");
                    r("toughnessCorrectRate");
                    r("isValidTough_ProtSADmg");
                    //r("isDualBlade");
                    //r("isAutoEquip");
                    //r("isEnableEmergencyStep");
                    //r("invisibleOnRemo");
                    r("correctType_Magic");
                    r("correctType_Fire");
                    r("correctType_Thunder");
                    r("weakE_DamageRate");
                    r("weakF_DamageRate");
                    r("darkGuardCutRate");
                    r("attackBaseDark");
                    r("correctType_Dark");
                    r("correctType_Poison");
                    //r("sortGroupId");
                    r("atkAttribute2");
                    r("sleepGuardResist");
                    r("madnessGuardResist");
                    r("correctType_Blood");
                    r("properLuck");
                    r("freezeGuardResist");
                    //r("autoReplenishType");
                    r("swordArtsParamId");
                    r("correctLuck");
                    //r("arrowBoltEquipId");
                    //r("DerivationLevelType");
                    r("enchantSfxSize");
                    //r("wepType");
                    r("physGuardCutRate_MaxCorrect");
                    r("magGuardCutRate_MaxCorrect");
                    r("fireGuardCutRate_MaxCorrect");
                    r("thunGuardCutRate_MaxCorrect");
                    r("darkGuardCutRate_MaxCorrect");
                    r("poisonGuardResist_MaxCorrect");
                    r("diseaseGuardResist_MaxCorrect");
                    r("bloodGuardResist_MaxCorrect");
                    r("curseGuardResist_MaxCorrect");
                    r("freezeGuardResist_MaxCorrect");
                    r("staminaGuardDef_MaxCorrect");
                    r("residentSfxId_1");
                    r("residentSfxId_2");
                    r("residentSfxId_3");
                    r("residentSfxId_4");
                    r("residentSfx_DmyId_1");
                    r("residentSfx_DmyId_2");
                    r("residentSfx_DmyId_3");
                    r("residentSfx_DmyId_4");
                    r("staminaConsumptionRate");
                    //r("vsPlayerDmgCorrectRate_Physics");
                    //r("vsPlayerDmgCorrectRate_Magic");
                    //r("vsPlayerDmgCorrectRate_Fire");
                    //r("vsPlayerDmgCorrectRate_Thunder");
                    //r("vsPlayerDmgCorrectRate_Dark");
                    //r("vsPlayerDmgCorrectRate_Poison");
                    //r("vsPlayerDmgCorrectRate_Blood");
                    //r("vsPlayerDmgCorrectRate_Freeze");
                    r("attainmentWepStatusStr");
                    r("attainmentWepStatusDex");
                    r("attainmentWepStatusMag");
                    r("attainmentWepStatusFai");
                    r("attainmentWepStatusLuc");
                    r("attackElementCorrectId");
                    r("saleValue");
                    //r("reinforceShopCategory");
                    //r("maxArrowQuantity");
                    r("residentSfx_1_IsVisibleForHang");
                    r("residentSfx_2_IsVisibleForHang");
                    r("residentSfx_3_IsVisibleForHang");
                    r("residentSfx_4_IsVisibleForHang");
                    r("isSoulParamIdChange_model0");
                    r("isSoulParamIdChange_model1");
                    r("isSoulParamIdChange_model2");
                    r("isSoulParamIdChange_model3");
                    r("wepSeIdOffset");
                    r("baseChangePrice");
                    r("levelSyncCorrectId");
                    r("correctType_Sleep");
                    r("correctType_Madness");
                    //r("rarity");
                    //r("gemMountType");
                    r("wepRegainHp");
                    r("spEffectMsgId0");
                    r("spEffectMsgId1");
                    r("spEffectMsgId2");
                    //r("originEquipWep16");
                    //r("originEquipWep17");
                    //r("originEquipWep18");
                    //r("originEquipWep19");
                    //r("originEquipWep20");
                    //r("originEquipWep21");
                    //r("originEquipWep22");
                    //r("originEquipWep23");
                    //r("originEquipWep24");
                    //r("originEquipWep25");
                    //r("vsPlayerDmgCorrectRate_Sleep");
                    //r("vsPlayerDmgCorrectRate_Madness");
                    r("saGuardCutRate");
                    r("defMaterialVariationValue");
                    r("spAttributeVariationValue");
                    r("stealthAtkRate");
                    //r("vsPlayerDmgCorrectRate_Disease");
                    //r("vsPlayerDmgCorrectRate_Curse");
                }
            }
        }

        private void ProcessWepAbsorpPos(PARAM param)
        {
            Dictionary<string, object[]> options = GetAllOptions(param.Rows, param.AppliedParamdef);
            foreach (PARAM.Row row in param.Rows)
            {
                void r(string field) => SetRandomIfNot<short>(row[field], options[field], -1, 0);
                for (int i = 0; i < 4; i++)
                {
                    r($"right_{i}");
                    r($"left_{i}");
                    r($"both_{i}");
                    r($"leftHang_{i}");
                    r($"rightHang_{i}");
                    r($"leftBoth_{i}");
                }
            }
        }
    }
}

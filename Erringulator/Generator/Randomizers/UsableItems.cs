using SoulsFormats;
using System.Collections.Generic;
using System.Linq;

namespace Erringulator.Randomizer
{
    internal partial class Randomizer
    {
        private void ProcessGoods(PARAM param)
        {
            PARAM.Row[] rows = FilterRows(param.Rows.Where(
                row => (byte)row["goodsType"].Value == 0
            ), RandomizerData.Static.BlacklistGoods);

            Dictionary<string, object[]> options = GetAllOptions(rows, param.AppliedParamdef);
            Dictionary<string, List<object>> values = GetAllValues(rows, param.AppliedParamdef);
            foreach (List<object> list in values.Values)
                list.Shuffle(Rand);

            foreach (PARAM.Row row in rows)
            {
                void v(string field) => row[field].Value = values[field].Pop();
                void o(string field) => row[field].Value = options[field].Random(Rand);
                //r("refId_default");
                v("sfxVariationId");
                v("weight");
                v("basicPrice");
                v("sellValue");
                //r("behaviorId");
                v("replaceItemId");
                //r("sortId");
                v("appearanceReplaceItemId");
                //r("yesNoDialogMessageId");
                //r("useEnableSpEffectType");
                //r("potGroupId");
                //r("iconId");
                //r("modelId");
                //r("shopLv");
                //r("compTrophySedId");
                //r("trophySeqId");
                //r("maxNum");
                v("consumeHeroPoint");
                v("overDexterity");
                //r("goodsType");
                //r("refCategory");
                //r("spEffectCategory");
                //r("goodsUseAnim");
                //r("opmeMenuType");
                //r("useLimitCategory");
                //r("replaceCategory");
                //r("enable_live");
                //r("enable_gray");
                //r("enable_white");
                //r("enable_black");
                //r("enable_multi");
                //r("disable_offline");
                //r("isEquip");
                //r("isConsume");
                //r("isAutoEquip");
                //r("isEstablishment");
                //r("isOnlyOne");
                //r("isDiscard");
                //r("isDeposit");
                //r("isDisableHand");
                //r("isRemoveItem_forGameClear");
                //r("isSuppleItem");
                //r("isFullSuppleItem");
                //r("isEnhance");
                //r("isFixItem");
                //r("disableMultiDropShare");
                //r("disableUseAtColiseum");
                //r("disableUseAtOutOfColiseum");
                //r("isEnableFastUseItem");
                //r("isApplySpecialEffect");
                //r("syncNumVaryId");
                //r("refId_1");
                //r("refVirtualWepId");
                //r("vagrantItemLotId");
                //r("vagrantBonusEneDropItemLotId");
                //r("vagrantItemEneDropItemLotId");
                o("castSfxId");
                o("fireSfxId");
                o("effectSfxId");
                //r("enable_ActiveBigRune");
                //r("isBonfireWarpItem");
                //r("enable_Ladder");
                //r("isUseMultiPlayPreparation");
                //r("canMultiUse");
                //r("isShieldEnchant");
                //r("isWarpProhibited");
                //r("isUseMultiPenaltyOnly");
                //r("suppleType");
                //r("autoReplenishType");
                //r("isDrop");
                //r("showLogCondType");
                //r("isSummonHorse");
                //r("showDialogCondType");
                //r("isSleepCollectionItem");
                //r("enableRiding");
                //r("disableRiding");
                //r("maxRepositoryNum");
                //r("sortGroupId");
                //r("isUseNoAttackRegion");
                v("saleValue");
                //r("rarity");
                //r("useLimitSummonBuddy");
                //r("useLimitSpEffectType");
                //r("aiUseJudgeId");
                v("consumeMP");
                v("consumeHP");
                //r("reinforceGoodsId");
                //r("reinforceMaterialId");
                //r("reinforcePrice");
                //r("useLevel_vowType0");
                //r("useLevel_vowType1");
                //r("useLevel_vowType2");
                //r("useLevel_vowType3");
                //r("useLevel_vowType4");
                //r("useLevel_vowType5");
                //r("useLevel_vowType6");
                //r("useLevel_vowType7");
                //r("useLevel_vowType8");
                //r("useLevel_vowType9");
                //r("useLevel_vowType10");
                //r("useLevel_vowType11");
                //r("useLevel_vowType12");
                //r("useLevel_vowType13");
                //r("useLevel_vowType14");
                //r("useLevel_vowType15");
                //r("useLevel");
                //r("itemGetTutorialFlagId");
            }

            ShuffleFieldSets(rows,
                "goodsUseAnim",
                "enable_Ladder",
                "canMultiUse",
                "enableRiding",
                "disableRiding"
            );

            ShuffleFieldSets(rows,
                "refId_default",
                "behaviorId",
                "yesNoDialogMessageId",
                "refCategory",
                "spEffectCategory",
                "refId_1",
                "refVirtualWepId"
            );
        }
    }
}

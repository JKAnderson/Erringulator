using SoulsFormats;
using System.Collections.Generic;
using System.Linq;

namespace Erringulator.Randomizer
{
    internal partial class Randomizer
    {
        private void ProcessMagic(PARAM param)
        {
            // Exclude NPC spells
            PARAM.Row[] rows = param.Rows.Where(row => row.ID < 53000).ToArray();
            Dictionary<string, List<object>> values = GetAllValues(rows, param.AppliedParamdef);
            foreach (List<object> list in values.Values)
                list.Shuffle(Rand);

            foreach (PARAM.Row row in rows)
            {
                void r(string field) => row[field].Value = values[field].Pop();
                //r("yesNoDialogMessageId");
                //r("limitCancelSpEffectId");
                //r("sortId");
                r("requirementLuck");
                //r("aiNotifyType");
                r("mp");
                r("stamina");
                //r("iconId");
                r("behaviorId");
                //r("mtrlItemId");
                r("replaceMagicId");
                r("maxQuantity");
                //r("refCategory1");
                r("overDexterity");
                //r("refCategory2");
                r("slotLength");
                r("requirementIntellect");
                r("requirementFaith");
                r("analogDexterityMin");
                r("analogDexterityMax");
                //r("ezStateBehaviorType");
                //r("refCategory3");
                r("spEffectCategory");
                r("refType");
                //r("opmeMenuType");
                //r("refCategory4");
                r("hasSpEffectType");
                r("replaceCategory");
                r("useLimitCategory");
                //r("vowType0");
                //r("vowType1");
                //r("vowType2");
                //r("vowType3");
                //r("vowType4");
                //r("vowType5");
                //r("vowType6");
                //r("vowType7");
                //r("enable_multi");
                //r("enable_multi_only");
                //r("isEnchant");
                //r("isShieldEnchant");
                //r("enable_live");
                //r("enable_gray");
                //r("enable_white");
                //r("enable_black");
                //r("disableOffline");
                //r("castResonanceMagic");
                r("isValidTough_ProtSADmg");
                //r("isWarpMagic");
                //r("enableRiding");
                //r("disableRiding");
                //r("isUseNoAttackRegion");
                //r("vowType8");
                //r("vowType9");
                //r("vowType10");
                //r("vowType11");
                //r("vowType12");
                //r("vowType13");
                //r("vowType14");
                //r("vowType15");
                r("castSfxId");
                r("fireSfxId");
                r("effectSfxId");
                r("toughnessCorrectRate");
                r("ReplacementStatusType");
                r("ReplacementStatus1");
                r("ReplacementStatus2");
                r("ReplacementStatus3");
                r("ReplacementStatus4");
                //r("refCategory5");
                r("consumeSA");
                r("ReplacementMagic1");
                r("ReplacementMagic2");
                r("ReplacementMagic3");
                r("ReplacementMagic4");
                r("mp_charge");
                r("stamina_charge");
                //r("createLimitGroupId");
                //r("refCategory6");
                //r("subCategory1");
                //r("subCategory2");
                //r("refCategory7");
                //r("refCategory8");
                //r("refCategory9");
                //r("refCategory10");
                //r("refId1");
                //r("refId2");
                //r("refId3");
                //r("aiUseJudgeId");
                //r("refId4");
                //r("refId5");
                //r("refId6");
                //r("refId7");
                //r("refId8");
                //r("refId9");
                //r("refId10");
                r("consumeType1");
                r("consumeType2");
                r("consumeType3");
                r("consumeType4");
                r("consumeType5");
                r("consumeType6");
                r("consumeType7");
                r("consumeType8");
                r("consumeType9");
                r("consumeType10");
                r("consumeLoopMP_forMenu");
            }

            ShuffleFieldSets(rows,
                "refCategory1", "refId1",
                "refCategory2", "refId2",
                "refCategory3", "refId3",
                "refCategory4", "refId4",
                "refCategory5", "refId5",
                "refCategory6", "refId6",
                "refCategory7", "refId7",
                "refCategory8", "refId8",
                "refCategory9", "refId9",
                "refCategory10", "refId10"
            );
        }
    }
}

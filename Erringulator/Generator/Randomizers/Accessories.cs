using SoulsFormats;
using System.Collections.Generic;

namespace Erringulator.Generator
{
    internal partial class Generator
    {
        private void ProcessAccessory(PARAM param)
        {
            PARAM.Row[] rows = FilterRows(param.Rows, GeneratorData.Static.BlacklistAccessory);
            Dictionary<string, object[]> options = GetAllOptions(rows, param.AppliedParamdef);

            foreach (PARAM.Row row in rows)
            {
                void r(string field) => row[field].Value = options[field].Random(Rand);
                r("weight");
                r("sellValue");
            }

            ShuffleFieldSets(rows,
                "refId",
                "residentSpEffectId1",
                "residentSpEffectId2",
                "residentSpEffectId3",
                "residentSpEffectId4"
            );
        }
    }
}

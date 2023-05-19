using SoulsFormats;
using System.Collections.Generic;

namespace Erringulator.Generator
{
    internal partial class Generator
    {
        private void ProcessGrass(PARAM param)
        {
            Dictionary<string, object[]> options = GetAllOptions(param);
            foreach (PARAM.Row row in param.Rows)
            {
                void r(string field) => row[field].Value = options[field].Random(Rand);
                //r("lodRange");
                //r("lod0ClusterType");
                //r("lod1ClusterType");
                //r("lod2ClusterType");
                //r("distributionType");
                //r("baseDensity");
                //r("model0Name");
                //r("flatTextureName");
                //r("billboardTextureName");
                //r("normalInfluence");
                r("inclinationMax");
                r("inclinationJitter");
                r("scaleBaseMin");
                r("scaleBaseMax");
                r("scaleHeightMin");
                r("scaleHeightMax");
                r("colorShade1_r");
                r("colorShade1_g");
                r("colorShade1_b");
                r("colorShade2_r");
                r("colorShade2_g");
                r("colorShade2_b");
                //r("flatSplitType");
                //r("flatBladeCount");
                //r("flatSlant");
                //r("flatRadius");
                //r("castShadow");
                r("windAmplitude");
                r("windCycle");
                r("orientationAngle");
                r("orientationRange");
                //r("spacing");
                //r("dithering");
                //r("simpleModelName");
                //r("model1Name");
            }

            // These are so strongly correlated to avoid crashes
            ShuffleFieldSets(param.Rows,
                "lodRange",
                "lod0ClusterType",
                "lod1ClusterType",
                "lod2ClusterType",
                "distributionType",
                "baseDensity",
                "model0Name",
                "flatTextureName",
                "billboardTextureName",
                "normalInfluence",
                "flatSplitType",
                "flatBladeCount",
                "flatSlant",
                "flatRadius",
                "castShadow",
                "spacing",
                "dithering",
                "simpleModelName",
                "model1Name"
            );
        }
    }
}

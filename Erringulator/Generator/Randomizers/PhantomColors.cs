using SoulsFormats;

namespace Erringulator.Generator
{
    internal partial class Generator
    {
        private void ProcessPhantom(PARAM phantom)
        {
            foreach (PARAM.Row row in phantom.Rows)
            {
                row["edgeColorA"].Value = Rand.NextSingle(0, 10);
                row["frontColorA"].Value = Rand.NextSingle(0, 10);
                row["diffMulColorA"].Value = Rand.NextSingle(0, 10);
                row["specMulColorA"].Value = Rand.NextSingle(0, 10);
                row["lightColorA"].Value = Rand.NextSingle(0, 10);
                row["edgeColorR"].Value = Rand.NextByte();
                row["edgeColorG"].Value = Rand.NextByte();
                row["edgeColorB"].Value = Rand.NextByte();
                row["frontColorR"].Value = Rand.NextByte();
                row["frontColorG"].Value = Rand.NextByte();
                row["frontColorB"].Value = Rand.NextByte();
                row["diffMulColorR"].Value = Rand.NextByte();
                row["diffMulColorG"].Value = Rand.NextByte();
                row["diffMulColorB"].Value = Rand.NextByte();
                row["specMulColorR"].Value = Rand.NextByte();
                row["specMulColorG"].Value = Rand.NextByte();
                row["specMulColorB"].Value = Rand.NextByte();
                row["lightColorR"].Value = Rand.NextByte();
                row["lightColorG"].Value = Rand.NextByte();
                row["lightColorB"].Value = Rand.NextByte();
                row["alpha"].Value = Rand.NextSingle();
                row["blendRate"].Value = Rand.NextSingle();
                row["blendType"].Value = Rand.NextByte(0, 4);
                row["isEdgeSubtract"].Value = Rand.NextByte(0, 1);
                row["isFrontSubtract"].Value = Rand.NextByte(0, 1);
                row["isNo2Pass"].Value = Rand.NextByte(0, 1);
                row["edgePower"].Value = Rand.NextSingle(0.1f, 8);
                row["glowScale"].Value = Rand.NextSingle(0, 10);
            }
        }
    }
}

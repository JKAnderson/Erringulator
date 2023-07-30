using SoulsFormats;

namespace Erringulator.Randomizer
{
    internal partial class Randomizer
    {
        private void ProcessWetAspect(PARAM param)
        {
            ProcessGeneric(param.Rows, param.AppliedParamdef);
            foreach (PARAM.Row row in param.Rows)
            {
                //row["baseColorA"].Value = 10f;
            }
        }
    }
}

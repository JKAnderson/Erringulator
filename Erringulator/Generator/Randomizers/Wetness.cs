using SoulsFormats;

namespace Erringulator.Generator
{
    internal partial class Generator
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

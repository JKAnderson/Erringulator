using SoulsFormats;
using System.Collections.Generic;
using System.Linq;

namespace Erringulator.Generator
{
    internal partial class Generator
    {
        private void ProcessWeather(PARAM param)
        {
            ProcessGeneric(param);
        }

        private void ProcessWeatherAssetReplace(PARAM param)
        {
            ProcessGeneric(param);
        }

        private void ProcessWeatherLot(PARAM param)
        {
            ProcessGeneric(param);

            PARAM.Row[] weathers = ParamFiles["WeatherParam"].Param.Rows.Where(r => r.ID <= short.MaxValue).ToArray();
            foreach (var row in param.Rows)
            {
                for (int i = 0; i < 16; i++)
                {
                    row[$"weatherType{i}"].Value = weathers.Random(Rand).ID;
                    row[$"lotteryWeight{i}"].Value = 1;
                }
            }
        }

        private void ProcessWeatherLotTex(PARAM param)
        {
            Dictionary<string, object[]> options = GetAllOptions(param);
            foreach (PARAM.Row row in param.Rows)
            {
                row["weatherLogId"].Value = options["weatherLogId"].Random(Rand);
            }
        }
    }
}

using SoulsFormats;
using System;
using System.Linq;

namespace Erringulator.Generator
{
    internal partial class Generator
    {
        private void ProcessAssetModelSfx(PARAM param)
        {
            object[] options = param.Rows.SelectMany(
                row => row.Cells.Where(
                    cell => cell.Def.InternalName.StartsWith("sfxId_") && !cell.Value.Equals(-1)
                ).Select(cell => cell.Value)
            ).Distinct().ToArray();

            foreach (var row in param.Rows)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (!row[$"dmypolyId_{i}"].Value.Equals(-1))
                    {
                        row[$"sfxId_{i}"].Value = options.Random(Rand);
                    }
                }
            }
        }
    }
}

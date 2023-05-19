using Erringulator.Properties;
using System.Collections.Generic;
using System.Text.Json;

namespace Erringulator.Generator
{
    internal class GeneratorData
    {
        public HashSet<int> BlacklistAccessory { get; set; }

        public HashSet<int> BlacklistBullet { get; set; }

        public HashSet<int> BlacklistGoods { get; set; }

        public HashSet<int> BlacklistProtector { get; set; }

        public HashSet<int> BlacklistWeapon { get; set; }

        public HashSet<ushort>[] WepTypeGroups { get; set; }

        public static GeneratorData Static { get; }

        static GeneratorData()
        {
            var options = new JsonSerializerOptions
            {
                ReadCommentHandling = JsonCommentHandling.Skip,
            };
            Static = JsonSerializer.Deserialize<GeneratorData>(Resources.GeneratorData, options);
        }
    }
}

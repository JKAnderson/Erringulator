using Erringulator.Properties;
using System.Collections.Generic;
using System.Text.Json;

namespace Erringulator.Randomizer
{
    internal class RandomizerData
    {
        public HashSet<int> BlacklistAccessory { get; set; }

        public HashSet<int> BlacklistBullet { get; set; }

        public HashSet<int> BlacklistGoods { get; set; }

        public HashSet<int> BlacklistProtector { get; set; }

        public HashSet<int> BlacklistWeapon { get; set; }

        public HashSet<ushort>[] WepTypeGroups { get; set; }

        public static RandomizerData Static { get; }

        static RandomizerData()
        {
            var options = new JsonSerializerOptions
            {
                ReadCommentHandling = JsonCommentHandling.Skip,
            };
            Static = JsonSerializer.Deserialize<RandomizerData>(Resources.GeneratorData, options);
        }
    }
}

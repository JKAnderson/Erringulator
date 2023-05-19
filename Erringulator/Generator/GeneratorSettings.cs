namespace Erringulator.Generator
{
    internal class GeneratorSettings
    {
        public string InputPath { get; }

        public bool LoadBackup { get; }

        public string OutputPath { get; }

        public ProjectileQuantity ProjectileQuantity { get; }

        public bool RandomizeArmor { get; }

        public bool RandomizeDecals { get; }

        public bool RandomizeFaces { get; }

        public bool RandomizeGrass { get; }

        public bool RandomizePhantoms { get; }

        public bool RandomizeProjectiles { get; }

        public bool RandomizePropEffects { get; }

        public bool RandomizeRings { get; }

        public bool RandomizeSpells { get; }

        public bool RandomizeUsableItems { get; }

        public bool RandomizeWeapons { get; }

        public bool RandomizeWeather { get; }

        public bool RandomizeWetness { get; }

        public GeneratorSettings(string inputPath, bool loadBackup, string outputPath, ProjectileQuantity projectileQuantity,
            bool randomizeArmor, bool randomizeDecal, bool randomizeFaces, bool randomizeGrass, 
            bool randomizePhantoms, bool randomizeProjectiles, bool randomizePropEffects, bool randomizeRings, bool randomizeSpells, bool randomizeUsableItems,
            bool randomizeWeapons, bool randomizeWeather, bool randomizeWetness)
        {
            InputPath = inputPath;
            LoadBackup = loadBackup;
            OutputPath = outputPath;
            ProjectileQuantity = projectileQuantity;

            RandomizeArmor = randomizeArmor;
            RandomizeDecals = randomizeDecal;
            RandomizeFaces = randomizeFaces;
            RandomizeGrass = randomizeGrass;
            RandomizePhantoms = randomizePhantoms;
            RandomizeProjectiles = randomizeProjectiles;
            RandomizePropEffects = randomizePropEffects;
            RandomizeRings = randomizeRings;
            RandomizeSpells = randomizeSpells;
            RandomizeUsableItems = randomizeUsableItems;
            RandomizeWeapons = randomizeWeapons;
            RandomizeWeather = randomizeWeather;
            RandomizeWetness = randomizeWetness;
        }
    }
}

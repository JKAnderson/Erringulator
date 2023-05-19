using Erringulator.Generator;
using System;
using System.Reflection;
using System.Windows;

namespace Erringulator
{
    internal class ErringulatorOptions
    {
        private static Properties.Settings Settings => Properties.Settings.Default;

        public static string TitleVersion
        {
            get
            {
                Assembly assembly = Assembly.GetEntryAssembly();
                string version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
                return $"Erringulator {version}";
            }
        }

        public static Visibility DebugVisibility
#if DEBUG
            => Visibility.Visible;
#else
            => Visibility.Collapsed;
#endif

        public int WindowLeft { get; set; }

        public int WindowTop { get; set; }

        public string InputDir { get; set; }

        public bool LoadBackup { get; set; }

        public string OutputDir { get; set; }

        public ProjectileQuantity ProjectileQuantity { get; set; }

        public bool RandomizeArmor { get; set; }

        public bool RandomizeDecals { get; set; }

        public bool RandomizeFaces { get; set; }

        public bool RandomizeGrass { get; set; }

        public bool RandomizePhantoms { get; set; }

        public bool RandomizeProjectiles { get; set; }

        public bool RandomizePropEffects { get; set; }

        public bool RandomizeRings { get; set; }

        public bool RandomizeSpells { get; set; }

        public bool RandomizeUsableItems { get; set; }

        public bool RandomizeWeapons { get; set; }

        public bool RandomizeWeather { get; set; }

        public bool RandomizeWetness { get; set; }

        public ErringulatorOptions()
        {
            if (!Settings.Upgraded)
            {
                Settings.Upgrade();
                Settings.Upgraded = true;
            }

            WindowLeft = Settings.WindowLocation.X;
            WindowTop = Settings.WindowLocation.Y;
            InputDir = Settings.InputPath;
            LoadBackup = Settings.LoadBackup;
            OutputDir = Settings.OutputPath;
            ProjectileQuantity = Enum.Parse<ProjectileQuantity>(Settings.ProjectileQuantity);

            RandomizeArmor = Settings.RandomizeArmor;
            RandomizeDecals = Settings.RandomizeDecals;
            RandomizeFaces = Settings.RandomizeFaces;
            RandomizeGrass = Settings.RandomizeGrass;
            RandomizePhantoms = Settings.RandomizePhantoms;
            RandomizeProjectiles = Settings.RandomizeProjectiles;
            RandomizePropEffects = Settings.RandomizePropEffects;
            RandomizeRings = Settings.RandomizeRings;
            RandomizeSpells = Settings.RandomizeSpells;
            RandomizeUsableItems = Settings.RandomizeUsableItems;
            RandomizeWeapons = Settings.RandomizeWeapons;
            RandomizeWeather = Settings.RandomizeWeather;
            RandomizeWetness = Settings.RandomizeWetness;
        }

        public void Save()
        {
            Settings.WindowLocation = new System.Drawing.Point(WindowLeft, WindowTop);
            Settings.InputPath = InputDir;
            Settings.LoadBackup = LoadBackup;
            Settings.OutputPath = OutputDir;
            Settings.ProjectileQuantity = ProjectileQuantity.ToString();

            Settings.RandomizeArmor = RandomizeArmor;
            Settings.RandomizeDecals = RandomizeDecals;
            Settings.RandomizeFaces = RandomizeFaces;
            Settings.RandomizeGrass = RandomizeGrass;
            Settings.RandomizePhantoms = RandomizePhantoms;
            Settings.RandomizeProjectiles = RandomizeProjectiles;
            Settings.RandomizePropEffects = RandomizePropEffects;
            Settings.RandomizeRings = RandomizeRings;
            Settings.RandomizeSpells = RandomizeSpells;
            Settings.RandomizeUsableItems = RandomizeUsableItems;
            Settings.RandomizeWeapons = RandomizeWeapons;
            Settings.RandomizeWeather = RandomizeWeather;
            Settings.RandomizeWetness = RandomizeWetness;
            Settings.Save();
        }

        public GeneratorSettings GetGeneratorSettings()
        {
            return new GeneratorSettings(InputDir, LoadBackup, OutputDir, ProjectileQuantity,
                RandomizeArmor, RandomizeDecals, RandomizeFaces, RandomizeGrass, 
                RandomizePhantoms, RandomizeProjectiles, RandomizePropEffects, RandomizeRings, RandomizeSpells, RandomizeUsableItems,
                RandomizeWeapons, RandomizeWeather, RandomizeWetness);
        }
    }
}

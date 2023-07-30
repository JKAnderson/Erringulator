using Erringulator.Randomizer;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Erringulator
{
    internal class ErringulatorOptions : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void ChangeProperty<T>(ref T field, T value, [CallerMemberName] string name = null)
        {
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        private static Properties.Settings Settings => Properties.Settings.Default;

        private static readonly Random Rand = new();

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

        private int _windowLeft;
        public int WindowLeft
        {
            get => _windowLeft;
            set => ChangeProperty(ref _windowLeft, value);
        }

        private int _windowTop;
        public int WindowTop
        {
            get => _windowTop;
            set => ChangeProperty(ref _windowTop, value);
        }

        private string _inputDir;
        public string InputDir
        {
            get => _inputDir;
            set => ChangeProperty(ref _inputDir, value);
        }

        private bool _loadBackup;
        public bool LoadBackup
        {
            get => _loadBackup;
            set => ChangeProperty(ref _loadBackup, value);
        }

        private string _outputDir;
        public string OutputDir
        {
            get => _outputDir;
            set => ChangeProperty(ref _outputDir, value);
        }

        private string _seed;
        public string Seed
        {
            get => _seed;
            set => ChangeProperty(ref _seed, value.Trim());
        }

        private string _lastSeed;
        public string LastSeed
        {
            get => _lastSeed;
            set => ChangeProperty(ref _lastSeed, value);
        }

        private ProjectileQuantity _projectileQuantity;
        public ProjectileQuantity ProjectileQuantity
        {
            get => _projectileQuantity;
            set => ChangeProperty(ref _projectileQuantity, value);
        }

        private bool _randomizeArmor;
        public bool RandomizeArmor
        {
            get => _randomizeArmor;
            set => ChangeProperty(ref _randomizeArmor, value);
        }

        private bool _randomizeDecals;
        public bool RandomizeDecals
        {
            get => _randomizeDecals;
            set => ChangeProperty(ref _randomizeDecals, value);
        }

        private bool _randomizeFaces;
        public bool RandomizeFaces
        {
            get => _randomizeFaces;
            set => ChangeProperty(ref _randomizeFaces, value);
        }

        private bool _randomizeGrass;
        public bool RandomizeGrass
        {
            get => _randomizeGrass;
            set => ChangeProperty(ref _randomizeGrass, value);
        }

        private bool _randomizePhantoms;
        public bool RandomizePhantoms
        {
            get => _randomizePhantoms;
            set => ChangeProperty(ref _randomizePhantoms, value);
        }

        private bool _randomizeProjectiles;
        public bool RandomizeProjectiles
        {
            get => _randomizeProjectiles;
            set => ChangeProperty(ref _randomizeProjectiles, value);
        }

        private bool _randomizePropEffects;
        public bool RandomizePropEffects
        {
            get => _randomizePropEffects;
            set => ChangeProperty(ref _randomizePropEffects, value);
        }

        private bool _randomizeRings;
        public bool RandomizeRings
        {
            get => _randomizeRings;
            set => ChangeProperty(ref _randomizeRings, value);
        }

        private bool _randomizeSpells;
        public bool RandomizeSpells
        {
            get => _randomizeSpells;
            set => ChangeProperty(ref _randomizeSpells, value);
        }

        private bool _randomizeUsableItems;
        public bool RandomizeUsableItems
        {
            get => _randomizeUsableItems;
            set => ChangeProperty(ref _randomizeUsableItems, value);
        }

        private bool _randomizeWeapons;
        public bool RandomizeWeapons
        {
            get => _randomizeWeapons;
            set => ChangeProperty(ref _randomizeWeapons, value);
        }

        private bool _randomizeWeather;
        public bool RandomizeWeather
        {
            get => _randomizeWeather;
            set => ChangeProperty(ref _randomizeWeather, value);
        }

        private bool _randomizeWetness;
        public bool RandomizeWetness
        {
            get => _randomizeWetness;
            set => ChangeProperty(ref _randomizeWetness, value);
        }

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
            Seed = Settings.Seed;
            LastSeed = Settings.LastSeed;
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
            Settings.Seed = Seed;
            Settings.LastSeed = LastSeed;
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

        public RandomizerSettings GetGeneratorSettings()
        {
            string seed = Seed;
            if (string.IsNullOrWhiteSpace(seed))
            {
                var chars = new char[10];
                for (int i = 0; i < 10; i++)
                    chars[i] = (char)('a' + Rand.Next(26));
                seed = new string(chars);
            }

            return new RandomizerSettings(InputDir, LoadBackup, OutputDir, seed, ProjectileQuantity,
                RandomizeArmor, RandomizeDecals, RandomizeFaces, RandomizeGrass,
                RandomizePhantoms, RandomizeProjectiles, RandomizePropEffects, RandomizeRings, RandomizeSpells, RandomizeUsableItems,
                RandomizeWeapons, RandomizeWeather, RandomizeWetness);
        }
    }
}

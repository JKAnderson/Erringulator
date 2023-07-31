using Erringulator.Randomizer;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows;

namespace Erringulator
{
    internal static class Generator
    {
        private static readonly Random Rand = new();

        // Send me to prison immediately
        public static void Generate(ErringulatorOptions options)
        {
            try
            {
                RandomizerSettings randomizerSettings = GetRandomizerSettings(options);
                BackupFile(randomizerSettings.OutputPath);

                var randomizer = new Randomizer.Randomizer(randomizerSettings);
                randomizer.Randomize();
                // Toxic
                options.LastSeed = randomizerSettings.Seed;
                SystemSounds.Beep.Play();
            }
            catch (Exception ex) when (!Debugger.IsAttached)
            {
                MessageBox.Show($"An error occurred during randomization:\n\n{ex}",
                    "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public static void Restore(ErringulatorOptions options)
        {
            try
            {
                string outputPath = GetOutputPath(options);
                string bakPath = GetBakPath(outputPath);
                if (File.Exists(bakPath))
                {
                    File.Copy(bakPath, outputPath, true);
                    SystemSounds.Beep.Play();
                }
                else
                {
                    MessageBox.Show($"No backup file found at:\n\n{bakPath}",
                        "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex) when (!Debugger.IsAttached)
            {
                MessageBox.Show($"An error occurred while restoring files:\n\n{ex}",
                        "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private static void BackupFile(string path)
        {
            string bakPath = GetBakPath(path);
            if (File.Exists(path) && !File.Exists(bakPath))
                File.Copy(path, bakPath);
        }

        private static string GetOutputPath(ErringulatorOptions options)
        {
            string outputDir = string.IsNullOrWhiteSpace(options.OutputDir) ? options.InputDir : options.OutputDir;
            return Path.Combine(outputDir, "regulation.bin");
        }

        private static RandomizerSettings GetRandomizerSettings(ErringulatorOptions options)
        {
            string inputPath = Path.Combine(options.InputDir, "regulation.bin");
            string inputBakPath = GetBakPath(inputPath);
            if (options.LoadBackup && File.Exists(inputBakPath))
                inputPath = inputBakPath;

            string outputPath = GetOutputPath(options);

            string paramdefDir = @".\res\defs";

            string seed = options.Seed;
            if (string.IsNullOrWhiteSpace(seed))
                seed = GetRandomSeed();

            return new RandomizerSettings(
                inputPath,
                outputPath,
                paramdefDir,
                seed,
                options.ProjectileQuantity,
                options.RandomizeArmor,
                options.RandomizeDecals,
                options.RandomizeFaces,
                options.RandomizeGrass,
                options.RandomizePhantoms,
                options.RandomizeProjectiles,
                options.RandomizePropEffects,
                options.RandomizeRings,
                options.RandomizeSpells,
                options.RandomizeUsableItems,
                options.RandomizeWeapons,
                options.RandomizeWeather,
                options.RandomizeWetness);
        }

        private static string GetBakPath(string path)
        {
            string dir = Path.GetDirectoryName(path);
            string name = Path.GetFileNameWithoutExtension(path);
            string ext = Path.GetExtension(path);
            return Path.Combine(dir, $"{name}-erringulator-backup{ext}");
        }

        private static string GetRandomSeed()
        {
            var chars = new char[10];
            for (int i = 0; i < 10; i++)
                chars[i] = (char)('a' + Rand.Next(26));
            return new string(chars);
        }
    }
}

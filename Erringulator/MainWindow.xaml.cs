using Erringulator.Generator;
using System;
using System.Diagnostics;
using System.Media;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace Erringulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal ErringulatorOptions Options { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Options = new ErringulatorOptions();
            DataContext = Options;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Options.Save();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            IsEnabled = false;
            Progress.Bar.Value = 0;
            Progress.Bar.Minimum = 0;
            Progress.Bar.Maximum = 1;
            Progress.Text = "Randomizing...";

            GeneratorSettings generatorSettings = Options.GetGeneratorSettings();
            var generator = new Generator.Generator(generatorSettings);

            try
            {
                await Task.Run(generator.Generate);
                Options.LastSeed = generatorSettings.Seed;
                SystemSounds.Beep.Play();
            }
            catch (Exception ex) when (!Debugger.IsAttached)
            {
                MessageBox.Show($"An error occurred during randomization:\n\n{ex}", 
                    "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Progress.Bar.Value = 1;
            Progress.Text = "Done!";
            IsEnabled = true;
        }
    }
}

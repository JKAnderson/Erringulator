using System;
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
            var generator = new Generator.Generator(Options.GetGeneratorSettings());
#if DEBUG
            await Task.Run(generator.Generate);
#else
            try
            {
                await Task.Run(generator.Generate);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during randomization:\n\n{ex}", 
                    "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
#endif
            Progress.Bar.Value = 1;
            Progress.Text = "Done!";
            IsEnabled = true;
            SystemSounds.Beep.Play();
        }
    }
}

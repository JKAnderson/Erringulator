using System;
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

            await Task.Run(() => Generator.Generate(Options));

            Progress.Bar.Value = 1;
            Progress.Text = "Done!";
            IsEnabled = true;
        }
    }
}

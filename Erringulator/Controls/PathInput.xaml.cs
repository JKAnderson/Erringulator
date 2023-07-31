using Ookii.Dialogs.Wpf;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Erringulator
{
    /// <summary>
    /// Interaction logic for PathInput.xaml
    /// </summary>
    public partial class PathInput : UserControl
    {
        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(PathInput));

        public string Path
        {
            get => (string)GetValue(PathProperty);
            set => SetValue(PathProperty, value);
        }

        public static readonly DependencyProperty PathProperty =
            DependencyProperty.Register("Path", typeof(string), typeof(PathInput));

        public PathInput()
        {
            InitializeComponent();
        }

        private void Button_Browse_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new VistaFolderBrowserDialog()
            {
                Description = "",
                RootFolder = System.Environment.SpecialFolder.MyComputer,
                SelectedPath = Path,
            };

            if (dialog.ShowDialog() ?? false)
            {
                Path = dialog.SelectedPath;
            }
        }

        private void Button_Explore_Click(object sender, RoutedEventArgs e)
        {
            string dir = Path;
            if (!Directory.Exists(Path))
            {
                dir = System.IO.Path.GetDirectoryName(Path);
            }

            if (Directory.Exists(dir))
            {
                Process.Start("explorer.exe", $"\"{dir}\"");
            }
            else
            {
                MessageBox.Show($"Directory not found:\n\n{dir}", 
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

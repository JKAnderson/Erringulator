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
    }
}

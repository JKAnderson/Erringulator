using System.Windows;
using System.Windows.Controls;

namespace Erringulator
{
    /// <summary>
    /// Interaction logic for TextProgress.xaml
    /// </summary>
    public partial class TextProgress : UserControl
    {
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(TextProgress));

        public TextProgress()
        {
            InitializeComponent();
        }
    }
}

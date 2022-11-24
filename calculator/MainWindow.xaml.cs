using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool Pressed { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
            Pressed = false;
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            Pressed = !Pressed;
            lable.Content = Pressed ? "ON" : "OFF";
        }
    }
}

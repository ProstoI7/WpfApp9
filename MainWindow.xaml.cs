using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void GotFocusTB(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            textBox.Style = (Style)Resources["ActiveTextStyle"];

            TextBox symmetricalTextBox = FindSymmetricalTB(textBox.Name);

            if (symmetricalTextBox != null)
            {
                symmetricalTextBox.Style = (Style)Resources["ActiveTextStyle"];
            }
        }

        private void LostFocusTB(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            textBox.Style = (Style)Resources["TextStyle"];

            TextBox symmetricalTextBox = FindSymmetricalTB(textBox.Name);

            if (symmetricalTextBox != null)
            {
                symmetricalTextBox.Style = (Style)Resources["TextStyle"];
            }
        }

        private TextBox FindSymmetricalTB(string name)
        {
            switch (name)
            {
                case "TextBoxLeft1":
                    return TextBoxRight1;
                case "TextBoxLeft2":
                    return TextBoxRight2;
                case "TextBoxLeft3":
                    return TextBoxRight3;
                case "TextBoxRight1":
                    return TextBoxLeft1;
                case "TextBoxRight2":
                    return TextBoxLeft2;
                case "TextBoxRight3":
                    return TextBoxLeft3;
                default:
                    return null;
            }
        }
    }
}

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

namespace WpfApp2
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
        private void Checkbox_Click(object sender, RoutedEventArgs e)
        {
            if (CB.IsChecked == true) GB.IsEnabled = true;

        }
        private void Checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (CB.IsChecked == false) GB.IsEnabled = false;   
        }   
        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            tb.Text = "История, Иностр.Яз.";
        }
        private void rb2_Checked(object sender, RoutedEventArgs e)
        {
            tb.Text = "Культурология,История,Иностр.Яз.";
        }
        private void CB1_Click(object sender, RoutedEventArgs e)
        {
            if (CB1_IsChecked == true)  CB1_IsEnabled = true; 
        }

    }
}
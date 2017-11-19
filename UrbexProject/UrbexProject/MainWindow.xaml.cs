using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UrbexProject
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class Accueil : Window
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Accueil_Click(object sender, RoutedEventArgs e)
        {
            A_browser.Visibility = Visibility.Visible;
            A_border.Visibility = Visibility.Visible;
            S_carte1.Visibility = Visibility.Hidden;
        }

        private void Spots_Click(object sender, RoutedEventArgs e)
        {
            Spots s1 = new Spots();
            s1.Show();
        }

        private void Histoire_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" azyyyyy mon poste");
        }
    }
}

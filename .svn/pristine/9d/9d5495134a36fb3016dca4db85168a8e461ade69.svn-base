using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ClassLibrary;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UrbexProject.UsersControlAdmin
{
    /// <summary>
    /// Logique d'interaction pour SpotsPage2.xaml
    /// </summary>
    public partial class SpotsPage2 : UserControl
    {
        public Spots DicoSpotPage { get; set; }
        public SpotsPage2(Spots DicoSpot)
        {
            InitializeComponent();
            DicoSpotPage = DicoSpot;
        }

        private void AjoutLieu(object sender, RoutedEventArgs e)
        {
            SpotsPagesModif.AddLieu a = new SpotsPagesModif.AddLieu(DicoSpotPage);
            a.Show();
        }

        private void SuppressionLieu(object sender, RoutedEventArgs e)
        {
            var s = new SpotsPagesModif.SuppLieu(DicoSpotPage);
            s.Show();
        }
    }
}

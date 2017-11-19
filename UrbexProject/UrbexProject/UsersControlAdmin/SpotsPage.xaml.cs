using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ClassLibrary;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UrbexProject.UsersControlAdmin
{/// <summary>
 /// Logique d'interaction pour SpotsPage.xaml
 /// </summary>
    public partial class SpotsPage : UserControl
    {
        public Spots DicoSpots { get; set; }
        public SpotsPage(Spots Dico)
        {
            InitializeComponent();
            DicoSpots = Dico;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            var a = new SpotsPagesModif.AddRegion(DicoSpots);
            a.ShowDialog();
        }
        private void Supp(object sender, RoutedEventArgs e)
        {
            var s = new SpotsPagesModif.SuppRegion(DicoSpots);
            s.ShowDialog();
        }
    }
}

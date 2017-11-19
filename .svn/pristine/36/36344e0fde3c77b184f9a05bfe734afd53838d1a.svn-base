using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ClassLibrary;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UrbexProject.UsersControlAdmin.SpotsPagesModif
{
    /// <summary>
    /// Logique d'interaction pour SuppLieu.xaml
    /// </summary>
    public partial class SuppLieu : Window
    {
        public Spots DicoSpots { get; set; }
        public SuppLieu(Spots Dico)
        {
            InitializeComponent();
            DicoSpots = Dico;
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            foreach(Region r in DicoSpots.Endroits.Keys)
            {
                if(r.Nom == NomRegion.Text)
                {
                    foreach(Lieu l in DicoSpots.Endroits[r])
                    {
                        if(l.Nom == NomLieu.Text)
                        {
                            DicoSpots.Endroits[r].Remove(l);
                            Close();
                            return;
                        }
                    }
                }
            }
        }
    }
}

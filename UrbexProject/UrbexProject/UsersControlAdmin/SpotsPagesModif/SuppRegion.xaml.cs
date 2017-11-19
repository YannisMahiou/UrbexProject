using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ClassLibrary;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UrbexProject.UsersControlAdmin.SpotsPagesModif
{
    /// <summary>
    /// Logique d'interaction pour SuppRegion.xaml
    /// </summary>
    public partial class SuppRegion : Window
    {
        public Spots DicoSpots { get; set; }
        public SuppRegion(Spots Dico)
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
                    DicoSpots.Endroits.Remove(r);                   
                    Close();
                    return;
                }
            }            
        }
    }
}

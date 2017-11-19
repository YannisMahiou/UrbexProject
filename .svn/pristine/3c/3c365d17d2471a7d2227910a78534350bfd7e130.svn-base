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
using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UrbexProject.UsersControlAdmin.SpotsPagesModif
{
    /// <summary>
    /// Logique d'interaction pour AddLieu.xaml
    /// </summary>
    public partial class AddLieu : Window
    {
        public Spots Dico { get; set; }
        public AddLieu(Spots DicoSpots)
        {
            InitializeComponent();
            Dico = DicoSpots;
        }

        private void Galerie(object sender, RoutedEventArgs e)
        {
            Galerie g = new Galerie();
            g.ShowDialog();
            GalerieResult.Text = g.UrlChoisie;
             
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            if(DescriptionLieu.Text != "" && NomLieu.Text != "" && NomRegion.Text != "")
            {
                foreach(Region r in Dico.Endroits.Keys)
                {
                    if(r.Nom == NomRegion.Text)
                    {
                        Dico.Endroits[r].Add(new Lieu(NomLieu.Text, GalerieResult.Text, DescriptionLieu.Text));
                    }
                }
                Close();
            }
            else
            {
                MessageBox.Show("Il faut remplir les champs !");
                return;
            }
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

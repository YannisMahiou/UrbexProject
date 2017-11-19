using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ClassLibrary;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UrbexProject.UsersControlAdmin.SpotsPagesModif
{
    /// <summary>
    /// Logique d'interaction pour AddRegion.xaml
    /// </summary>
    public partial class AddRegion : Window
    {
        public Spots _Dico { get; set; }
        public Spots Dico
        {
            get
            {
                return _Dico;
            }
            set
            {
                _Dico = value;
            }
        }
        public AddRegion(Spots DicoSpots)
        {
            InitializeComponent();
            Dico = DicoSpots;
        }

        private void ouvrirGalerie(object sender, RoutedEventArgs e)
        {
            var g = new Galerie();
            g.ShowDialog();
            retourGalerie.Text = g.UrlChoisie;
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            if(DescriptionRegion.Text != "" && NomRegion.Text != "" && retourGalerie.Text != "")
            {
                Dico.AddSpots(new Region(DescriptionRegion.Text, NomRegion.Text, retourGalerie.Text), new ObservableCollection<Lieu>());
                MessageBox.Show("Toutes modifications apportées à la liste de région sera effectué au prochain lancement de celle-ci");
                Close();
            }
            else
            {
                MessageBox.Show("Vous deves remplir les champs !");
                return;
            }
            
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

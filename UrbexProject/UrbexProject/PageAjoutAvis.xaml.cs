using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ClassLibrary;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UrbexProject
{
    /// <summary>
    /// Logique d'interaction pour PageAjoutAvis.xaml
    /// </summary>
    public partial class PageAjoutAvis : Window
    {
        public Spots DicoAjourAvis { get; set; }
        public Region RegionAjoutAvis { get; set; }
        public Lieu LieuAjoutAvis { get; set; }
        public Connexion ConnexionAjoutAvis { get; set; }
        public PageAjoutAvis(Spots dico, Connexion connexion, Region region, Lieu lieu)
        {
            InitializeComponent();
            DicoAjourAvis = dico;
            RegionAjoutAvis = region;
            LieuAjoutAvis = lieu;
            ConnexionAjoutAvis = connexion;

            groot.DataContext = this;
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            int j;
            Int32.TryParse(noteAvis.Text, out j);
            if (noteAvis.Text == null || j <0 || j > 10)
            {
                MessageBox.Show("Vous devez obligatoirement mettre une note !");
                return; 
            }
            foreach (Region r in DicoAjourAvis.Endroits.Keys)
            {
                if (r == RegionAjoutAvis)
                {
                    foreach (ObservableCollection<Lieu> l in DicoAjourAvis.Endroits.Values)
                    {
                        foreach (Lieu lieu in l)
                        {
                            if (lieu == LieuAjoutAvis)
                            {
                                lieu.AddAvis(new Avis(j, commentAvis.Text, ConnexionAjoutAvis.UserName));
                                Close();
                            }
                        }
                    }
                }
            }
        }
    }
}

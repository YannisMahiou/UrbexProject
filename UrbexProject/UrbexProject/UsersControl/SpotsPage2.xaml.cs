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

namespace UrbexProject.UsersControl
{
    /// <summary>
    /// Logique d'interaction pour SpotsPage2.xaml
    /// </summary>
    public partial class SpotsPage2 : UserControl
    {
        public static readonly DependencyProperty ConnectSpot2Property = DependencyProperty.Register("ConnectSpot2", typeof(Connexion), typeof(SpotsPage2));
        public Connexion ConnectSpot2
        {
            get
            {
                return GetValue(ConnectSpot2Property) as Connexion;
            }
            set
            {
                SetValue(ConnectSpot2Property, value);
            }
        }

        public static readonly DependencyProperty SelectedItem2Property = DependencyProperty.Register("SelectedItem2", typeof(KeyValuePair<Region, ObservableCollection<Lieu>>), typeof(SpotsPage2));
        public KeyValuePair<Region, ObservableCollection<Lieu>> SelectedItem2
        {
            get
            {
                return (KeyValuePair<Region, ObservableCollection<Lieu>>)GetValue(SelectedItem2Property);
            }
            set
            {
                SetValue(SelectedItem2Property, value);
            }
        }

        public static readonly DependencyProperty DicoSpot2Property = DependencyProperty.Register("DicoSpot2", typeof(Spots), typeof(SpotsPage2));
        public Spots DicoSpot2
        {
            get
            {
                return GetValue(DicoSpot2Property) as Spots;
            }
            set
            {
                SetValue(DicoSpot2Property, value);
            }
        }

        public SpotsPage2()
        {
            InitializeComponent();
            GridPrincipale.DataContext = this;
        }

        private void Ajout(object sender, RoutedEventArgs e)
        {
            if (ConnectSpot2 != null)
            {
                if(ListeValue.SelectedItem == null)
                {
                    MessageBox.Show("Vous devez sélectionner un lieu pour ajouter un avis !");
                }
                else
                {
                    PageAjoutAvis pa = new PageAjoutAvis(DicoSpot2, ConnectSpot2, SelectedItem2.Key, ListeValue.SelectedItem as Lieu);
                    pa.Show();
                }              
            }
            else
            {
                MessageBox.Show("Vous devez être connecté pour pouvoir utiliser cette fonctionnalité !");
            }
        }
    }
}

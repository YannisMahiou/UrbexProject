using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ClassLibrary;
using Data;
using System.Windows.Controls;
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
    /// Logique d'interaction pour SpotsPage.xaml
    /// </summary>
    public partial class SpotsPage : UserControl
    {
        public static readonly DependencyProperty ConnectSpotProperty = DependencyProperty.Register("ConnectSpot", typeof(Connexion), typeof(SpotsPage), new FrameworkPropertyMetadata(OnMaPropertyChanged));
        public Connexion ConnectSpot
        {
            get {
                return GetValue(ConnectSpotProperty) as Connexion;
            }
            set {
                SetValue(ConnectSpotProperty, value);
            }
        }

        public static readonly DependencyProperty DicoSpotProperty = DependencyProperty.Register("DicoSpot", typeof(Spots), typeof(SpotsPage));
        public Spots DicoSpot
        {
            get
            {
                return GetValue(DicoSpotProperty) as Spots;
            }
            set
            {
                SetValue(DicoSpotProperty, value);
            }
        }
        public static readonly DependencyProperty RegistreSpotProperty = DependencyProperty.Register("RegistreSpot", typeof(AllUser), typeof(SpotsPage));
        public AllUser RegistreSpot
        {
            get
            {
                return GetValue(RegistreSpotProperty) as AllUser;
            }
            set
            {
                SetValue(RegistreSpotProperty, value);
            }
        }

        public static readonly DependencyProperty SelectedItem1Property = DependencyProperty.Register("SelectedItem1", typeof(KeyValuePair<Region, ObservableCollection<Lieu>>), typeof(SpotsPage));
        public KeyValuePair<Region, ObservableCollection<Lieu>> SelectedItem1
        {
            get
            {
                return (KeyValuePair<Region, ObservableCollection<Lieu>>)GetValue(SelectedItem1Property);
            }
            set
            {
                SetValue(SelectedItem1Property, value);
            }
        }
        public SpotsPage()
        {
            InitializeComponent();
            AllUser Registre = new AllUser();
            grid1.DataContext = this;

        }
        private static void OnMaPropertyChanged(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            SpotsPage control = source as SpotsPage;
            control.TestConnexion();
        }

        private void listeRegion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedItem1 = (KeyValuePair<Region, ObservableCollection<Lieu>>)listeRegion.SelectedItem;
        }
        public void TestConnexion()
        {
            if (ConnectSpot == null)
            {
                contentSpot.Content = null;
                contentSpot2.Content = null;
            }
            else
            {
                foreach (User u in RegistreSpot.Lregistre)
                {
                    if (u.Pseudo == ConnectSpot.UserName && u.GetType() == typeof(Admin))
                    {
                        contentSpot.Content = new UsersControlAdmin.SpotsPage(DicoSpot);
                        contentSpot2.Content = new UsersControlAdmin.SpotsPage2(DicoSpot);
                    }
                }
            }
        }
    }
}

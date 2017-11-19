using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using ClassLibrary;
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
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : UserControl
    {
        public ObservableCollection<Topic> SujetAccueilAdmin { get; set; }
        public Connexion ConnectAdmin { get; set; }
        public AllUser RegistreUser { get; set; }
        public Accueil(ObservableCollection<Topic> SujetAccueil, Connexion ConnectAccueilAdmin, AllUser Registre)
        {
            InitializeComponent();
            SujetAccueilAdmin = SujetAccueil;
            ConnectAdmin = ConnectAccueilAdmin;
            RegistreUser = Registre;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            AccueilPagesModif.Add a = new AccueilPagesModif.Add(SujetAccueilAdmin, ConnectAdmin, RegistreUser);
            a.Show();
        }

        private void Supp(object sender, RoutedEventArgs e)
        {
            AccueilPagesModif.Supp s = new AccueilPagesModif.Supp(SujetAccueilAdmin);
            s.Show();
        }
    }
}

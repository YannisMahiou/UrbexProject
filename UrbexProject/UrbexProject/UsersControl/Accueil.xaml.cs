using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ClassLibrary;
using Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UrbexProject.UsersControl
{
    /// <summary>
    /// Logique d'interaction pour Acceuil.xaml
    /// </summary>
    public partial class Accueil : UserControl
    {
        public static readonly DependencyProperty RegistreAccueilProperty = DependencyProperty.Register("RegistreAccueil", typeof(AllUser), typeof(Accueil));
        public AllUser RegistreAccueil
        {
            get
            {
                return GetValue(RegistreAccueilProperty) as AllUser;
            }
            set
            {
                SetValue(RegistreAccueilProperty, value);
            }
        }

        public static readonly DependencyProperty ConnectAccueilProperty = DependencyProperty.Register("ConnectAccueil", typeof(Connexion), typeof(Accueil), new FrameworkPropertyMetadata(OnMaPropertyChanged));
        public Connexion ConnectAccueil
        {
            get
            {
                return GetValue(ConnectAccueilProperty) as Connexion;
            }
            set
            {
                SetValue(ConnectAccueilProperty, value);
            }
        }
        public static readonly DependencyProperty SujetAccueilProperty = DependencyProperty.Register("SujetAccueil", typeof(ObservableCollection<Topic>), typeof(Accueil));
        public ObservableCollection<Topic> SujetAccueil
        {
            get
            {
                return GetValue(SujetAccueilProperty) as ObservableCollection<Topic>;
            }
            set
            {
                SetValue(SujetAccueilProperty, value);
            }
        }
        public Accueil()
        {
            InitializeComponent();
            GridPrincipaleAccueil.DataContext = this;
                 
        }
        private static void OnMaPropertyChanged(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            Accueil control = source as Accueil;
            control.TestConnexion();
        }

        public void AddTopic(Topic topic)
        {
            SujetAccueil.Add(topic);
        }

        public void TestConnexion()
        {
            if(ConnectAccueil == null)
            {
                ModifArticle.Content = null;
            }
            else
            {
                foreach (User u in RegistreAccueil.Lregistre)
                {
                    if (u.Pseudo == ConnectAccueil.UserName && u.GetType() == typeof(Admin))
                    {
                        ModifArticle.Content = new UsersControlAdmin.Accueil(SujetAccueil, ConnectAccueil, RegistreAccueil);
                    }
                }
            }            
        }
    }
}

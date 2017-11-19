using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Data;
using ClassLibrary;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace UrbexProject
{
    /// <summary>
    /// Logique d'interaction pour FenetrePrincipal.xaml
    /// </summary>
    public partial class FenetrePrincipal : Window
    {
        public static readonly DependencyProperty RegistreProperty = DependencyProperty.Register("Registre", typeof(AllUser), typeof(FenetrePrincipal));
        public AllUser Registre
        {
            get
            {
                return GetValue(RegistreProperty) as AllUser;
            }
            set
            {
                SetValue(RegistreProperty, value);
            }
        }

        public static readonly DependencyProperty DicoProperty = DependencyProperty.Register("Dico", typeof(Spots), typeof(FenetrePrincipal));
        public Spots Dico
        {
            get
            {
                return GetValue(DicoProperty) as Spots;
            }
            set
            {
                SetValue(DicoProperty, value);
            }
        }

        public static readonly DependencyProperty ConnectProperty = DependencyProperty.Register("Connect", typeof(Connexion), typeof(FenetrePrincipal));
        public Connexion Connect
        {
            get
            {
                return GetValue(ConnectProperty) as Connexion;
            }
            set
            {
                SetValue(ConnectProperty, value);
            }
        }

        public static readonly DependencyProperty SujetProperty = DependencyProperty.Register("Sujet", typeof(ObservableCollection<Topic>), typeof(FenetrePrincipal));
        public ObservableCollection<Topic> Sujet
        {
            get
            {
                return GetValue(SujetProperty) as ObservableCollection<Topic>;
            }
            set
            {
                SetValue(SujetProperty, value);
            }
        }
        public static readonly DependencyProperty HistoireProperty = DependencyProperty.Register("Histoire", typeof(Topic), typeof(FenetrePrincipal));
        public Topic Histoire
        {
            get
            {
                return GetValue(HistoireProperty) as Topic;
            }
            set
            {
                SetValue(HistoireProperty, value);
            }
        }
        public static readonly DependencyProperty ReglesProperty = DependencyProperty.Register("Regles", typeof(Topic), typeof(FenetrePrincipal));
        public Topic Regles
        {
            get
            {
                return GetValue(ReglesProperty) as Topic;
            }
            set
            {
                SetValue(ReglesProperty, value);
            }
        }
        public static readonly DependencyProperty ESPProperty = DependencyProperty.Register("ESP", typeof(Topic), typeof(FenetrePrincipal));
        public Topic ESP
        {
            get
            {
                return GetValue(ESPProperty) as Topic;
            }
            set
            {
                SetValue(ESPProperty, value);
            }
        }
        public FenetrePrincipal()
        {
            Directory.SetCurrentDirectory(System.IO.Path.Combine("../../../Data/XML"));

            InitializeComponent();
            Connect = null;

            Xml xml = new Xml();
            Dico = xml.loadSpot();
            Sujet = xml.loadTopic();
            Registre = xml.loadUser();
            Histoire = xml.LoadTopicHistoire();
            Regles = xml.LoadTopicRegles();
            ESP = xml.LoadTopicESP();

        }

        private void FermetturePagePrincipale(object sender, RoutedEventArgs e)
        {
            Xml saver = new Xml();
            saver.saveData(Dico,Registre, Sujet, Histoire, Regles, ESP); 
            Application.Current.Shutdown();
        }

        private void Click_Connexion(object sender, RoutedEventArgs e)
        {
            if (Connect == null)
            {
                PageConnexion s1 = new PageConnexion(Connect, Registre);
                s1.ShowDialog();
                Connect = s1.ConnectPC;
                if (Connect != null)
                {
                    foreach(User u in Registre.Lregistre)
                    {
                        if(Connect.UserName == u.Pseudo)
                        {
                            
                        }
                    }                    
                    connexion.Content = "Deconnexion";
                    return;
                }             
            }
            if (Connect != null)
            {
                connexion.Content = "Connexion";
                Connect = null;
            }
        }

        private void Agrandir(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }

        }
    }
}

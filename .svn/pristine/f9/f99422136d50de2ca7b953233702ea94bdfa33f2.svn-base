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

namespace UrbexProject.UsersControlAdmin.AccueilPagesModif
{
    /// <summary>
    /// Logique d'interaction pour Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public ObservableCollection<Topic> SujetAdd { get; set; }
        public Connexion ConnectAdd { get; set; }
        public AllUser Registre { get; set; }
        public Add(ObservableCollection<Topic> sujet, Connexion connectAdmin, AllUser RegistreUser)
        {
            InitializeComponent();
            grootAdmin.DataContext = this;
            SujetAdd = sujet;
            ConnectAdd = connectAdmin;
            Registre = RegistreUser;
            comboTopic.ItemsSource = SujetAdd;
        }

        private void CheckBoxTopic_Checked(object sender, RoutedEventArgs e)
        {
            AddTopic1.Opacity = 1;
            AddTopic2.Opacity = 1;
            AddArticle1.Opacity = 0.3;
            AddArticle2.Opacity = 0.3;
            if(checkArticle.IsChecked == true)
            {
                checkArticle.IsChecked = false;
            }
        }

        private void CheckArticle_Checked(object sender, RoutedEventArgs e)
        {
            AddArticle1.Opacity = 1;
            AddArticle2.Opacity = 1;
            AddTopic1.Opacity = 0.3;
            AddTopic2.Opacity = 0.3;
            if (checkTopic.IsChecked == true)
            {
                checkTopic.IsChecked = false;
            }
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            if(checkTopic.IsChecked == true)
            {
                SujetAdd.Add(new Topic(nomTopic.Text, Registre.ResearchUser(ConnectAdd.UserName) as Admin));
                Close();
            }
            if(checkArticle.IsChecked == true)
            {
                SujetAdd[comboTopic.SelectedIndex].AddArticle(Titre.Text, Texte.Text, Registre.ResearchUser(ConnectAdd.UserName) as Admin);
                Close();
            }
        }
    }
}

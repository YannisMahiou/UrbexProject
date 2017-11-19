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

namespace UrbexProject.UsersControlAdmin.AccueilPagesModif
{
    /// <summary>
    /// Logique d'interaction pour Supp.xaml
    /// </summary>
    public partial class Supp : Window
    {
        public ObservableCollection<Topic> SujetSupp { get; set; }
        public Supp(ObservableCollection<Topic> Sujet)
        {
            InitializeComponent();
            SujetSupp = Sujet;
            grootSuppAdmin.DataContext = this;
            comboSuppTopic.ItemsSource = SujetSupp;
            comboSuppArticle1.ItemsSource = SujetSupp;
        }

        private void CheckBoxTopic_Checked(object sender, RoutedEventArgs e)
        {
            suppTopic1.Opacity = 1;
            suppTopic2.Opacity = 1;
            suppArticle1.Opacity = 0.3;
            suppArticle2.Opacity = 0.3;
            if (checkArticle.IsChecked == true)
            {
                checkArticle.IsChecked = false;
            }
        }

        private void CheckArticle_Checked(object sender, RoutedEventArgs e)
        {
            suppArticle1.Opacity = 1;
            suppArticle2.Opacity = 1;
            suppTopic1.Opacity = 0.3;
            suppTopic2.Opacity = 0.3;
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
            if (checkTopic.IsChecked == true)
            {
                foreach(Topic t in SujetSupp)
                {
                    if(t.Nom == SujetSupp[comboSuppTopic.SelectedIndex].Nom)
                    {
                        SujetSupp.Remove(t);
                        break;
                    }
                }
            }
            if (checkArticle.IsChecked == true)
            {
                foreach (Topic t in SujetSupp)
                {
                    if (t == SujetSupp[comboSuppArticle1.SelectedIndex])
                    {
                        foreach (Article a in t.LArticle)
                        {
                            if (a.Titre == TextSuppArticle.Text)
                            {
                                t.LArticle.Remove(a);
                                break;
                            }
                        }
                    }
                }
            }
            Close();
        }
    }
}

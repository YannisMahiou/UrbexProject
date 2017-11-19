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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UrbexProject
{
    /// <summary>
    /// Logique d'interaction pour PageConnexion.xaml
    /// </summary>
    public partial class PageConnexion : Window
    {
        public Connexion ConnectPC { get; set; }
        public AllUser Registre { get; set; }
        public PageConnexion(Connexion connect, AllUser registre)
        {
            InitializeComponent();
            ConnectPC = connect;
            Registre = registre;
        }

        private void SeConnecter(object sender, RoutedEventArgs e)
        {
            if(ConnectPC == null)
            {
                string pseudo = this.Pseudo.Text;
                string mdp = this.Password.Password;
                ConnectPC = Login(pseudo, mdp);
            }
            if(ConnectPC != null)
            {
                Close();
            }
        }

        private Connexion Login(string pseudo, string mdp)
        {
            Connexion test = new Connexion(pseudo, mdp);
            int a = test.SeConnecter(Registre);
            if(a == 0)
            {
                MessageBox.Show("Mauvais Pseudo et/ou Mot de passe !");
                return null;
            }
            else
            {
                return test;
            }
        }

        private void InscriptionClick(object sender, RoutedEventArgs e)
        {
            string pseudo = Pseudo2.Text;
            string mdp = Password2.Password;
            string mail = Mail.Text;

            if(mdp != Password3.Password)
            {
                MessageBox.Show("Mdp différents !");
                return;           
            }
            else
            {
                foreach(User u in Registre.Lregistre)
                {
                    if(u.Pseudo == pseudo)
                    {
                        MessageBox.Show("Pseudo déjà utilisé !");
                        return;
                    }
                    if (u.Mail == mail)
                    {
                        MessageBox.Show("Un compte utilise déjà ce mail !");
                        return;
                    }
                }
                Registre.AddUser(new User(pseudo, mdp, mail));
                ConnectPC = Login(pseudo, mdp);
                Close();
            }
        }
    }
}

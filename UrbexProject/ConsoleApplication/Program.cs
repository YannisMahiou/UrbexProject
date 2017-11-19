// ======================================================================== 
// 
// Module       : Program.cs - Source File
// Author       : Yannis Mahiou & Guillaume Cothenet
// Creation date: 03-04-2017 
// 
// ======================================================================== 

using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Data;
using static System.Console;
using System.IO;

namespace ConsoleApplication
{  
    class Program
    {
        static void Main(string[] args)
        {
            Spots dico = new Spots();
            AllUser Registre = new AllUser();
            ObservableCollection<Topic> Sujet = new ObservableCollection<Topic>();
            Stub stub = new Stub();
            dico = stub.loadSpot();
            Sujet = stub.loadTopic();
            Registre = stub.loadUser();
            Avis avis = new Avis(15, "je sais pas", "guillaume");
            Connexion connect = null;

            //test recherche d'un utilisateur
            RechercheUser("guillaume", Registre);

            //test du changement d'un avis
            while(connect == null)
            {
                Console.WriteLine("\nVous devez être connecté pour faire cela !\n");
                //Test de la connexion
                Console.Write("\nPseudo : ");
                string a = Console.ReadLine();
                Console.Write("\nPassword : ");
                string b = Console.ReadLine();
                connect = Login(a, b, Registre);
            }
            ChangementAvis(avis);

            //affichage de la liste des utilisateur
            Console.WriteLine("Voulez-vous afficher la liste des utilisateurs ? (oui/non)");
            string res = Console.ReadLine();
            if (res == "oui")
            {
                AffichageListeUser(Registre);
            }

            //test de la suppression d'un utilisateur
            Console.WriteLine("Voulez-vous supprimer un utilisateur de la liste ? (oui/non)");
            res = Console.ReadLine();
            if (res == "oui")
            {
                Console.WriteLine("Lequel ? (pseudo)");
                string d = Console.ReadLine();
                SupprimerUser(d, Registre);
            }

            foreach (User u in Registre.Lregistre)
            {
                Console.WriteLine(u.ToString());
            }

            //affiche la map
            Console.WriteLine("Voulez-vous afficher la liste des régions et les lieux ? (oui/non)");
            res = Console.ReadLine();
            if (res == "oui")
            {
                AfficherSpots(dico);
            }

            //test de la liste d'avis
            Console.WriteLine("Voulez-vous ajouter un avis ? (oui/non)");
            res = Console.ReadLine();
            if (res == "oui")
            {
                Console.WriteLine("Dans quelle région est le lieu que vous voulez commenter ?");
                string region = Console.ReadLine();
                Console.WriteLine("Quel lieu voulez-vous commenter ?");
                string lieuChoisi = Console.ReadLine();
                Console.WriteLine("Quelle note voulez-vous lui donner ? (/10)");
                int noteDonne = int.Parse(Console.ReadLine()); // le ".Parse" sert a convertir une chaine de caractères en entier 
                Console.WriteLine("Quel commentaire voulez-vous lui donner ?");
                string commentDonne = Console.ReadLine();
                ListeAvis(dico, region, lieuChoisi, noteDonne, commentDonne);
            }

            //affiche de tous les commentaires
            Console.WriteLine("Voulez-vous afficher tous les commentaires ? (oui/non)");
            res = Console.ReadLine();
            if (res == "oui")
            {
                AffichageCommentaire(dico);
            }
        }

        public static void RechercheUser(string pseudo, AllUser Registre)
        {
            User userAChercher = Registre.ResearchUser(pseudo);
            Console.WriteLine($"{userAChercher}\n");
        }

        public static void ChangementAvis(Avis a)
        {
            Console.WriteLine(a.ToString());
            a.ChangerAvis("tres bien");
            Console.WriteLine(a.ToString());
        }

        public static void AffichageListeUser(AllUser Registre)
        {
            foreach (User u in Registre.Lregistre)
            {
                Console.WriteLine(u.Pseudo);
            }
        }

        public static void SupprimerUser(string pseudo, AllUser Registre)
        {
            Registre.DeleteUser(pseudo);
        }
            
        public static void AfficherSpots(Spots dico)
        {
            //foreach (Region r in dico.Endroits.Keys)
            //{
                //Console.WriteLine(r);
                foreach (ObservableCollection<Lieu> l in dico.Endroits.Values)
                {
                    foreach (Lieu lieu in l)
                    {
                        Console.WriteLine(lieu);
                    }
                }
            //}
        }
            
        public static void ListeAvis(Spots dico, string region, string lieuChoisi, int noteDonne, string commentDonne)
        {
            foreach (Region r in dico.Endroits.Keys)
            {
                if (r.Nom == region)
                {
                    foreach (ObservableCollection<Lieu> l in dico.Endroits.Values)
                    {
                        foreach (Lieu lieu in l)
                        {
                            if (lieu.Nom == lieuChoisi)
                            {
                                lieu.AddAvis(new Avis(noteDonne, commentDonne, "fabien"));
                            }
                        }
                    }
                }
            }
        }
            
        public static void AffichageCommentaire(Spots dico)
        {
            foreach (ObservableCollection<Lieu> l in dico.Endroits.Values)
            {
                foreach (Lieu lieu in l)
                {
                    for (int i = 0; i < lieu.ListeAvis.Count(); i++)
                    {
                        Console.WriteLine($"Lieu : {lieu.Nom}, { lieu.ListeAvis[i]}");
                    }
                }
            }
        }

        public static Connexion Login(string username, string password, AllUser Registre)
        {
            Connexion test = new Connexion(username, password);
            int a = test.SeConnecter(Registre);
            if(a == 0)
            {
                Console.WriteLine("\n~~~~ Vous avez entré un mauvais username/password ~~~~\n");
                return null;
            }
            else
            {
                Console.WriteLine($"\n~~~~ Vous êtes désormais connecté en temps que {username} ~~~~\n");
                return test;
            }
        }

    }
}

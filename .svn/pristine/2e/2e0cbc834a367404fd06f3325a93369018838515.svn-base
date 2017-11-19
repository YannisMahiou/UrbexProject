// ======================================================================== 
// 
// Module       : Stub.cs - Source File
// Author       : Yannis Mahiou & Guillaume Cothenet
// Creation date: 03-04-2017 
// 
// ======================================================================== 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using ClassLibrary;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;
using Data;

namespace Data
{ 
    /// <summary>
    /// Cette classe permet de tester les différents fonctionnalités du Projet
    /// </summary>
    public class Stub : ILoad 
    {
        public Stub() { }

        public AllUser loadUser()
        {
            AllUser Registre = new AllUser();

            //Test d'ajout d'utilisateurs (User) au Registre
            Registre.AddUser(new User("guillaume", "guigui71", "guillaume@gmail.com"));
            Registre.AddUser(new User("fabien", "fab71", "fabien@gmail.com"));
            Registre.AddUser(new User("yannis", "yan71", "yannis@gmail.com"));
            Registre.AddUser(new User("alex", "alex71", "alex@gmail.com"));

            //Test d'ajout d'utilisateurs (Admin) au Registre
            Registre.AddAdmin(new Admin("admin", "admin", "admin@gmail.com", "Le grand méchant loup"));
            Admin boss = new Admin("boosDuGame", "toto", "boss@gmail.com", "Sympa");
            Registre.AddAdmin(boss);

            return Registre;

        }

        public Spots loadSpot()
        {
            Spots dico = new Spots();
            ObservableCollection<Lieu> Ltest = new ObservableCollection<Lieu>();
            ObservableCollection<Lieu> Ltest2 = new ObservableCollection<Lieu>();

            //Test pour les Regions
            Region Auvergne = new Region("Région situé au centre de la france, elle est connue pour sa chaine de puys.", "Auvergne", "");
            Region Bretagne = new Region("Région très souvent considérée comme le royaume de la pluie, elle saura vous suprendre.", "Bretagne", "");

            //Test d'ajout de plusieurs Lieu à l'OberservableCollection Ltest1
            Ltest.Add(new Lieu("Chateau", "../Image/chateau.jpg", "Vraiment très bien"));
            Ltest.Add(new Lieu("Bateau", "../Image/bateau.jpg", "Vraiment très bien"));
            Ltest.Add(new Lieu("Maison", "../Image/maison.jpg", "Vraiment très bien"));

            //Ajout d'un avis pour le Lieu lieu
            Lieu lieu = new Lieu("champ", "../Image/champTest.png", "Un champ (du latin campus) est un espace défini et ouvert, parcelle de terre cultivée ou terrain réservé à une activité spécifique. Par extension de sens, un champ est une étendue virtuelle dans un domaine donné, par exemple champ d'application ou champ d'action. Champ ou champ’ est aussi une abréviation familière pour « champagne », lui - même signifiant « vin de Champagne » mais aussi pour le mot champignon.");
            Ltest2.Add(lieu);
            lieu.AddAvis(new Avis(7, "Je recommende chaudement ce site. A défault d'être éloigné de toute civilisation, il vous offrira sans aucun doute un moment de détente dont vous vous souviendrez longtemps !", "guillaume"));

            //Test d'ajout de 2 spots, composé de Region et des Lieux
            dico.AddSpots(Auvergne, Ltest);
            dico.AddSpots(Bretagne, Ltest2);

            return dico;
        }

        public ObservableCollection<Topic> loadTopic()
        {
            ObservableCollection<Topic> Sujet = new ObservableCollection<Topic>();

            Admin boss = new Admin("boosDuGame", "toto", "boss@gmail.com", "Sympa");
            Topic Actualite = new Topic("Actualité", boss);
            Topic New = new Topic("New", boss);
            Topic NousContacter = new Topic("NousContacter", boss);

            Sujet.Add(Actualite);
            Sujet.Add(New);
            Sujet.Add(NousContacter);

            Actualite.AddArticle("New tableau", "Une description comme une autre est plutot jolie car j'aime les champignons", boss);
            Actualite.AddArticle("Databinding ok", "Ceci est un test, a ne pas prendre au premier °C bien sur ! Pouet !", boss);
            Actualite.AddArticle("Une petite chanson", "Du texte -> il en faut peut pour être heureux, vraiment très peu pour être heureux, il faut se satisfaire du nécessaire", boss);
            New.AddArticle("C'est la Fin ?!", "Incroyable nouvelle : il se pourrait bien que l'on ait bientôt finit notre application ! Plus d'info sur BFM-C#", boss);
            NousContacter.AddArticle("Contacter", "Afin de nous contacter, il vous suffit de vous rendre sur google, taper chaussette et prendre le 3ème site de la page 99.", boss);

            return Sujet;
        }

        public Topic LoadTopicHistoire()
        {
            Admin boss = new Admin("boosDuGame", "toto", "boss@gmail.com", "Sympa");
            Topic Histoire = new Topic("Histoire", boss);

            Histoire.AddArticle("Début", "L'exploration urbaine, au sens propre, désigne le fait de recueillir des données sur des zones publiques du paysage urbain, délaissées tout ou partie du temps, en vue d'y accéder et de les utiliser. Cette activité, bien que clandestine et faite sans l'autorisation des éventuels propriétaires, n'est prohibée en France que par quelques décrets, arrêtés préfectoraux, ou règlements internes de certaines administrations. Les exemples de cette activité sont rares et peu connus, pour des raisons pratiques évidentes liées à toute activité clandestine. On peut malgré tout citer celui de l'UX ou Urban eXperiment, dont l'Exploration Urbaine, au sens propre fut l'activité préliminaire, au début des années 1980", boss);

            return Histoire;
        }
        public Topic LoadTopicRegles()
        {
            Admin boss = new Admin("boosDuGame", "toto", "boss@gmail.com", "Sympa");
            Topic Regles = new Topic("Histoire", boss);

            Regles.AddArticle("Règle 1", "Ne pas faire n'importe quoi Ne pas faire n'importe quoi Ne pas faire n'importe quoi Ne pas faire n'importe quoi Ne pas faire n'importe quoi Ne pas faire n'importe quoi Ne pas faire n'importe quoi Ne pas faire n'importe quoi Ne pas faire n'importe quoi Ne pas faire n'importe quoi Ne pas faire n'importe quoi !", boss);
            Regles.AddArticle("Règle 2", "Ne pas faire n'importe quoi !", boss);
            Regles.AddArticle("Règle 3", "Ne pas faire n'importe quoi !", boss);

            return Regles;
        }
        public Topic LoadTopicESP()
        {
            Admin boss = new Admin("boosDuGame", "toto", "boss@gmail.com", "Sympa");
            Topic ESP = new Topic("Histoire", boss);

            ESP.AddArticle("Site 1", "https://urbexsession.com/", boss);
            ESP.AddArticle("Site 2", "http://www.urbex.me/", boss);
            ESP.AddArticle("Site 3", "http://www.urbexplayground.com/fr", boss);

            return ESP;
        }
    }
}


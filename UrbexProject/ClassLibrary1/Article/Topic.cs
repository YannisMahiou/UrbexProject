// ======================================================================== 
// 
// Module       : Topic.cs - Source File
// Author       : Yannis Mahiou & Guillaume Cothenet
// Creation date: 03-04-2017 
// 
// ======================================================================== 

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassLibrary
{
    [DataContract (Name = "topic")]
     public class Topic
    {
        [DataMember]
        public string Nom
        {
            get;
            set;
        }

        [DataMember]
        public Admin Auteur
        {
            get;
            set;
        }

        [DataMember (Name = "lesArticles")]
        public ObservableCollection<Article> LArticle
        {
            get;
            set;
        }

        public Topic(string nom, Admin auteur)
        {
            Nom = nom;
            Auteur = auteur;
            LArticle = new ObservableCollection<Article>();
        }

        public void AddArticle(string titre, string texte, Admin auteurArticle)
        {
            LArticle.Add(new Article(titre, texte, auteurArticle));
        }
    }
}

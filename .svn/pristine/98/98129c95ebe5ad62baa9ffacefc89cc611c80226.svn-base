// ======================================================================== 
// 
// Module       : Article.cs - Source File
// Author       : Yannis Mahiou & Guillaume Cothenet
// Creation date: 03-04-2017 
// 
// ======================================================================== 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassLibrary
{
    /// <summary>
    /// Un article comprend un Titre et un Texte
    /// </summary>
 
    [DataContract (Name = "article")]
    public class Article
    {
        [DataMember]
        public string Titre
        {
            get;
            set;
        }

        [DataMember (Name ="contenuArticle")]
        public string Texte
        {
            get;
            set;
        }

        [DataMember]
        public Admin Administrateur
        {
            get;
            set;
        }

        [DataMember]
        public string DateArticle
        {
            get;
            set;
        }

        public Article(string titre, string texte, Admin administrateur)
        {
            Titre = titre;
            Texte = texte;
            Administrateur = administrateur;
            DateArticle = DateTime.Now.ToString();
        }

        /// <summary>
        /// Change l'avis qu'un utilisateur (admin?) à mis précédemment
        /// </summary>
        /// <param name="newTexte"> Le texte que l'on veut mettre à la place du Texte existant</param>
        public void Modifier(string newTexte)
        {
            Texte = newTexte;
        }
    }
}

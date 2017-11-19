// ======================================================================== 
// 
// Module       : Avis.cs - Source File
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
    /// Un avis est une évaluation d'un Lieu. Il est composé d'une Note, d'un Comment et évidemment de l'User qui le poste
    /// </summary>
    /// <seealso cref="Lieu"/>
    [DataContract]
    public class Avis
    {
        [DataMember]
        public int Note
        {
            get;
            set;
        }

        [DataMember (Name ="commentaire")]
        public string Comment
        {
            get;
            set;
        }

        [DataMember]
        public string Pseudo
        {
            get;
            set;
        }

        [DataMember (Name = "dateAvis")]
        public string DateAvis
        {
            get;
            set;
        }
        
        public Avis(int note, string comment, string pseudo)
        {
            Note = note;
            Comment = comment;
            Pseudo = pseudo;
            DateAvis = DateTime.Now.ToString();
        }

        /// <summary>
        /// Permet de changer l'avis
        /// </summary>
        /// <param name="newComment"> Nouvel avis pour remplacer l'avis antérieur </param>
        public void ChangerAvis(string newComment)
        {
            this.Comment = newComment;
        }

        public override string ToString()
        {
            return $"/n~~~~~~~~~~~~~~~~\nPar {Pseudo}, {DateAvis}\nNote : {Note}\nCommentaire : {Comment}\n~~~~~~~~~~~~~~~~\n";
        }
    }
}

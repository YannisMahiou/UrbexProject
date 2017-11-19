// ======================================================================== 
// 
// Module       : Lieu.cs - Source File
// Author       : Yannis Mahiou & Guillaume Cothenet
// Creation date: 03-04-2017 
// 
// ======================================================================== 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;


namespace ClassLibrary
{
    /// <summary>
    /// Un Lieu est sous-jacent d'une Region. Un Lieu a un Nom, une Note, une miniature, une Description, et également plusieurs Avis
    /// </summary>
    /// <seealso cref="Region"/>
    
    [DataContract (Name = "lieu")]
    public class Lieu : INotifyPropertyChanged
    {
        [DataMember ]
        public string Nom
        {
            get;
            set;
        }

        [DataMember]
        public int Note
        {
            get
            {
                return CalculNote();
            }
            set
            {
                NotifyPropertyChanged("Note");
            }
        }

        [DataMember(Name = "descriptionLieu")]
        public string Description
        {
            get;
            set;
        }

        [DataMember (Name = "image")]
        public string ImageLien
        {
            get;
            set;
        }

        [DataMember(EmitDefaultValue = false, Name = "listAvis")]
        public ObservableCollection<Avis> ListeAvis
        {
            get;
            set;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Lieu(string nom,string imageLien, string description)
        {
            this.Nom = nom;
            this.Note = -1;
            this.Description = description;
            this.ImageLien = imageLien;
            ListeAvis = new ObservableCollection<Avis>();
        }

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        /// <summary>
        /// Ajoute un avis
        /// </summary>
        /// <param name="avis"> Avis que l'on veut ajouter à l'ObservableCollection ListeAvis</param>
        public void AddAvis(Avis avis)
        {
            ListeAvis.Add(avis);
            Note = CalculNote();
        }

        /// <summary>
        /// Supprime un avis
        /// </summary>
        /// <param name="avis"> Avis que l'on veut supprimer de l'ObservableCollection ListeAvis</param>
        public void DeleteAvis(Avis avis)
        {
            ListeAvis.Remove(avis);
        }

        public int CalculNote()
        {
            int res = 0;
            int i = 0;
            foreach(Avis a in ListeAvis)
            {
                res += a.Note;
                i += 1;
            }
            if(i != 0)
            {
                return res / i;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return $"{Nom} est un très beau lieu, adapté a l'urbex. Il a une note moyenne de {Note}. {Description}";
        }
    }
}

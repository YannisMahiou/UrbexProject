// ======================================================================== 
// 
// Module       : Region.cs - Source File
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
using System.Collections.ObjectModel;
using System.Runtime;

namespace ClassLibrary
{
    [DataContract (Name = "region")]
    public class Region
    {
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        [DataMember (Name="nomRegion")]
        public string Nom
        {
            get;
            set;
        }

        [DataMember]
        public string CheminImage
        {
            get;
            set;
        }

        //[DataMember(EmitDefaultValue = false)]
        //public ObservableCollection<Lieu> LesLieux
        //{
        //    get;
        //    set;
        //}

        public Region(string description, string nom, string chemin)
        {
            this.Description = description;
            this.Nom = nom;
            this.CheminImage = chemin;
            //LesLieux = new ObservableCollection<Lieu>();
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}

// ======================================================================== 
// 
// Module       : Spots.cs - Source File
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

namespace ClassLibrary
{
    /// <summary>
    /// Un spot est un ensemble, définit par une Region, et une liste de Lieu. On utilise un dictionnary pour stocker ces données.
    /// </summary
    [DataContract, KnownType(typeof(Region)), KnownType(typeof(Lieu))]
    public class Spots
    {
        [DataMember(EmitDefaultValue = false, Name = "spots")]
        public Dictionary<Region, ObservableCollection<Lieu>> Endroits // pour chaque région, on a une ObservableCollection de Lieu
        {
            get;
            set;
        }

        public Spots()
        {
            Endroits = new Dictionary<Region, ObservableCollection<Lieu>>();
        }

        /// <summary>
        /// Ajoute un Spots au Dictionnary Endroits
        /// </summary>
        /// <param name="r"> La region que l'on veut ajouter </param>
        /// <param name="l"> Les Lieu qui se situent dans cette Region </param>
        public void AddSpots(Region r, ObservableCollection<Lieu> l)
        {
            Endroits.Add(r, l);
        }

    }
}

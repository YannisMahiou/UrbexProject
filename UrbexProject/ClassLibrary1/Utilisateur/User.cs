// ======================================================================== 
// 
// Module       : User.cs - Source file
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
    /// Un User est un utilisateur connecté de l'application. Il a un Nom, un Mail et un MotDePasse
    /// </summary>
    [DataContract, KnownType(typeof(Admin))]
    public class User //: IEquatable<User>
    {
        [DataMember]
        public string Pseudo
        {
            get;
            set;
        }

        [DataMember]
        public string Mail
        {
            get;
            set;
        }

        [DataMember]
        public string MotDePasse
        {
            get;
            set;
        }

        public User(string pseudo, string motDePasse, string mail)
        {
            this.Pseudo = pseudo;
            this.MotDePasse = motDePasse;
            this.Mail = mail;
        }

        public override string ToString()
        {
            return $"Bonjours je suis {Pseudo}";
        }

        /// <summary>
        /// Teste si l'objet o Equals() à cet User ou pas
        /// </summary>
        /// <param name="o">L'autre objet qui est comparé avec cet User</param>
        /// <returns>true si equals, false sinon</returns>
        //public override bool Equals(Object o)
        //{
        //    //check null
        //    if (object.ReferenceEquals(o, null))
        //    {
        //        return false;
        //    }

        //    if (object.ReferenceEquals(this, o))
        //    {
        //        return true;
        //    }

        //    if (this.GetType() != o.GetType())
        //    {
        //        return false;
        //    }

        //    return this.Equals(o as User);
        //}

        //public bool Equals(User other)
        //{
        //    return Pseudo == other.Pseudo;
        //}
    }
}

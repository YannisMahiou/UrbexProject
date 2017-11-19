// ======================================================================== 
// 
// Module       : Admin.cs - Source File
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
    /// Cette classe est une classe héritée de User. Un Admin est un User, mais a une description en plus
    /// </summary>
    [DataContract]
    public class Admin : User
    {
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Constructeur d'un Administrateur
        /// </summary>
        ///<seealso cref="User"/>
        public Admin(string pseudo, string mdp, string mail, string description) : base(pseudo, mdp, mail)
        {
            this.Description = description;
        }

        public override string ToString()
        {
            return $"Je suis un admin";
        }
    }
}

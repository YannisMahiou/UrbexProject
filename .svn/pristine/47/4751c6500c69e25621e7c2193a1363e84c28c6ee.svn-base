// ======================================================================== 
// 
// Module       : Connexion.cs - Source File
// Author       : Yannis Mahiou & Guillaume Cothenet
// Creation date: 03-04-2017 
// 
// ======================================================================== 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Description de la classe Connexion
    /// </summary>
    public class Connexion
    {
        public string UserName
        {
            get;
            set;
        }
        public string Password
        {
            get;
            private set;
        }
        public Connexion(string username, string passwd)
        {
            UserName = username;
            Password = passwd;
        }

        /// <summary>
        /// Permet à un User ou un Admin de se connecter
        /// </summary>
        /// <param name="registre"> Le registre qui contient tous les utilisateurs.</param>
        /// <returns> 1 si l'utilisateur est trouvé, 0 sinon </returns>
        public int SeConnecter(AllUser registre)
        {
            foreach (User u in registre.Lregistre)
            { 
                if (u.Pseudo == UserName && u.MotDePasse == Password)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}

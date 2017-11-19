// ======================================================================== 
// 
// Module       : AllUser.cs - Source File
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
    /// La classe AllUser regroupe à travers la liste Lregistre tous les User, ainsi que tous les Admin
    /// </summary>
    [DataContract(Name = "users")]
    public class AllUser
    {
        [DataMember(Name = "listeUser")]
        public List<User> Lregistre { get; set; }

        public AllUser()
        {
            Lregistre = new List<User>();
        }

        /// <summary>
        /// Recherche un User dans la liste Lregistre
        /// </summary>
        /// <param name="pseudo">Le pseudo à rechercher dans la liste</param>
        /// <returns>renvois l'utilisateur si trouvé, null sinon</returns>
        public User ResearchUser(string pseudo)
        {
            User user = Lregistre.SingleOrDefault(u => u.Pseudo.Equals(pseudo));
            return user;
        }

        /// <summary>
        /// Ajoute un User dans la liste Lregistre
        /// </summary>
        /// <remarks>
        /// J'ai changé les paramètres de la méthode, j'ai remplacé par "User user" @Yannis
        /// </remarks>
        /// <param name="user">L'utilisateur à ajouter à la liste</param>
        /// <returns> 1 si l'ajout est effectué, sinon lève une exception</returns>
        public int AddUser(User user)
        {
            foreach (User u in Lregistre)
            {
                if (u.Pseudo == user.Pseudo)
                {
                    throw new Exception("Pseudo déjà existant !");
                }
                if (u.Mail == user.Mail)
                {
                    throw new Exception("Mail déjà existant !");
                }
            }
            Lregistre.Add(user);
            return 1;
        }

        /// <summary>
        /// Ajoute un administrateur à LRegistre
        /// </summary>
        /// <param name="user">L'utilisateur à ajouter en tant qu'Admin </param>
        /// <param name="description">Description qui différencie un Admin d'un User</param>
        /// <returns> 1 si l'ajout est effectué, sinon lève une exception </returns>
        /// <seealso cref="Admin"/>
        public int AddAdmin(Admin admin)
        {
            User u = ResearchUser(admin.Pseudo);
            if (u == null)
            {
                Lregistre.Add(admin);
                return 1;
            }
            else
            {
                throw new Exception("Utilisateur déjà existant");
            }
        }

        /// <summary>
        /// Retire un Utilisateur de la liste Lregistre, à partir d'un pseudo donné
        /// </summary>
        /// <param name="pseudo"> Le pseudo de l'utilisateur à supprimer de la liste Lregistre</param>
        /// <returns> 1 si la suppression est effectuée, sinon 0 </returns>
        public int DeleteUser(string pseudo)
        {
            User u = ResearchUser(pseudo);
            if (u != null)
            {
                Lregistre.Remove(u);
                return 1;
            }
            else
            {
                throw new Exception("Impossible de supprimer : user inexistant");
            }


            /*
            foreach (User u in Lregistre)
            {
                if (ResearchUser(pseudo) == )
                {
                    Lregistre.Remove(u);
                    return 1;
                }
            }
            return 0;*/
        }
    }
}

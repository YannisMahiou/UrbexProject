using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using ClassLibrary;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;
using Data;

namespace Data
{
    /// <summary>
    /// Cette interface permet aux classe Stub et Xml de pouvoir disposer de la méthode saveData() qui serialize les Données du projet
    /// </summary>
    /// <seealso cref="Stub"/>
    /// <seealso cref="Xml"/>
    interface ISave
    {
        //Serialize Project
        void saveData(Spots dico, AllUser Registre, ObservableCollection<Topic> Sujet, Topic Histoire, Topic Regles, Topic ESP);

    }
}

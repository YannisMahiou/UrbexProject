// ======================================================================== 
// 
// Module       : ILoad.cs - Source File
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
using ClassLibrary;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;
using Data;

namespace Data
{
    /// <summary>
    /// Cette interface permet aux classe Stub et Xml de pouvoir disposer de la méthode loadData() qui deserialize(charge) les données du projet
    /// </summary>
    /// <seealso cref="Stub"/>
    /// <seealso cref="Xml"/>
    interface ILoad
    {
        //Deserialize Users
        AllUser loadUser();

        //Deserialize Spot
        Spots loadSpot();

        //Deserialize Topics
        ObservableCollection<Topic> loadTopic();

        //Deserialize Topic Histoire
        Topic LoadTopicHistoire();

        //Deserialization of Topics Regles
        Topic LoadTopicRegles();

        //Deserialization of Topics En Savoir Plus
        Topic LoadTopicESP();
    }
}

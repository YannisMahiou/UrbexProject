// ======================================================================== 
// 
// Module       : Topic.cs - Source File
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
    /// Serialize et deserialize les données utilisées dans des fichiers xml
    /// </summary>
    public class Xml : ISave, ILoad
    {
        public void saveData(Spots dico, AllUser Registre, ObservableCollection<Topic> Sujet, Topic Histoire, Topic Regles, Topic ESP)
        {
            
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };

            // Serialization of Spots
            string xmlFile1 = "Spots.xml";
            var serializerSpots = new DataContractSerializer(typeof(Spots));

            using (XmlWriter writer = XmlWriter.Create(xmlFile1, settings))
            {
                serializerSpots.WriteObject(writer, dico);
            }

            // Seralization of Users
            string xmlFile2 = "Users.xml";
            var serializerUser = new DataContractSerializer(typeof(AllUser));

            using (XmlWriter writer = XmlWriter.Create(xmlFile2, settings))
            {
                serializerUser.WriteObject(writer, Registre);
            }

            // Serealization of Topics
            string xmlFile3 = "Topic.xml";
            var serializeTopics = new DataContractSerializer(typeof(List<Topic>));

            using (XmlWriter writer = XmlWriter.Create(xmlFile3, settings))
            {
                serializeTopics.WriteObject(writer, Sujet);
            }

            // Seralization of Topic Histoire
            string xmlFiles4 = "TopicHistoire.xml";
            var serializeTopicHistoire = new DataContractSerializer(typeof(Topic));

            using (XmlWriter writer = XmlWriter.Create(xmlFiles4, settings))
            {
                serializeTopicHistoire.WriteObject(writer, Histoire);
            }

            // Seralization of Topic Regles
            string xmlFiles5 = "TopicRegles.xml";
            var serializeTopicRegles = new DataContractSerializer(typeof(Topic));

            using (XmlWriter writer = XmlWriter.Create(xmlFiles5, settings))
            {
                serializeTopicRegles.WriteObject(writer, Regles);
            }

            // Seralization of Topic En Savoir Plus
            string xmlFiles6 = "TopicESP.xml";
            var serializeTopicESP = new DataContractSerializer(typeof(Topic));

            using (XmlWriter writer = XmlWriter.Create(xmlFiles6, settings))
            {
                serializeTopicESP.WriteObject(writer, ESP);
            }
        }

        public AllUser loadUser()
        {
            
            //Deserialization of User
            var serializerUser = new DataContractSerializer(typeof(AllUser));
            AllUser deserializedData1;
            using (Stream stream = File.OpenRead("Users.xml"))
            { 
                deserializedData1 = serializerUser.ReadObject(stream) as AllUser;
            }
            return  deserializedData1;
        }

        public Spots loadSpot()
        {
 
            //Deserialization of Spots
            var serializerSpots = new DataContractSerializer(typeof(Spots));
            Spots deserializedData2;
            using (XmlReader reader = XmlReader.Create("Spots.xml"))
            {
                deserializedData2 = serializerSpots.ReadObject(reader) as Spots;
            }
            return deserializedData2;
        }
        
        public ObservableCollection<Topic> loadTopic()
        {         
            //Deserialization of Topics Accueil
            var serializer = new DataContractSerializer(typeof(ObservableCollection<Topic>));
            ObservableCollection<Topic> deserializedData3;
            using (Stream stream = File.OpenRead("Topic.xml"))
            {
                deserializedData3 = serializer.ReadObject(stream) as ObservableCollection<Topic>;
            }
            return deserializedData3;

        }
        public Topic LoadTopicHistoire()
        {
            //Deserialization of Topics Histoire
            var serializer = new DataContractSerializer(typeof(Topic));
            Topic deserializedData4;
            using (Stream stream = File.OpenRead("TopicHistoire.xml"))
            {
                deserializedData4 = serializer.ReadObject(stream) as Topic;
            }
            return deserializedData4;
        }
        public Topic LoadTopicRegles()
        {
            //Deserialization of Topics Regles
            var serializer = new DataContractSerializer(typeof(Topic));
            Topic deserializedData5;
            using (Stream stream = File.OpenRead("TopicRegles.xml"))
            {
                deserializedData5 = serializer.ReadObject(stream) as Topic;
            }
            return deserializedData5;
        }
        public Topic LoadTopicESP()
        {
            //Deserialization of Topics En Savoir Plus
            var serializer = new DataContractSerializer(typeof(Topic));
            Topic deserializedData6;
            using (Stream stream = File.OpenRead("TopicESP.xml"))
            {
                deserializedData6 = serializer.ReadObject(stream) as Topic;
            }
            return deserializedData6;
        }
    }
}

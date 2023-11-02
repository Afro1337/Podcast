using System.Xml.Serialization;
using Models;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using System;

namespace DAL
{
    internal class SerializerXML
    {
        public void SerializePodcast(List<Podcast> items)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream fileStreamOut = new FileStream("Podcast.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(fileStreamOut, items);
                }
            }
            catch (Exception)
            {
                throw new ExceptionSerializer("Podcast.xml", "could not deserialize");
            }

        }

        public List<Podcast> DeserializePodcast()
        {
            try
            {
                List<Podcast> returned;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream fileStreamIn = new FileStream("Podcast.xml", FileMode.Open, FileAccess.Read))
                {
                    returned = (List<Podcast>)xmlSerializer.Deserialize(fileStreamIn);
                }

                return returned;
            }
            catch (Exception)
            {
                throw new ExceptionSerializer("Podcast.xml", "could not deserialize");
            }
        }

        public void SerializeCategory(List<Category> items)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Category>));
                using (FileStream fileStreamOut = new FileStream("Category.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(fileStreamOut, items);
                }
            }
            catch (Exception)
            {
                throw new ExceptionSerializer("Category.xml", "could not deserialize");
            }

        }

        public List<Category> DeserializeCategory()
        {
            try
            {
                List<Category> returned;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Category>));
                using (FileStream fileStreamIn = new FileStream("Category.xml", FileMode.Open, FileAccess.Read))
                {
                    returned = (List<Category>)xmlSerializer.Deserialize(fileStreamIn);
                }

                return returned;
            }
            catch (Exception)
            {
                throw new ExceptionSerializer("Category.xml", "could not deserialize");
            }
        }
    }
}
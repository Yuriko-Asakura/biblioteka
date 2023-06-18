using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_LIB
{
    public class DataSerializer
    {
        public static void Serialize<T>(T data, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static T Deserialize<T>(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StreamReader reader = new StreamReader(fileName))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}

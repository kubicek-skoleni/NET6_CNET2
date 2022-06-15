using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data
{
    public class Serialization
    {
        public static List<Person> LoadFromXML(string file = @"dataset.xml")
        {
            return Serialization.DeSerialize<List<Person>>(file);
        }

        public static bool Serialize<T>(T input, string outputFile)
        {
            try
            {
                // Serialization
                XmlSerializer s = new XmlSerializer(typeof(T));
                using (TextWriter w = new StreamWriter(outputFile))
                {
                    s.Serialize(w, input);
                }

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public static T DeSerialize<T>(string inputFile)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            T newClass;
            using (TextReader r = new StreamReader(inputFile))
            {
                newClass = (T)s.Deserialize(r);
            }
            return newClass;
        }

        public static T DeSerializeString<T>(string inputContent)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            T newClass;
            using (TextReader r = new StringReader(inputContent))
            {
                newClass = (T)s.Deserialize(r);
            }

            return newClass;
        }
    }

}

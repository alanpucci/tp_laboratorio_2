using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Files
{
    public class FilesHandler<T>: IFiles<T> where T: List<Computer>
    {
        public bool SaveFile(T t, string fileName)
        {
            try
            {
                string file = AppDomain.CurrentDomain.BaseDirectory + fileName;
                using (XmlTextWriter fileWriter = new XmlTextWriter(file, Encoding.UTF8))
                {
                    XmlSerializer xmlWriter = new XmlSerializer(typeof(T));
                    xmlWriter.Serialize(fileWriter, t);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T ReadFile(string fileName)
        {
            try
            {
                string file = AppDomain.CurrentDomain.BaseDirectory + fileName;
                if (!File.Exists(file))
                {
                    throw new Exception("Ruta inválida.");
                }
                using (XmlTextReader fileReader = new XmlTextReader(file))
                {
                    XmlSerializer xmlReader = new XmlSerializer(typeof(T));
                    return (T)xmlReader.Deserialize(fileReader);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

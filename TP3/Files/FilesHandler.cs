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
    public class FilesHandler<T>: IFiles<T> 
    {
        public void SaveFile(T t, string fileName)
        {
            try
            {
                string file = AppDomain.CurrentDomain.BaseDirectory + fileName;
                using (XmlTextWriter fileWriter = new XmlTextWriter(file, Encoding.UTF8))
                {
                    XmlSerializer xmlWriter = new XmlSerializer(typeof(T));
                    xmlWriter.Serialize(fileWriter, t);
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
                    throw new FileNotFoundException("Ruta inválida.");
                }
                using (XmlTextReader fileReader = new XmlTextReader(file))
                {
                    XmlSerializer xmlReader = new XmlSerializer(typeof(T));
                    return (T)xmlReader.Deserialize(fileReader);
                }
            }
            catch(FileNotFoundException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}

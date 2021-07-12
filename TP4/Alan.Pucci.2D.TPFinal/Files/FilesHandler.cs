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
        /// <summary>
        /// Save a xml File, Implements interface and generics
        /// </summary>
        /// <param name="t">Object to save</param>
        /// <param name="fileName">File name</param>
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

        /// <summary>
        /// Read a xml file, Implements interface and generics
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <returns>The object read</returns>
        public T ReadFile(string file)
        {
            try
            {
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

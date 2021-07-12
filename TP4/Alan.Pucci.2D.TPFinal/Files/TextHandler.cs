using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    public class TextHandler: IFiles<string>
    {
        /// <summary>
        /// Read a text file, Implements interface and generics
        /// </summary>
        /// <param name="fileName">File name to read</param>
        /// <returns>The text read</returns>
        public string ReadFile(string fileName)
        {
            try
            {
                string file = AppDomain.CurrentDomain.BaseDirectory + fileName;
                if (!File.Exists(file))
                {
                    throw new FileNotFoundException("Ruta inválida.");
                }
                string output = "";
                using (StreamReader fileReader = new StreamReader(file))
                {
                    string readLine = string.Empty;
                    while ((readLine = fileReader.ReadLine()) != null)
                    {
                        output += readLine+"\n";
                    }
                }
                return output;
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Save a text file, Implements interface and generics
        /// </summary>
        /// <param name="text">Text to save</param>
        /// <param name="fileName">File name</param>
        public void SaveFile(string text, string fileName)
        {
            try
            {
                string file = AppDomain.CurrentDomain.BaseDirectory + fileName;
                using (StreamWriter fileWriter = new StreamWriter(file, true))
                {
                    fileWriter.WriteLine(text);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 

    }
}

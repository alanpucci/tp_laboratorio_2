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

        public void SaveFile(string text, string fileName)
        {
        } 

    }
}

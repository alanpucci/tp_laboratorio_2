using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Entities;

namespace Application.Procedure
{
    public static class Procedure<T> where T : Computer
    {
        private const string USERNAME = "recepcionista";
        private const int MAXSTOCKWAITING = 10;
        private static List<User> users;
        private static List<Computer> computers;

        static Procedure()
        {
            users = new List<User>();
            computers = new List<Computer>();
        }

        public static User SignIn(string username, string password)
        {
            try
            {
                if(String.IsNullOrEmpty(username.Trim()) || String.IsNullOrEmpty(password.Trim()))
                {
                    throw new Exception("Por favor, llene todos los campos");
                }
                if (username == USERNAME && password == "12345")
                {
                    return new Recepcionist(username, password);
                }
                else
                {
                    if (username == "tecnico" && password == "12345")
                    {
                    return new Technical(username, password);
                    }
                    else
                    {
                        throw new Exception("Usuario invalido");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static bool CanAddComputer
        {
            get
            {
                return computers.Count < MAXSTOCKWAITING;
            }
        }

        public static List<Computer> Computers
        {
            get
            {
                return computers;
            }
        }

        public static bool AddComputer(T t)
        {
            try
            {
                if (CanAddComputer)
                {
                    foreach (T item in computers)
                    {
                        if(item == t)
                        {
                            throw new Exception("Esa computadora ya esta cargada");
                        }
                    }
                    computers.Add(t);
                    return true;
                }
                throw new Exception("No hay mas espacio");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Agregar Interfaz para que sea mas generica
        public static List<Computer> UpdateComputer<T,U>(T t, U u) where T: Computer where U: Computer
        {
            for (int i = 0; i < computers.Count; i++)
            {
                if (computers[i] == t)
                {
                    computers[i] = u;
                    return computers;
                }
            }
            return computers;
        }

        public static bool DeleteComputer<T>(T t) where T: Computer
        {
            for (int i = 0; i < computers.Count; i++)
            {
                if (computers[i] == t)
                {
                    computers.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public static void SaveFile<T>(T t, string fileName) where T: List<Computer>
        {
            try
            {
                string filePath = AppDomain.CurrentDomain.BaseDirectory + fileName;
                using (XmlTextWriter file = new XmlTextWriter(filePath, Encoding.UTF8))
                {
                    XmlSerializer fileWriter = new XmlSerializer(typeof(T));
                    fileWriter.Serialize(file, t);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

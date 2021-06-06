using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Entities;
using Files;

namespace Procedure
{
    public static class CoreProcedure<T> where T: List<Computer>
    {
        private const int MAXSTOCKWAITING = 10;
        private static List<User> users;
        private static T computers;

        static CoreProcedure()
        {
            users = new List<User>();
            computers = LoadComputers();
        }

        private static bool CanAddComputer
        {
            get
            {
                return computers.Count < MAXSTOCKWAITING;
            }
        }

        public static T Computers
        {
            get
            {
                return computers;
            }
        }

        public static T ReceivedComputers
        {
            get
            {
                return GetComputersByState(State.Recibida);
            }
        }

        public static T ToRepairComputers
        {
            get
            {
                return GetComputersByState(State.PorReparar);
            }
        }

        public static T RepairedComputers
        {
            get
            {
                return GetComputersByState(State.Reparada);
            }
        }

        public static T ToDeliverComputers
        {
            get
            {
                return GetComputersByState(State.PorEntregar);
            }
        }

        public static T DeliveredComputers
        {
            get
            {
                return GetComputersByState(State.Devuelta);
            }
        }

        public static bool AddComputer<U>(U u) where U: Computer
        {
            try
            {
                if (CanAddComputer)
                {
                    foreach (U item in computers)
                    {
                        if(item == u)
                        {
                            throw new Exception("Esa computadora ya esta cargada");
                        }
                    }
                    computers.Add(u);
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
        public static T UpdateComputer<U>(U t, U u) where U: Computer
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

        public static T UpdateState<U>(U t, State state) where U : Computer
        {
            try
            {
                for (int i = 0; i < computers.Count; i++)
                {
                    if (computers[i] == t)
                    {
                        computers[i].ComputerState = state;
                        return computers;
                    }
                }
                return computers;
            }
            catch (Exception)
            {
                throw new Exception("Error al manipular la computadora"); 
            }
        }

        public static bool DeleteComputer<U>(U u) where U: Computer
        {
            for (int i = 0; i < computers.Count; i++)
            {
                if (computers[i] == u)
                {
                    computers.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        private static T LoadComputers()
        {
            try
            {
                FilesHandler<T> filesHandler = new FilesHandler<T>();
                return filesHandler.ReadFile("Computers.xml");
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        private static T GetComputersByState(State state)
        { 
            List<Computer> computersList = new List<Computer>();
            foreach (Computer item in computers)
            {
                if(item.ComputerState == state)
                {
                    computersList.Add(item);
                }
            }
            return (T)computersList;
        }
    }
}

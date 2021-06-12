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
        private static T computers;

        static CoreProcedure()
        {
            computers = LoadComputers();
        }

        private static bool CanAddComputer
        {
            get
            {
                return ReceivedComputers.Count < MAXSTOCKWAITING;
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
                throw new Exception("No hay espacio para cargar la computadora.\nPor favor, asigna las computadoras al técnico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool UpdateComputer<U>(U t, U u) where U: Computer
        {
            for (int i = 0; i < computers.Count; i++)
            {
                if (computers[i] == t)
                {
                    u.Date = t.Date;
                    computers[i] = u;
                    return true;
                }
            }
            return false;
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
            try
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
            catch (Exception ex)
            {
                throw ex;
            }
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
                return (T)new List<Computer>();
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

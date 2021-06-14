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
using Exceptions;

namespace Procedure
{
    public sealed class CoreProcedure : IProcedure<Computer, State>
    {
        private const int MAXSTOCKWAITING = 10;
        private static List<Computer> computers;
        private static CoreProcedure instance = null;

        /// <summary>
        /// Default constructor
        /// </summary>
        private CoreProcedure()
        {
        }

        /// <summary>
        /// Instance the singleton
        /// </summary>
        public static CoreProcedure Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CoreProcedure();
                }
                return instance;
            }
        }

        /// <summary>
        /// Load list of computers
        /// </summary>
        static CoreProcedure()
        {
            computers = LoadComputers();
        }

        /// <summary>
        /// Ask if there is room to add another computer
        /// </summary>
        private static bool CanAddComputer
        {
            get
            {
                return ReceivedComputers.Count < MAXSTOCKWAITING;
            }
        }

        /// <summary>
        /// Return the list of computers
        /// </summary>
        public static List<Computer> Computers
        {
            get
            {
                return computers;
            }
            set
            {
                computers = value;
            }
        }

        /// <summary>
        /// Return the list of "received" computers
        /// </summary>
        public static List<Computer> ReceivedComputers
        {
            get
            {
                return GetComputersByState(State.Recibida);
            }
        }

        /// <summary>
        /// Indexer of computers by state
        /// </summary>
        /// <param name="state">State to index</param>
        /// <returns>List of computers</returns>
        public List<Computer> this[State state]
        {
            get
            {
                return GetComputersByState(state);
            }
        }

        /// <summary>
        /// Add a computer to the list
        /// </summary>
        /// <param name="u">Computer to add</param>
        /// <returns>True if the computer is added, false if not</returns>
        public static bool AddComputer(Computer u)
        {
            try
            {
                if (CanAddComputer)
                {
                    if(computers + u)
                    {
                        TextHandler textHandler = new TextHandler();
                        textHandler.SaveFile(u.Show(), "list_computers.txt");
                        FilesHandler<List<Computer>> fileHandler = new FilesHandler<List<Computer>>();
                        fileHandler.SaveFile(computers, "Computers.xml");
                        return true;
                    }
                }
                throw new ComputerException("No hay espacio para cargar la computadora.\nPor favor, asigna las computadoras al técnico");
            }
            catch (ComputerException ex)
            {
                throw ex;
            }
            catch (AlreadyInListException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update a computer by another one
        /// </summary>
        /// <param name="t">Computer to be replaced</param>
        /// <param name="u">Computer to replace</param>
        /// <returns>True if the computer is updated, false if not</returns>
        public static bool UpdateComputer(Computer t, Computer u)
        {
            try
            {
                for (int i = 0; i < computers.Count; i++)
                {
                    if (computers[i] == t)
                    {
                        u.Date = t.Date;
                        computers[i] = u;
                        TextHandler textHandler = new TextHandler();
                        textHandler.SaveFile(u.Show(),"list_computers.txt");
                        FilesHandler<List<Computer>> fileHandler = new FilesHandler<List<Computer>>();
                        fileHandler.SaveFile(computers, "Computers.xml");
                        return true;
                    }
                }
                throw new ComputerException("Ha ocurrido un error al manipular la computadora");
            }
            catch (ComputerException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Update a computer by state
        /// </summary>
        /// <param name="t">Computer to be updated</param>
        /// <param name="state">State to put</param>
        /// <returns>True if the computer is updated, false if not</returns>
        public void UpdateState(Computer t, State state)
        {
            try
            {
                for (int i = 0; i < computers.Count; i++)
                {
                    if (computers[i] == t)
                    {
                        computers[i].ComputerState = state;
                        TextHandler textHandler = new TextHandler();
                        textHandler.SaveFile(t.Show(), "list_computers.txt");
                        FilesHandler<List<Computer>> fileHandler = new FilesHandler<List<Computer>>();
                        fileHandler.SaveFile(computers, "Computers.xml");
                    }
                }
            }
            catch(ComputerException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw new ComputerException("Error al manipular la computadora"); 
            }
        }

        /// <summary>
        /// Delete a computer
        /// </summary>
        /// <param name="u">Computer to delete</param>
        /// <returns>True if the computer is deleted, false if not</returns>
        public static void DeleteComputer(Computer u)
        {
            try
            {
                if (computers - u)
                {
                    string aux = "///////////////////////////////////\nComputadora eliminada: \n" + u.Show();
                    FilesHandler <List<Computer>> fileHandler = new FilesHandler<List<Computer>>();
                    fileHandler.SaveFile(computers, "Computers.xml");
                    TextHandler textHandler = new TextHandler();
                    textHandler.SaveFile(aux, "list_computers.txt");
                }
            }
            catch (ComputerException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Loads the list of computers from a file. If file doesn't exists, a new list is instantiated
        /// </summary>
        /// <returns></returns>
        private static List<Computer> LoadComputers()
        {
            try
            {
                FilesHandler<List<Computer>> filesHandler = new FilesHandler<List<Computer>>();
                return filesHandler.ReadFile("Computers.xml");
            }
            catch (FileNotFoundException)
            {
                return new List<Computer>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Filter the list of computers by state
        /// </summary>
        /// <param name="state">State to filter</param>
        /// <returns>List of computers</returns>
        private static List<Computer> GetComputersByState(State state)
        {
            try
            {
                List<Computer> computersList = new List<Computer>();
                foreach (Computer item in computers)
                {
                    if(item.ComputerState == state)
                    {
                        computersList.Add(item);
                    }
                }
                return computersList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

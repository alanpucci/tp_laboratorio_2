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
using SQL;
using System.Threading;

namespace Procedure
{
    public delegate void ProcedureDelegate(Computer computer);
    public delegate void RepairDelegate(char text);
    public sealed class CoreProcedure : IProcedure<Computer, State>
    {
        private const int MAXSTOCKWAITING = 10;
        private static List<Computer> computers;
        private static CoreProcedure instance = null;
        public static event ProcedureDelegate AddComputerEvent;
        public static event ProcedureDelegate DeleteComputerEvent;
        public static event ProcedureDelegate UpdateComputerEvent;
        public static event RepairDelegate RepairComputerEvent;

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
            LoadComputers();
            HandleEvents();
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
        /// Subscribe methods to their respective events
        /// </summary>
        public static void HandleEvents()
        {
            AddComputerEvent += SaveDB;
            AddComputerEvent += SaveTxt;
            AddComputerEvent += SaveXML;
            DeleteComputerEvent += SaveDeleteComputerTxt;
            DeleteComputerEvent += SaveXML;
            DeleteComputerEvent += DeleteDB;
            UpdateComputerEvent += SaveTxt;
            UpdateComputerEvent += SaveXML;
            UpdateComputerEvent += UpdateDB;

        }

        /// <summary>
        /// Add a computer to the list
        /// </summary>
        /// <param name="u">Computer to add</param>
        /// <returns>True if the computer is added, false if not</returns>
        public static bool AddComputer(Computer computer)
        {
            try
            {
                if (CanAddComputer)
                {
                    if(computers + computer)
                    {
                        AddComputerEvent.Invoke(computer);
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
                u.ID = t.ID;
                UpdateComputerEvent.Invoke(u);
                LoadComputers();
                return true;
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
        /// Shows "¡No te olvides de cambiar la descripción!" in a time lapse
        /// </summary>
        public static void Loading()
        {
            string loading = "¡No te olvides de cambiar la descripción!";
            for (int i = 0; i < loading.Length; i++)
            {
                CoreProcedure.RepairComputerEvent.Invoke(loading[i]);
                Thread.Sleep(100);
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
                t.ComputerState = state;
                UpdateComputer(t, t);
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
                    DeleteComputerEvent.Invoke(u);
                    LoadComputers();
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
        /// Loads the list of computers from a database. If it throws an exception, a new list is created
        /// </summary>
        /// <returns></returns>
        public static void LoadComputers()
        {
            try
            {
                computers = null;
                computers = SqlHandler.GetComputers();
            }
            catch (Exception)
            {
                computers = new List<Computer>();
            }
        }

        /// <summary>
        /// Loads the list of computers from a file.
        /// </summary>
        /// <returns></returns>
        public static void LoadComputersFromFile(string file)
        {
            try
            {
                if (!String.IsNullOrEmpty(file) && File.Exists(file))
                {
                    FilesHandler<List<Computer>> filesHandler = new FilesHandler<List<Computer>>();
                    computers = filesHandler.ReadFile(file);
                }
            }
            catch (FileNotFoundException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
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

        /// <summary>
        /// Saves the computer movement into the log
        /// </summary>
        /// <param name="computer"></param>
        private static void SaveTxt(object computer)
        {
            try
            {
                TextHandler textHandler = new TextHandler();
                textHandler.SaveFile(((Computer)computer).Show(), "list_computers.txt");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves deleted computer into the log
        /// </summary>
        /// <param name="computer"></param>
        private static void SaveDeleteComputerTxt(object computer)
        {
            try
            {
                TextHandler textHandler = new TextHandler();
                string aux = "///////////////////////////////////\nComputadora eliminada: \n" + ((Computer)computer).Show();
                textHandler.SaveFile(aux, "list_computers.txt");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves computers list in a XML
        /// </summary>
        /// <param name="computer"></param>
        public static void SaveXML(object computer)
        {
            try
            {
                FilesHandler<List<Computer>> fileHandler = new FilesHandler<List<Computer>>();
                fileHandler.SaveFile(computers, "Computers.xml");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves computers list in the DB
        /// </summary>
        /// <param name="computer"></param>
        private static void SaveDB(object computer)
        {
            try
            {
                SqlHandler.CreateComputer((Computer)computer);
                LoadComputers();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes computer from the DB
        /// </summary>
        /// <param name="computer"></param>
        private static void DeleteDB(object computer)
        {
            try
            {
                SqlHandler.DeleteComputer(((Computer)computer).ID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Updates computer from the DB
        /// </summary>
        /// <param name="computer"></param>
        private static void UpdateDB(object computer)
        {
            try
            {
                SqlHandler.UpdateComputer((Computer)computer);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

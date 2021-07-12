using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entities
{
    [Serializable]
    [XmlInclude(typeof(Notebook))]
    [XmlInclude(typeof(Desktop))]
    public abstract class Computer: IComputer
    {
        private OS operativeSystem;
        private ComType type;
        private Processor processor;
        private RAM ram;
        private HardDisk hardDisk;
        private GraphicCard graphicCard;
        private string desc;
        private DateTime date;
        private string clientName;
        private State state;
        private int id;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Computer()
        {

        }

        /// <summary>
        /// Constructor, initialize all attributes
        /// </summary>
        /// <param name="clientName">ClientName to initialize</param>
        /// <param name="os">Operative system to initialize</param>
        /// <param name="type">Computer type to initialize</param>
        /// <param name="processor">Processor to initialize</param>
        /// <param name="hardDisk">Hard disk to initialize</param>
        /// <param name="ram">RAM to initialize</param>
        /// <param name="desc">Description to initialize</param>
        /// <param name="graphicCard">Graphic card to initialize</param>
        public Computer(string clientName, OS os, ComType type, Processor processor, HardDisk hardDisk, RAM ram, string desc, GraphicCard graphicCard)
        {
            this.clientName = clientName;
            this.operativeSystem = os;
            this.type = type;
            this.processor = processor;
            this.hardDisk = hardDisk;
            this.ram = ram;
            this.desc = desc;
            this.date = DateTime.Now;
            this.state = State.Recibida;
            this.graphicCard = graphicCard;
        }

        public Computer(int id, string clientName, OS os, ComType type, Processor processor, HardDisk hardDisk, RAM ram, string desc, GraphicCard graphicCard, State state, DateTime date):this(clientName, os, type, processor, hardDisk, ram, desc, graphicCard)
        {
            this.id = id;
            this.state = state;
            this.date = date;
        }

        /// <summary>
        /// Get and set computer ID
        /// </summary>
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// Get and set client name
        /// </summary>
        public string ClientName
        {
            get
            {
                return this.clientName;
            }
            set
            {
                this.clientName = value;
            }
        }

        /// <summary>
        /// Get and set creation date
        /// </summary>
        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        /// <summary>
        /// Get and set operative system
        /// </summary>
        public OS OperativeSystem
        {
            get
            {
                return this.operativeSystem;
            }
            set
            {
                this.operativeSystem = value;
            }
        }

        /// <summary>
        /// get and set computer type
        /// </summary>
        public ComType ComputerType
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        /// <summary>
        /// Get and set processor
        /// </summary>
        public Processor ComputerProcessor
        {
            get
            {
                return this.processor;
            }
            set
            {
                this.processor= value;
            }
        }

        /// <summary>
        /// Get and set RAM
        /// </summary>
        public RAM ComputerRAM
        {
            get
            {
                return this.ram;
            }
            set
            {
                this.ram = value;
            }
        }

        /// <summary>
        /// Get and set Hard disk
        /// </summary>
        public HardDisk ComputerHardDisk
        {
            get
            {
                return this.hardDisk;
            }
            set
            {
                this.hardDisk = value;
            }
        }

        /// <summary>
        /// Get and set description
        /// </summary>
        public string Desc
        {
            get
            {
                return this.desc;
            }
            set
            {
                this.desc = value;
            }
        }

        /// <summary>
        /// Get and set computer state
        /// </summary>
        public State ComputerState
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        /// <summary>
        /// Get and set graphic card
        /// </summary>
        public GraphicCard ComputerGraphicCard
        {
            get
            {
                return this.graphicCard;
            }
            set
            {
                this.graphicCard = value;
            }
        }

        /// <summary>
        /// Compare two computers by all their attributes
        /// </summary>
        /// <param name="c1">First computer</param>
        /// <param name="c2">Second computer</param>
        /// <returns></returns>
        public static bool operator ==(Computer c1, Computer c2)
        {
            try
            {
                if(!(c1 is null) && !(c2 is null))
                {
                    return (c1.ClientName == c2.ClientName && c1.OperativeSystem == c2.OperativeSystem &&
                            c1.ComputerType == c2.ComputerType && c1.ComputerProcessor == c2.ComputerProcessor && c1.ComputerRAM == c2.ComputerRAM &&
                            c1.ComputerGraphicCard == c2.ComputerGraphicCard && c1.ComputerHardDisk == c2.ComputerHardDisk);
                }
                throw new ComputerException("Ha ocurrido un error al manipular la computadora");
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
        /// Distinct two computers
        /// </summary>
        /// <param name="c1">First computer</param>
        /// <param name="c2">Second computer</param>
        /// <returns></returns>
        public static bool operator !=(Computer c1, Computer c2)
        {
            try
            {
                 return !(c1 == c2);
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
        /// Add computer to computers list if it's not loaded already
        /// </summary>
        /// <param name="list">List of computer</param>
        /// <param name="c">Computer to add</param>
        /// <returns>True if it's added, false if not</returns>
        public static bool operator +(List<Computer> list, Computer c)
        {
            try
            {
                if(list != c)
                {
                    list.Add(c);
                    return true;
                }
                return false;
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
        /// Check if there is a computer in the list of computers, Implements AlreadyInListException
        /// </summary>
        /// <param name="list">List of computers</param>
        /// <param name="c">Computer to check</param>
        /// <returns>True if there is, false if not</returns>
        public static bool operator ==(List<Computer> list, Computer c)
        {
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == c)
                    {
                        throw new AlreadyInListException("Ya se encuentra cargada en el sistema");
                    }
                }
                return false;
            }
            catch(AlreadyInListException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Check if there's not a computer in the list of compuiters
        /// </summary>
        /// <param name="list">List of computers</param>
        /// <param name="c">Computer to check</param>
        /// <returns>True if there isn't, false if there is</returns>
        public static bool operator !=(List<Computer> list, Computer c)
        {
            try
            {
                return !(list == c);
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
        /// Delete a computer from a list of computers
        /// </summary>
        /// <param name="list">List of computer</param>
        /// <param name="c">Computer to delete</param>
        /// <returns>True if it's deleted, false if not</returns>
        public static bool operator -(List<Computer> list, Computer c)
        {
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == c)
                    {
                        list.RemoveAt(i);
                        return true;
                    }
                }
                throw new ComputerException("No se pudo eliminar la computadora");
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
        /// Returns all attributes of a computer
        /// </summary>
        public virtual string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cliente: {this.ClientName}");
            sb.AppendLine($"Sistema operativo: {this.OperativeSystem}");
            sb.AppendLine($"Fecha de creación: {this.Date}");
            sb.AppendLine($"Procesador: {this.ComputerProcessor}");
            sb.AppendLine($"Disco duro: {this.ComputerHardDisk}");
            sb.AppendLine($"RAM: {this.ComputerRAM}");
            sb.Append($"Placa de video: {this.ComputerGraphicCard}");
            return sb.ToString();
        }
    }
}

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
    public abstract class Computer
    {
        private OS operativeSystem;
        private ComType type;
        private Processor processor;
        //private List<RAM> ram;
        private RAM ram;
        private HardDisk hardDisk;
        private GraphicCard graphicCard;
        private string desc;
        //private DateTime date;
        private string clientName;
        private State state;

        public Computer()
        {

        }

        public Computer(string clientName, OS os, ComType type, Processor processor, HardDisk hardDisk, RAM ram, string desc)
        {
            this.clientName = clientName;
            this.operativeSystem = os;
            this.type = type;
            this.processor = processor;
            this.hardDisk = hardDisk;
            this.ram = ram;
            this.desc = desc;
            //this.date = DateTime.Now;
            this.state = State.Recibida;
        }

        public Computer(string clientName, OS os, ComType type, Processor processor, HardDisk hardDisk, RAM ram, string desc, GraphicCard graphicCard)
            : this(clientName, os, type, processor, hardDisk, ram, desc)
        {
            this.graphicCard = graphicCard;
        }

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

        public static bool operator ==(Computer c1, Computer c2)
        {
            return (c1.clientName == c2.clientName && c1.operativeSystem == c2.operativeSystem &&
                    c1.type == c2.type && c1.processor == c2.processor);
            //return c1 == c2;
        }

        public static bool operator !=(Computer c1, Computer c2)
        {
            return !(c1 == c2);
        }
    }
}

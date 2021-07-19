using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Desktop:Computer, IComputer, IDesktop
    {
        private Cooler cooler;
        private bool dvdBurner;
        private bool extraAccesory;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Desktop()
        {

        }

        /// <summary>
        /// Constructor, initialize all attributes except id, state and date
        /// </summary>
        /// <param name="clientName">ClientName to initialize</param>
        /// <param name="cooler">Coolr to initialize</param>
        /// <param name="dvdBurner">DvdBurner to initialize</param>
        /// <param name="extraAccesory">Extracessory to initialize</param>
        /// <param name="os">Operative system to initialize</param>
        /// <param name="type">Computer type to initialize</param>
        /// <param name="processor">Processor to initialize</param>
        /// <param name="hardDisk">Hard disk to initialize</param>
        /// <param name="ram">RAM to initialize</param>
        /// <param name="desc">Description to initialize</param>
        /// <param name="graphicCard">Graphic card to initialize</param>
        public Desktop(string clientName, Cooler cooler, bool dvdBurner, bool extraAccesory,OS os, ComType type, Processor processor, HardDisk hardDisk, RAM ram, string desc, GraphicCard graphicCard)
            : base(clientName,os, type, processor, hardDisk, ram, desc, graphicCard)
        {
            this.cooler = cooler;
            this.dvdBurner = dvdBurner;
            this.extraAccesory = extraAccesory;
        }

        /// <summary>
        /// Constructor, initialize all attributes
        /// </summary>
        /// <param name="id">Id to initialize</param>
        /// <param name="clientName">ClientName to initialize</param>
        /// <param name="cooler">Coolr to initialize</param>
        /// <param name="dvdBurner">DvdBurner to initialize</param>
        /// <param name="extraAccesory">Extracessory to initialize</param>
        /// <param name="os">Operative system to initialize</param>
        /// <param name="type">Computer type to initialize</param>
        /// <param name="processor">Processor to initialize</param>
        /// <param name="hardDisk">Hard disk to initialize</param>
        /// <param name="ram">RAM to initialize</param>
        /// <param name="desc">Description to initialize</param>
        /// <param name="graphicCard">Graphic card to initialize</param>
        /// <param name="state">State to initialize</param>
        /// <param name="date">Date to initialize</param>
        public Desktop(int id, string clientName, Cooler cooler, bool dvdBurner, bool extraAccesory, OS os, ComType type, Processor processor, HardDisk hardDisk, RAM ram, string desc, GraphicCard graphicCard,State state,DateTime date)
            : base(id,clientName,os,type,processor,hardDisk,ram,desc,graphicCard,state,date)
        {
            this.cooler = cooler;
            this.dvdBurner = dvdBurner;
            this.extraAccesory = extraAccesory;
        }

        /// <summary>
        /// Get and set cooler
        /// </summary>
        public Cooler Cooler
        {
            get
            {
                return this.cooler;
            }
            set
            {
                this.cooler = value;
            }
        }

        /// <summary>
        /// Get and set dvd burner
        /// </summary>
        public bool DvdBurner
        {
            get
            {
                return this.dvdBurner;
            }
            set
            {
                this.dvdBurner = value;
            }
        }

        /// <summary>
        /// Get and set extra accesory
        /// </summary>
        public bool ExtraAccesory
        {
            get
            {
                return this.extraAccesory;
            }
            set
            {
                this.extraAccesory = value;
            }
        }

        /// <summary>
        /// Returns all attributes of a computer, implements EXTENSION METHODS
        /// </summary>
        public override string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Show());
            sb.AppendLine($"Cooler: {this.cooler}");
            sb.AppendFormat("¿Tiene grabadora de DVD? {0}\n", this.dvdBurner ? "Si" : "No");
            sb.AppendFormat("¿Tiene accesorio extra? {0}\n", this.extraAccesory ? "Si" : "No");
            sb.AppendLine($"Descripcion: {base.Desc}");
            sb.AppendLine($"Estado: {base.ComputerState.SplitState()}");
            sb.AppendLine("-----------------------------");
            return sb.ToString();
        }
    }
}

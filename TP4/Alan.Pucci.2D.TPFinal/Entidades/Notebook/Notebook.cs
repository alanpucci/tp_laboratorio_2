using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Notebook: Computer, IComputer, INotebook
    {
        private Brand brand;
        private bool touchScreen;
        private bool charger;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Notebook()
        {

        }

        /// <summary>
        /// Constructor, initialize all attributes
        /// </summary>
        /// <param name="clientName">ClientName to initialize</param>
        /// <param name="brand">Brand to initialize</param>
        /// <param name="touchScreen">Touch screen to initialize</param>
        /// <param name="charger">Charger to initialize</param>
        /// <param name="os">Operative system to initialize</param>
        /// <param name="type">Computer type to initialize</param>
        /// <param name="processor">Processor to initialize</param>
        /// <param name="hardDisk">Hard disk to initialize</param>
        /// <param name="ram">RAM to initialize</param>
        /// <param name="desc">Description to initialize</param>
        /// <param name="graphicCard">Graphic card to initialize</param>
        public Notebook(string clientName, Brand brand,bool charger, bool touchScreen, OS os, ComType type, Processor processor, HardDisk hardDisk, RAM ram, string desc, GraphicCard graphicCard)
            :base(clientName, os,type,processor,hardDisk,ram,desc, graphicCard)
        {
            this.brand = brand;
            this.touchScreen = touchScreen;
            this.charger = charger;
        }

        public Notebook(int id, string clientName, Brand brand, bool charger, bool touchScreen, OS os, ComType type, Processor processor, HardDisk hardDisk, RAM ram, string desc, GraphicCard graphicCard,State state, DateTime date)
            : base(id,clientName,os,type,processor,hardDisk,ram,desc,graphicCard,state,date)
        {
            this.brand = brand;
            this.touchScreen = touchScreen;
            this.charger = charger;
        }

        /// <summary>
        /// Get and set brand
        /// </summary>
        public Brand Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                this.brand = value;
            }
        }

        /// <summary>
        /// Get and set charger
        /// </summary>
        public bool Charger
        {
            get
            {
                return this.charger;
            }
            set
            {
                this.charger = value;
            }
        }

        /// <summary>
        /// Get and set touch screen
        /// </summary>
        public bool TouchScreen
        {
            get
            {
                return this.touchScreen;
            }
            set
            {
                this.touchScreen = value;
            }
        }

        /// <summary>
        /// Returns all attributes of a computer
        /// </summary>
        public override string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Show());
            sb.AppendLine($"Marca: {this.brand}");
            sb.AppendFormat("¿Trae cargador? {0}\n", this.charger ? "Si" : "No");
            sb.AppendFormat("¿Tiene pantalla táctil? {0}\n", this.touchScreen ? "Si" : "No");
            sb.AppendLine($"Descripcion: {base.Desc}");
            sb.AppendLine($"Estado: {base.ComputerState.SplitState()}");
            sb.AppendLine("-----------------------------");
            return sb.ToString();
        }
    }
}

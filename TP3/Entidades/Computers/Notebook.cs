using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Notebook: Computer
    {
        private string brand;
        //private bool touchScreen;
        //private bool charger;
        //private int screenSize;

        public Notebook()
        {

        }

        public Notebook(string clientName, Brand brand, OS os, ComType type, Processor processor, HardDisk hardDisk, RAM ram, string desc)
            :base(clientName, os,type,processor,hardDisk,ram,desc)
        {

        }
        public Notebook(string clientName, OS os, ComType type, Processor processor, HardDisk hardDisk, RAM ram, string desc, GraphicCard graphicCard)
             : base(clientName,os, type, processor, hardDisk, ram, desc, graphicCard)
        {

        }

        public string Brand
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
    }
}

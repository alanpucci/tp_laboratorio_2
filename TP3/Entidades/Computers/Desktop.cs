using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Desktop:Computer
    {
        public Desktop()
        {

        }
        public Desktop(string clientName, OS os, ComType type, Processor processor, HardDisk hardDisk, RAM ram, string desc)
            : base(clientName, os, type, processor, hardDisk, ram, desc)
        {

        }

        public Desktop(string clientName, OS os, ComType type, Processor processor, HardDisk hardDisk, RAM ram, string desc, GraphicCard graphicCard)
            : base(clientName,os, type, processor, hardDisk, ram, desc, graphicCard)
        {

        }
    }
}

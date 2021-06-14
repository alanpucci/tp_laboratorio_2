using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IComputer
    {
        string ClientName { get; set; }
        DateTime Date { get; set; }
        OS OperativeSystem { get; set; }
        ComType ComputerType { get; set; }
        Processor ComputerProcessor { get; set; }
        RAM ComputerRAM { get; set; }
        HardDisk ComputerHardDisk{ get; set; }
        string Desc { get; set; }
        State ComputerState { get; set; }
        GraphicCard ComputerGraphicCard { get; set; }
        string Show();
    }
}

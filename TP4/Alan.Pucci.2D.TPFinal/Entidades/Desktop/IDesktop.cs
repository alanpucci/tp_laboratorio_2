using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IDesktop:IComputer
    {
        Cooler Cooler { get; set; }
        bool DvdBurner { get; set; }
        bool ExtraAccesory{ get; set; }
    }
}

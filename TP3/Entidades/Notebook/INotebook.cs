using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface INotebook: IComputer
    {
        Brand Brand { get; set; }
        bool Charger { get; set; }
        bool TouchScreen { get; set; }
    }
}

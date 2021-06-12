using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Entities.Users.Recepcionist
{
    public interface IRecepcionist<T> where T:Computer
    {
        bool AddComputer(T computer);
        void ToRepair(T computer);
    }
}

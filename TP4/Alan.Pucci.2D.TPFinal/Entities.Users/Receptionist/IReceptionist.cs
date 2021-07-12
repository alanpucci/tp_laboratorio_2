using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Entities.Users.Receptionist
{
    public interface IReceptionist<T> where T:Computer
    {
        bool AddComputer(T computer);
        void ToRepair(T computer);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Users.Technical
{
    public interface ITechnician<T> where T:Computer
    {
        void Repair(T t1, T t2);
        void Deliver(T t);
    }
}

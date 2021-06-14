using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Users
{
    public interface IUser<T> 
    {
        bool UpdateComputer(T t1, T t2);
        void UpdateState(T t, State state);
        string Name { get; set; }
        string LastName { get; set; }
        string Username { get; set; }
        string Password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace SignIn
{
    public interface ISignIn
    {
        User SignIn(string username, string password);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Technical:User
    {
        public Technical(string username, string password):base(username, password)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        protected string name;
        protected string lastName;
        protected string username;
        protected string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Entities.Users;
using Procedure;

namespace Entities
{
    [Serializable]
    [XmlInclude(typeof(Technician))]
    [XmlInclude(typeof(Recepcionist))]
    public abstract class User: IUser<Computer>
    {
        protected string name;
        protected string lastName;
        protected string username;
        protected string password;

        /// <summary>
        /// Default constructor
        /// </summary>
        public User()
        {

        }

        /// <summary>
        /// Constructor, initialize all attributes
        /// </summary>
        /// <param name="name">Name to initialize</param>
        /// <param name="lastName">Last name to initialize</param>
        /// <param name="username">Username to initialize</param>
        /// <param name="password">Password to initialize</param>
        public User(string name, string lastName, string username, string password)
        {
            this.name = name;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
        }

        /// <summary>
        /// Get and set name
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Get and set last name
        /// </summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        /// <summary>
        /// Get and set username
        /// </summary>
        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
            }
        }

        /// <summary>
        /// Get and set password
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        /// <summary>
        /// Update a computer
        /// </summary>
        /// <param name="c1">First computer</param>
        /// <param name="c2">Second computer</param>
        public bool UpdateComputer(Computer c1, Computer c2)
        {
            try
            {
                if(CoreProcedure<List<Computer>>.UpdateComputer(c1, c2))
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Update computer state
        /// </summary>
        /// <param name="c1">Computer to update</param>
        /// <param name="state">State</param>
        public void UpdateState(Computer c1, State state)
        {
            try
            {
                CoreProcedure<List<Computer>>.UpdateState(c1, state);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

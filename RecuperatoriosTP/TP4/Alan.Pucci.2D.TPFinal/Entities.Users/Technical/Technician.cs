using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Users;
using Entities.Users.Technical;
using Procedure;

namespace Entities
{
    public class Technician : User, IUser<Computer>, ITechnician<Computer>
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Technician()
        {

        }

        /// <summary>
        /// Constructor, initialize all attributes
        /// </summary>
        /// <param name="name">Name to initialize</param>
        /// <param name="lastName">Last name to initialize</param>
        /// <param name="username">Username to initialize</param>
        /// <param name="password">Password to initialize</param>
        public Technician(string name, string lastName, string username, string password)
            :base(name, lastName, username,password)
        {
        }

        /// <summary>
        /// Repair a computer
        /// </summary>
        /// <param name="c1">Computer to repair</param>
        /// <param name="c2">Repaired computer to replace</param>
        public void Repair(Computer c1, Computer c2)
        {
            try
            {
                c2.ComputerState = State.Reparada;
                if (c1.Desc == c2.Desc)
                {
                    throw new Exception("Debes indicar en la descripción qué fue lo que se reparó");
                }
                if (!(this.UpdateComputer(c1, c2)))
                {
                    throw new Exception("No se pudo reparar la computadora");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 

        /// <summary>
        /// Deliver a computer to recepcionist
        /// </summary>
        /// <param name="computer">Computer to deliver</param>
        public void Deliver(Computer computer)
        {
            try
            {
                this.UpdateState(computer, State.PorEntregar);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo entregar la computadora");
            }
        }
    }
}

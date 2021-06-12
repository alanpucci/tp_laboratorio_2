using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Users;
using Entities.Users.Recepcionist;
using Procedure;

namespace Entities
{
    public class Recepcionist:User, IRecepcionist<Computer>, IUser<Computer>
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Recepcionist()
        {
        }

        /// <summary>
        /// Constructor, initialize all attributes
        /// </summary>
        /// <param name="name">Name to initialize</param>
        /// <param name="lastName">Last name to initialize</param>
        /// <param name="username">Username to initialize</param>
        /// <param name="password">Password to initialize</param>
        public Recepcionist(string name, string lastName, string username, string password)
            :base(name, lastName, username, password)
        {
        }

        /// <summary>
        /// Add a computer
        /// </summary>
        /// <param name="computer">Computer to add</param>
        public bool AddComputer(Computer computer)
        {
            try
            {
                if (CoreProcedure<List<Computer>>.AddComputer(computer))
                {
                    return true;
                }
                throw new Exception("No hay espacio para cargar la computadora.\nPor favor, asigna las computadoras al técnico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete a computer
        /// </summary>
        /// <param name="computer">Computer to delete</param>
        public void DeleteComputer(Computer computer)
        {
            try
            {
                CoreProcedure<List<Computer>>.DeleteComputer(computer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Deliver a computer to technician
        /// </summary>
        /// <param name="computer">Computer to deliver</param>
        public void ToRepair(Computer computer)
        {
            try
            {
                this.UpdateState(computer, State.PorReparar);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo enviar la computadora al técnico");
            }
        }

        /// <summary>
        /// Deliver a computer to the client
        /// </summary>
        /// <param name="computer">Computer to deliver</param>
        public void ToDeliver(Computer computer)
        {
            try
            {
                this.UpdateState(computer, State.Devuelta);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo entregar la computadora al cliente");
            }
        }
    }
}

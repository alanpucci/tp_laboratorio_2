using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Recepcionist:User
    {
        public Recepcionist(string username, string password):base(username, password)
        {
        }

        public void ToRepair()
        {
            //CoreProcedure<List<Computer>>.UpdateState(computer, State.PorReparar);
        }
    }
}

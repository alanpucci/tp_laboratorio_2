using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class PasswordException:Exception
    {
        /// <summary>
        /// Exception constructor
        /// </summary>
        /// <param name="message">Exception message</param>
        public PasswordException(string message) : base(message)
        {

        }

    }
}

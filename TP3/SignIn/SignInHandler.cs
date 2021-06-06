using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace SignIn
{
    public class SignInHandler : ISignIn
    {
        private const string RECEPSIONIST = "recepcionista";
        private const string TECHNICAL = "tecnico";
        private const string GLOBALPASS = "12345";

        public User SignIn(string username, string password)
        {
            try
            {
                if (String.IsNullOrEmpty(username.Trim()) || String.IsNullOrEmpty(password.Trim()))
                {
                    throw new Exception("Por favor, llene todos los campos");
                }
                if (username == RECEPSIONIST && password == GLOBALPASS)
                {
                    return new Recepcionist(username, password);
                }
                else
                {
                    if (username == TECHNICAL && password == GLOBALPASS)
                    {
                        return new Technical(username, password);
                    }
                    else
                    {
                        throw new Exception("Usuario invalido");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

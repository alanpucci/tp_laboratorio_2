using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Files;

namespace SignIn
{
    public class SignInHandler : ISignIn, IFiles<User>
    {
        private const string RECEPTIONIST = "recepcionista";

        public User SignIn(string username, string password)
        {
            try
            {
                User userAux;
                if (String.IsNullOrEmpty(username.Trim()) || String.IsNullOrEmpty(password.Trim()))
                {
                    throw new Exception("Por favor, llene todos los campos");
                }
                userAux = this.ReadFile(username == RECEPTIONIST ? "recepcionist.xml" : "technical.xml");
                if(password == userAux.Password)
                {
                    return userAux;
                }
                throw new Exception("Usuario inválido");
            }
            catch (FileNotFoundException)
            {
                if(username == RECEPTIONIST)
                {
                    return new Recepcionist("Alan", "Pucci", "recepcionista", "12345");
                }
                else
                {
                    return new Technician("Alan","Pucci","tecnico","12345");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User ReadFile(string fileName)
        {
            try
            {
                FilesHandler<User> filesHandler = new FilesHandler<User>();
                User user = filesHandler.ReadFile(fileName);
                if(!(user is null))
                {
                    return user;
                }
                return user;
            }
            catch(FileNotFoundException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveFile(User user, string fileName)
        {
            try
            {
                FilesHandler<User> filesHandler = new FilesHandler<User>();
                if(user is Recepcionist)
                {
                    filesHandler.SaveFile(user, "recepcionist.xml");
                }
                else
                {
                    if(user is Technician)
                    {
                        filesHandler.SaveFile(user, "technical.xml");
                    }
                    else
                    {
                        throw new Exception("No se pudo guardar el usuario");
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

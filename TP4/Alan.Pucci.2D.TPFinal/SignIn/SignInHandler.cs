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
        private const string TECHNICIAN = "tecnico";
        private const string GLOBALPASSWORD = "12345";

        /// <summary>
        /// Sign in a user by username and password
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>Returns the user if exists, returns a new user if not</returns>
        public User SignIn(string username, string password)
        {
            try
            {
                User userAux;
                if (String.IsNullOrEmpty(username.Trim()) || String.IsNullOrEmpty(password.Trim()))
                {
                    throw new Exception("Por favor, llene todos los campos");
                }
                userAux = this.ReadFile(username.Trim().ToLower() == RECEPTIONIST ? "recepcionist.xml" : "technical.xml");
                if(password == userAux.Password)
                {
                    return userAux;
                }
                throw new Exception("Usuario inválido");
            }
            catch (FileNotFoundException)
            { 
                if(username.Trim().ToLower() == RECEPTIONIST && password == GLOBALPASSWORD)
                {
                    Receptionist receptionist = new Receptionist("Recepcionista", "Soy", username.Trim().ToLower(), password);
                    this.SaveFile(receptionist, "receptionist.xml");
                    return receptionist;
                }
                else
                {
                    if (username == TECHNICIAN && password == GLOBALPASSWORD)
                    {
                        Technician technician = new Technician("Técnico", "Soy", username.Trim().ToLower(), password);
                        this.SaveFile(technician, "technician.xml");
                        return technician;
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

        /// <summary>
        /// Loads a user from a file
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <returns>The user</returns>
        public User ReadFile(string fileName)
        {
            try
            {
                FilesHandler<User> filesHandler = new FilesHandler<User>();
                return filesHandler.ReadFile(fileName);
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

        /// <summary>
        /// Saves a user into a file
        /// </summary>
        /// <param name="user">User to save</param>
        /// <param name="fileName">File name</param>
        public void SaveFile(User user, string fileName)
        {
            try
            {
                FilesHandler<User> filesHandler = new FilesHandler<User>();
                if(user is Receptionist)
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

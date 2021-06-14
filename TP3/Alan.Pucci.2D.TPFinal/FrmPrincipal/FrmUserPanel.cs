using Entities;
using Exceptions;
using SignIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmUserPanel : Form
    {
        User user;
        public FrmUserPanel(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        /// <summary>
        /// Completes username, name and lastname of user
        /// </summary>
        private void FrmUserPanel_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtUsername.Text = this.user.Username;
                this.txtName.Text = this.user.Name;
                this.txtLastName.Text = this.user.LastName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Saves the changes
        /// </summary>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtName.Text.Trim() == "" || this.txtLastName.Text.Trim() == "")
                {
                    throw new Exception("No puede dejar el nombre y/o apellido vacio.");
                }
                this.user.Name = this.txtName.Text;
                this.user.LastName = this.txtLastName.Text;
                this.user.Password = this.ValidatePassword(this.txtPassword.Text, this.txtRepeatPassword.Text);
                MessageBox.Show("Usuario modificado exitosamente.", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SignInHandler signInHandler = new SignInHandler();
                signInHandler.SaveFile(this.user, "");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Validate if password is alphanumeric, has at least 5 characters and password is same as repeat password, Implements PasswordException
        /// </summary>
        /// <param name="password">First password</param>
        /// <param name="repeatPassword">Second password</param>
        /// <returns>Password</returns>
        private string ValidatePassword(string password, string repeatPassword)
        {
            try
            {
                if(password.Length > 0 || repeatPassword.Length > 0)
                {
                    Regex r = new Regex("^[a-zA-Z0-9]*$");
                    if(password != repeatPassword)
                    {
                        throw new PasswordException("Las contraseñas no coinciden.");
                    }
                    if (password.Length < 5)
                    {
                        throw new PasswordException("Tiene que tener 5 carácteres como mínimo.");
                    }
                    if(!r.IsMatch(password))
                    {
                        throw new PasswordException("Solo se permite letras y/o números.");
                    }
                    return password;
                }
                return this.user.Password;
            }
            catch (PasswordException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Checkbox to show or hide password
        /// </summary>
        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkPassword.Checked)
            {
                this.txtPassword.PasswordChar = default(char);
                this.txtRepeatPassword.PasswordChar = default(char);
            }
            else
            {
                this.txtPassword.PasswordChar = '*';
                this.txtRepeatPassword.PasswordChar = '*';
            }
        }
    }
}

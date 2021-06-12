using Entities;
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

        private void FrmUserPanel_Load(object sender, EventArgs e)
        {
            this.txtUsername.Text = this.user.Username;
            this.txtName.Text = this.user.Name;
            this.txtLastName.Text = this.user.LastName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                this.user.Name = this.txtName.Text;
                this.user.LastName = this.txtLastName.Text;
                this.user.Password = this.ValidatePassword(this.txtPassword.Text, this.txtRepeatPassword.Text);
                MessageBox.Show("Usuario modificado exitosamente.", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private string ValidatePassword(string password, string repeatPassword)
        {
            try
            {
                if(password.Length > 0)
                {
                    Regex r = new Regex("^[a-zA-Z0-9]*$");
                    if (password.Length < 5)
                    {
                        throw new Exception("Tiene que tener 5 carácteres como mínimo.");
                    }
                    if(password != repeatPassword)
                    {
                        throw new Exception("Las contraseñas no coinciden.");
                    }
                    if(!r.IsMatch(password))
                    {
                        throw new Exception("Solo se permite letras y/o números.");
                    }
                    return password;
                }
                return this.user.Password;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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

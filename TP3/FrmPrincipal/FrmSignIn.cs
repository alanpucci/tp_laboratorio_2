using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Files;
using SignIn;

namespace FrmPrincipal
{
    public partial class FrmSignIn : Form
    {
        public FrmSignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                SignInHandler signInHandler = new SignInHandler();
                User user = signInHandler.SignIn(this.txtUsername.Text, this.txtPassword.Text);
                this.txtUsername.Text = string.Empty;
                this.txtPassword.Text = string.Empty;
                this.Hide();
                if(user is Recepcionist)
                {
                    new FrmUser((Recepcionist)user).ShowDialog();
                }
                else if(user is Technician)
                {
                    new FrmUser((Technician)user).ShowDialog();
                }
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            try
            {
                TextHandler fileHandler = new TextHandler();
                MessageBox.Show(fileHandler.ReadFile("help.txt"), "Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir el archivo de 'Ayuda'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkPassword.Checked)
            {
                this.txtPassword.PasswordChar = default(char);
            }
            else
            {
                this.txtPassword.PasswordChar = '*';
            }
        }
    }
}

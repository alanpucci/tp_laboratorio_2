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
    public delegate void SignInDelegate();
    public partial class FrmSignIn : Form
    {
        private event SignInDelegate SignInEvent;
        public FrmSignIn()
        {
            InitializeComponent();
            this.SignInEvent += this.SignIn;
        }

        /// <summary>
        /// Login button, reads the correspondient file by an username and password
        /// </summary>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                this.SignInEvent.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Close button
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Reads the correspondient file by an username and password and open the correspondient form
        /// </summary>
        private void SignIn()
        {
            try
            {
                SignInHandler signInHandler = new SignInHandler();
                User user = signInHandler.SignIn(this.txtUsername.Text, this.txtPassword.Text);
                this.txtUsername.Text = string.Empty;
                this.txtPassword.Text = string.Empty;
                this.Hide();
                if (user is Receptionist)
                {
                    new FrmUser((Receptionist)user).ShowDialog();
                }
                else if (user is Technician)
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

        /// <summary>
        /// Help button, reads the "help.txt" file
        /// </summary>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            try
            {
                TextHandler fileHandler = new TextHandler();
                FrmHelp frmHelp = new FrmHelp(fileHandler.ReadFile("help.txt"));
                this.Hide();
                frmHelp.ShowDialog();
                this.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir el archivo de 'Ayuda'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            }
            else
            {
                this.txtPassword.PasswordChar = '*';
            }
        }

        /// <summary>
        /// If enter is pressed, it calls the signIn method. If escape is pressed, it closes
        /// </summary>
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.SignInEvent.Invoke();
            }
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        /// <summary>
        /// If enter is pressed, it calls the signIn method. If escape is pressed, it closes
        /// </summary>
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SignInEvent.Invoke();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

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
using SignIn;

namespace FrmPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
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
                else if(user is Technical)
                {
                    new FrmUser((Technical)user).ShowDialog();
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
    }
}

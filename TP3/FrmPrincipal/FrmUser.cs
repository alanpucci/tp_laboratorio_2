using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Procedure;
using Files;
using SignIn;

namespace FrmPrincipal
{
    public partial class FrmUser : Form
    {
        User user;
        public FrmUser(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmRecepcionist_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnAddComputer_Click(object sender, EventArgs e)
        {
            FrmComputer frmComputer = new FrmComputer(this.user);
            this.Hide();
            frmComputer.ShowDialog();
            this.Show();
        }

        private void btnListComputers_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(this.user is Recepcionist)
            {
                FrmRecepcionistComputers frmList = new FrmRecepcionistComputers((Recepcionist)this.user);
                frmList.ShowDialog();
            }
            else
            {
                FrmTechnicalComputers frmList = new FrmTechnicalComputers((Technician)this.user);
                frmList.ShowDialog();
            }
            this.Show();
        }

        private void FrmRecepcionist_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                FilesHandler<List<Computer>> fileHandler = new FilesHandler<List<Computer>>();
                SignInHandler signInHandler = new SignInHandler();
                fileHandler.SaveFile(CoreProcedure<List<Computer>>.Computers, "Computers.xml");
                signInHandler.SaveFile(this.user, "users.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            if(this.user is Recepcionist)
            {
                this.Text = "Recepcionista";
                this.lblDescription.Text = "Ésta es la bandeja del recepcionista, desde aquí podrás cargar las computadoras entrantes " +
                    "de los clientes y asignarlas al técnico correspondiente. \nUna vez reparada la computadora deberás devolversela al cliente.";
            }
            else
            {
                this.Text = "Técnico";
                this.btnAddComputer.Enabled = false;
                this.lblAddComputer.Text = "No tienes permisos";
                this.lblDescription.Text = "Ésta es la bandeja del técnico, desde aquí podrás reparar las computadoras entrantes " +
                    "de los clientes. \nUna vez reparada la computadora deberás devolversela al recepcionista para su devolución.";
            }
            this.lblTitle.Text = $"{this.lblTitle.Text} {this.user.Name}";
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmUserPanel userPanel = new FrmUserPanel(this.user);
            this.Hide();
            userPanel.ShowDialog();
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

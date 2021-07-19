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

        /// <summary>
        /// Constructor, initialize user
        /// </summary>
        /// <param name="user"></param>
        public FrmUser(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        /// <summary>
        /// Closing form
        /// </summary>
        private void FrmRecepcionist_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Open computer panel
        /// </summary>
        private void btnAddComputer_Click(object sender, EventArgs e)
        {
            try
            {
                FrmComputer frmComputer = new FrmComputer(this.user);
                this.Hide();
                frmComputer.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Open computer list panel
        /// </summary>
        private void btnListComputers_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                if(this.user is Receptionist)
                {
                    FrmRecepcionistComputers frmList = new FrmRecepcionistComputers((Receptionist)this.user);
                    frmList.ShowDialog();
                }
                else
                {
                    FrmTechnicalComputers frmList = new FrmTechnicalComputers((Technician)this.user);
                    frmList.ShowDialog();
                }
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Change title and descrption depending if user is receptionist or technician
        /// </summary>
        private void FrmUser_Load(object sender, EventArgs e)
        {
            if(this.user is Receptionist)
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

        /// <summary>
        /// Open user panel
        /// </summary>
        private void btnUser_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUserPanel userPanel = new FrmUserPanel(this.user);
                this.Hide();
                userPanel.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Close form
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

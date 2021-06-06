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
            FrmComputer frmComputer = new FrmComputer();
            frmComputer.ShowDialog();
        }

        private void btnListComputers_Click(object sender, EventArgs e)
        {
            if(user is Recepcionist)
            {
                FrmRecepcionistComputers frmList = new FrmRecepcionistComputers((Recepcionist)user);
                frmList.ShowDialog();
            }
            else
            {
                FrmTechnicalComputers frmList = new FrmTechnicalComputers((Technical)user);
                frmList.ShowDialog();
            }
        }

        private void FrmRecepcionist_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                FilesHandler<List<Computer>> fileHandler = new FilesHandler<List<Computer>>();
                fileHandler.SaveFile(CoreProcedure<List<Computer>>.Computers, "Computers.xml");
                MessageBox.Show("Lista guardada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            if(user is Recepcionist)
            {
                this.Text = "Recepcionista";
            }
            else
            {
                this.Text = "Técnico";
            }
        }
    }
}

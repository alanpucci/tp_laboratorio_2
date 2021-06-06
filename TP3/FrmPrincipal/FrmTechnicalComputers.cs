using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Procedure;
using Entities;

namespace FrmPrincipal
{
    public partial class FrmTechnicalComputers : Form
    {
        Technical tech;
        int showIndex;
        public FrmTechnicalComputers(Technical tech)
        {
            InitializeComponent();
            this.tech = tech;
            this.showIndex = 0;
        }

        private void FrmTechnical_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void FrmTechnical_Load(object sender, EventArgs e)
        {
            this.ReloadData();
        }
        private void ReloadData()
        {
            this.dgvComputers.DataSource = null;
            BindingSource bSource = new BindingSource();
            bSource.DataSource = this.GetComputers(showIndex);
            this.dgvComputers.DataSource = bSource;
        }

        private List<Computer> GetComputers(int index)
        {
            switch (index)
            {
                case 1:
                    return CoreProcedure<List<Computer>>.ToRepairComputers;
                break;
                case 2:
                    return CoreProcedure<List<Computer>>.RepairedComputers;
                break;
                default:
                    List<Computer> list = new List<Computer>();
                    list.AddRange(CoreProcedure<List<Computer>>.RepairedComputers);
                    list.AddRange(CoreProcedure<List<Computer>>.ToRepairComputers);
                    return list;
                break;
            }
        }

        private void cmbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.showIndex = this.cmbShow.SelectedIndex;
            this.ReloadData();
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.dgvComputers.CurrentRow is null)
                {
                    throw new Exception("No tienes ninguna computadora selecionada");
                }
                Computer computer = (Computer)this.dgvComputers.CurrentRow.DataBoundItem;
                FrmComputer frmComputer = new FrmComputer(computer, ToDo.Repair);
                frmComputer.ShowDialog();
                this.ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvComputers.CurrentRow is null)
                {
                    throw new Exception("No tienes ninguna computadora selecionada");
                }
                Computer computer = (Computer)this.dgvComputers.CurrentRow.DataBoundItem;
                CoreProcedure<List<Computer>>.UpdateState(computer, State.PorEntregar);
                MessageBox.Show("Se entregó la computadora al recepcionista", "Entregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

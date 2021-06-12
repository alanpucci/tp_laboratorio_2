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
        Technician tech;
        int showIndex;
        public FrmTechnicalComputers(Technician tech)
        {
            InitializeComponent();
            this.tech = tech;
            this.showIndex = 0;
        }

        private void FrmTechnical_Load(object sender, EventArgs e)
        {
            this.ReloadData();
            this.cmbShow.SelectedIndex = 0;
        }
        private void ReloadData()
        {
            try
            {
                this.dgvComputers.DataSource = null;
                BindingSource bSource = new BindingSource();
                bSource.DataSource = GetComputers(showIndex);
                this.dgvComputers.DataSource = bSource;
                if (this.dgvComputers.CurrentRow is null)
                {
                    this.btnRepair.Enabled = false;
                }
                else
                {
                    this.EnableDeliverButton((Computer)this.dgvComputers.CurrentRow.DataBoundItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private List<Computer> GetComputers(int index)
        {
            switch (index)
            {
                case 0:
                    return CoreProcedure<List<Computer>>.ToRepairComputers;
                case 1:
                    return CoreProcedure<List<Computer>>.RepairedComputers;
                default:
                    List<Computer> list = new List<Computer>();
                    list.AddRange(CoreProcedure<List<Computer>>.RepairedComputers);
                    list.AddRange(CoreProcedure<List<Computer>>.ToRepairComputers);
                    return list;
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
                FrmComputer frmComputer = new FrmComputer(tech, computer, ToDo.Repair);
                this.Hide();
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
                this.tech.Deliver(computer);
                MessageBox.Show("Se entregó la computadora al recepcionista", "Entregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvComputers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvComputers.CurrentRow is null)
                {
                    throw new Exception("La lista está vacia");
                }
                Computer computer = (Computer)this.dgvComputers.CurrentRow.DataBoundItem;
                this.EnableDeliverButton(computer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EnableDeliverButton(Computer computer)
        {
            if (computer.ComputerState == State.Reparada)
            {
                this.btnRepair.Enabled = false;
                this.btnDeliver.Enabled = true;
                this.btnRepair.BackColor = Color.LightGray;
                this.btnDeliver.BackColor = Color.FromArgb(70, 100, 200);
            }
            else
            {
                this.btnDeliver.Enabled = false;
                this.btnRepair.Enabled = true;
                this.btnDeliver.BackColor = Color.LightGray;
                this.btnRepair.BackColor = Color.FromArgb(70, 100, 200);
            }
        }
    }
}

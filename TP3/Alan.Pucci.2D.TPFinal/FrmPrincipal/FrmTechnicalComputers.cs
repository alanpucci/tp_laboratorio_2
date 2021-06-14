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
        CoreProcedure procedure = CoreProcedure.Instance;
        int showIndex;
        public FrmTechnicalComputers(Technician tech)
        {
            InitializeComponent();
            this.tech = tech;
            this.showIndex = 0;
        }

        /// <summary>
        /// Load computers and put filter into "to repair computers"
        /// </summary>
        private void FrmTechnical_Load(object sender, EventArgs e)
        {
            this.ReloadData();
            this.cmbShow.SelectedIndex = 0;
        }

        /// <summary>
        /// Loads data to data grid view and enable / disable buttons
        /// </summary>
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
                    this.DisableButtons();
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

        /// <summary>
        /// Get computers by filter
        /// </summary>
        /// <param name="index">Filter</param>
        /// <returns>computers</returns>
        private List<Computer> GetComputers(int index)
        {
            switch (index)
            {
                case 0:
                    return this.procedure[State.PorReparar];
                case 1:
                    return this.procedure[State.Reparada];
                default:
                    List<Computer> list = new List<Computer>();
                    list.AddRange(this.procedure[State.PorReparar]);
                    list.AddRange(this.procedure[State.Reparada]);
                    return list;
            }
        }

        /// <summary>
        /// Reload data after filter changes
        /// </summary>
        private void cmbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.showIndex = this.cmbShow.SelectedIndex;
            this.ReloadData();
        }

        /// <summary>
        /// Open computer panel to repair the selected computer
        /// </summary>
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
                this.Show();
                this.ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Deliver the selected computer to receptionist
        /// </summary>
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

        /// <summary>
        /// Enables buttons by clicking a cell
        /// </summary>
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

        /// <summary>
        /// Enables repair / deliver button
        /// </summary>
        /// <param name="computer"></param>
        private void EnableDeliverButton(Computer computer)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Disables button
        /// </summary>
        private void DisableButtons()
        {
            this.btnRepair.Enabled = false;
            this.btnDeliver.Enabled = false;
            this.btnRepair.BackColor = Color.LightGray;
            this.btnDeliver.BackColor = Color.LightGray;
        }
    }
}

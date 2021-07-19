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
using Exceptions;
using Procedure;

namespace FrmPrincipal
{
    public partial class FrmRecepcionistComputers : Form
    {
        Receptionist recepcionist;
        CoreProcedure procedure = CoreProcedure.Instance;
        int showIndex;
        ToDo toDo;
        bool isXml;

        /// <summary>
        /// Constructor, loads computers from a DB, initialize receptionist
        /// </summary>
        /// <param name="recepcionist"></param>
        public FrmRecepcionistComputers(Receptionist recepcionist)
        {
            InitializeComponent();
            CoreProcedure.LoadComputers();
            this.recepcionist = recepcionist;
            this.showIndex = 0;
            this.toDo = ToDo.Repair;
            this.isXml = false;
        }

        /// <summary>
        /// Load computers and put filter into "received computers"
        /// </summary>
        private void FrmRecepcionistComputers_Load(object sender, EventArgs e)
        {
            this.ReloadData();
            this.cmbShow.SelectedIndex = 0;
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Deliver computer to technician or client
        /// </summary>
        private void btnDeliver_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.dgvComputers.CurrentRow is null)
                {
                    throw new Exception("No tienes ninguna computadora selecionada");
                }
                Computer computer = (Computer)this.dgvComputers.CurrentRow.DataBoundItem;
                if(this.toDo == ToDo.Repair)
                {
                    this.recepcionist.ToRepair(computer);
                    MessageBox.Show("Se entregó la computadora al técnico", "Entregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.recepcionist.ToDeliver(computer);
                    MessageBox.Show("Se entregó la computadora al cliente", "Entregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Open computer panel to modify selected computer
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvComputers.CurrentRow is null)
                {
                    throw new Exception("No tienes ninguna computadora selecionada");
                }
                Computer computer = (Computer)this.dgvComputers.CurrentRow.DataBoundItem;
                FrmComputer frmComputer = new FrmComputer(recepcionist, computer, ToDo.Edit);
                this.Hide();
                frmComputer.ShowDialog();
                this.Show();
                this.ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Deletes selected computer
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvComputers.CurrentRow is null)
                {
                    throw new Exception("No tienes ninguna computadora selecionada");
                }
                Computer computer = (Computer)this.dgvComputers.CurrentRow.DataBoundItem;
                if (!(computer is null) && (MessageBox.Show("¿Está seguro que desea borrarlo de la lista?", "Eliminar computadora", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.recepcionist.DeleteComputer(computer);
                    MessageBox.Show("Computadora eliminada exitosamente", "Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ReloadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    this.HandleEnableButtons((Computer)this.dgvComputers.CurrentRow.DataBoundItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                case 1:
                    return this.procedure[State.PorReparar];
                case 2:
                    return this.procedure[State.Reparada];
                case 3:
                    this.btnDeliver.Text = "Devolver al cliente";
                    this.btnDeliver.Enabled = true;
                    return this.procedure[State.PorEntregar];
                case 4:
                    return this.procedure[State.Devuelta];
                case 5:
                    return CoreProcedure.Computers;
                default:
                    this.btnDeliver.Text = "Enviar al técnico";
                    return this.procedure[State.Recibida];
            }
        }

        /// <summary>
        /// Reload data after filter changes
        /// </summary>
        private void cmbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.showIndex = this.cmbShow.SelectedIndex;
                this.ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Disable buttons
        /// </summary>
        private void DisableButtons()
        {
            this.btnDelete.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDeliver.Enabled = false;
            this.btnDeliver.BackColor = Color.LightGray;
            this.btnEdit.BackColor = Color.LightGray;
            this.btnDelete.BackColor = Color.LightGray;
        }

        /// <summary>
        /// Enables buttons by clicking a cell
        /// </summary>
        private void dgvComputers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(this.dgvComputers.CurrentRow is null)
                {
                    throw new Exception("La lista está vacia");
                }
                Computer computer = (Computer)this.dgvComputers.CurrentRow.DataBoundItem;
                this.HandleEnableButtons(computer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Enables buttons by state of computer
        /// </summary>
        /// <param name="computer"></param>
        private void HandleEnableButtons(Computer computer)
        {
            try
            {
                if (computer.ComputerState == State.Recibida && computer.ID != 0)
                {
                    this.btnDeliver.Text = "Enviar al técnico";
                    this.toDo = ToDo.Repair;
                    this.btnDelete.Enabled = true;
                    this.btnEdit.Enabled = true;
                    this.btnDeliver.Enabled = true;
                    this.btnDeliver.BackColor = Color.FromArgb(70, 100, 200);
                    this.btnEdit.BackColor = Color.FromArgb(112, 175, 214);
                    this.btnDelete.BackColor = Color.FromArgb(232, 62, 62);
                }
                else
                {
                    this.DisableButtons();
                    if (computer.ComputerState == State.PorEntregar)
                    {
                        this.btnDeliver.Text = "Devolver al cliente";
                        this.btnDeliver.BackColor = Color.FromArgb(70, 100, 200);
                        this.btnDeliver.Enabled = true;
                        this.toDo = ToDo.Deliver;
                    }
                }
                if (this.isXml)
                {
                    this.DisableButtons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Loads computers from a XML
        /// </summary>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    CoreProcedure.LoadComputersFromFile(dialog.FileName);
                    this.isXml = true;
                    this.ReloadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmRecepcionistComputers_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CoreProcedure.LoadComputers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

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

namespace FrmPrincipal
{
    public partial class FrmRecepcionistComputers : Form
    {
        Recepcionist recepcionist;
        int showIndex;
        ToDo toDo;
        public FrmRecepcionistComputers(Recepcionist recepcionist)
        {
            InitializeComponent();
            this.recepcionist = recepcionist;
            this.showIndex = 0;
            this.toDo = ToDo.Repair;
        }

        private void FrmRecepcionistComputers_Load(object sender, EventArgs e)
        {
            this.ReloadData();
            this.cmbShow.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                    //this.dgvComputers.Rows.RemoveAt(this.dgvComputers.CurrentRow.Index);
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
                    //throw new Exception("La lista se encuentra vacia");
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

        private List<Computer> GetComputers(int index)
        {
            switch (index)
            { 
                case 1:
                    this.DisableButtons();
                    return CoreProcedure<List<Computer>>.ToRepairComputers;
                case 2:
                    this.DisableButtons();
                    return CoreProcedure<List<Computer>>.RepairedComputers;
                case 3:
                    this.DisableButtons();
                    this.btnDeliver.Text = "Devolver al cliente";
                    this.btnDeliver.Enabled = true;
                    return CoreProcedure<List<Computer>>.ToDeliverComputers;
                case 4:
                    this.DisableButtons();
                    return CoreProcedure<List<Computer>>.DeliveredComputers;
                case 5:
                    this.DisableButtons();
                    List<Computer> list = new List<Computer>();
                    list.AddRange(CoreProcedure<List<Computer>>.ReceivedComputers);
                    list.AddRange(CoreProcedure<List<Computer>>.ToRepairComputers);
                    list.AddRange(CoreProcedure<List<Computer>>.RepairedComputers);
                    list.AddRange(CoreProcedure<List<Computer>>.ToDeliverComputers);
                    list.AddRange(CoreProcedure<List<Computer>>.DeliveredComputers);
                    return list;
                default:
                    this.btnDeliver.Text = "Enviar al técnico";
                    this.btnDelete.Enabled = true;
                    this.btnEdit.Enabled = true;
                    this.btnDeliver.Enabled = true;
                    return CoreProcedure<List<Computer>>.ReceivedComputers;
            }
        }

        private void cmbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.showIndex = this.cmbShow.SelectedIndex;
            this.ReloadData();
        }

        private void DisableButtons ()
        {
            this.btnDelete.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDeliver.Enabled = false;
            this.btnDeliver.BackColor = Color.LightGray;
            this.btnEdit.BackColor = Color.LightGray;
            this.btnDelete.BackColor = Color.LightGray;
        }

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

        private void HandleEnableButtons(Computer computer)
        {
            if (computer.ComputerState == State.Recibida)
            {
                this.btnDeliver.Text = "Enviar al técnico";
                this.btnDeliver.Enabled = true;
                this.btnDeliver.BackColor = Color.FromArgb(70, 100, 200);
                this.toDo = ToDo.Repair;
            }
            else
            {
                if (computer.ComputerState == State.PorEntregar)
                {
                    this.btnDeliver.Text = "Devolver al cliente";
                    this.btnDeliver.BackColor = Color.FromArgb(70, 100, 200);
                    this.btnDeliver.Enabled = true;
                    this.toDo = ToDo.Deliver;
                }
                else
                {
                    this.DisableButtons();
                }
            }
        }
    }
}

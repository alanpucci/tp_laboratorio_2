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
        public FrmRecepcionistComputers(Recepcionist recepcionist)
        {
            InitializeComponent();
            this.recepcionist = recepcionist;
            this.showIndex = 0;
        }

        private void FrmRecepcionistComputers_Load(object sender, EventArgs e)
        {
            this.ReloadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            try
            {
                Computer computer = (Computer)this.dgvComputers.CurrentRow.DataBoundItem;
                this.recepcionist.ToRepair();
                CoreProcedure<List<Computer>>.UpdateState(computer, State.PorReparar);
                MessageBox.Show("Se entregó la computadora al técnico", "Entregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Computer computer = (Computer)this.dgvComputers.CurrentRow.DataBoundItem;
            FrmComputer frmComputer = new FrmComputer(computer, ToDo.Edit);
            frmComputer.ShowDialog();
            this.ReloadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Computer computer = (Computer)this.dgvComputers.CurrentRow.DataBoundItem;
                if (!(computer is null) && (MessageBox.Show("¿Está seguro que desea borrarlo de la lista?", "Eliminar computadora", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.dgvComputers.Rows.RemoveAt(this.dgvComputers.CurrentRow.Index);
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
            this.dgvComputers.DataSource = null;
            BindingSource bSource = new BindingSource();
            bSource.DataSource = GetComputers(showIndex);
            this.dgvComputers.DataSource = bSource;
        }

        private List<Computer> GetComputers(int index)
        {
            switch (index)
            {
                case 1:
                    return CoreProcedure<List<Computer>>.ReceivedComputers;
                    break;
                case 2:
                    return CoreProcedure<List<Computer>>.ToRepairComputers;
                    break;
                case 3:
                    return CoreProcedure<List<Computer>>.RepairedComputers;
                    break;
                case 4:
                    return CoreProcedure<List<Computer>>.ToDeliverComputers;
                    break;
                case 5:
                    return CoreProcedure<List<Computer>>.DeliveredComputers;
                    break;
                default:
                    List<Computer> list = new List<Computer>();
                    list.AddRange(CoreProcedure<List<Computer>>.ReceivedComputers);
                    list.AddRange(CoreProcedure<List<Computer>>.ToRepairComputers);
                    list.AddRange(CoreProcedure<List<Computer>>.RepairedComputers);
                    list.AddRange(CoreProcedure<List<Computer>>.ToDeliverComputers);
                    list.AddRange(CoreProcedure<List<Computer>>.DeliveredComputers);
                    return list;
                    break;
            }
        }

        private void cmbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.showIndex = this.cmbShow.SelectedIndex;
            this.ReloadData();
        }
    }
}

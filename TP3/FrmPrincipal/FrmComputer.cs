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
    public partial class FrmComputer : Form
    {
        Computer computer;
        ToDo toDo;
        public FrmComputer()
        {
            InitializeComponent();
            this.toDo = ToDo.Add;
        }

        public FrmComputer(Computer computer, ToDo toDo):this()
        {
            this.computer = computer;
            this.toDo = toDo;
        }

        private void FrmAddComputer_Load(object sender, EventArgs e)
        {
            this.ModifyTitle();
            this.cmbOS.DataSource = Enum.GetValues(typeof(OS));
            this.cmbGraphicCard.DataSource = Enum.GetValues(typeof(GraphicCard));
            this.cmbHardDisk.DataSource = Enum.GetValues(typeof(HardDisk));
            this.cmbProcessor.DataSource = Enum.GetValues(typeof(Processor));
            this.cmbRAM.DataSource = Enum.GetValues(typeof(RAM));
            this.cmbType.DataSource = Enum.GetValues(typeof(ComType));
            if(!(computer is null))
            {
                this.txtClientName.Text = computer.ClientName;
                this.rtbDesc.Text = computer.Desc;
                this.cmbOS.SelectedItem = computer.OperativeSystem;
                this.cmbGraphicCard.SelectedItem = computer.ComputerGraphicCard;
                this.cmbHardDisk.SelectedItem = computer.ComputerHardDisk;
                this.cmbProcessor.SelectedItem = computer.ComputerProcessor;
                this.cmbRAM.SelectedItem = computer.ComputerRAM;
                this.cmbType.SelectedItem = computer.ComputerType;
            }
            //this.cmbOS.SelectedIndex = -1;
            //this.cmbGraphicCard.SelectedIndex = -1;
            //this.cmbHardDisk.SelectedIndex = -1;
            //this.cmbProcessor.SelectedIndex = -1;
            //this.cmbRAM.SelectedIndex = -1;
            //this.cmbType.SelectedIndex = -1;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbType.SelectedIndex == 0)
                {
                    Notebook notebook = new Notebook(this.txtClientName.Text, Brand.Apple,(OS)this.cmbOS.SelectedItem,(ComType)this.cmbType.SelectedItem,
                        (Processor)this.cmbProcessor.SelectedItem, (HardDisk)this.cmbHardDisk.SelectedItem, (RAM)this.cmbRAM.SelectedItem,this.rtbDesc.Text);
                    if(!(computer is null))
                    {
                        notebook.ComputerState = this.toDo == ToDo.Repair ? State.Reparada : notebook.ComputerState;
                        CoreProcedure<List<Computer>>.UpdateComputer(computer, notebook);
                        MessageBox.Show("¡La computadora fue modificada exitosamente!", "Info", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (CoreProcedure<List<Computer>>.AddComputer(notebook))
                        {
                            MessageBox.Show("¡La computadora se cargó exitosamente dentro del sistema!", "Info", MessageBoxButtons.OK);
                        }
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyTitle()
        {
            switch (this.toDo)
            {
                case ToDo.Edit:
                    this.Text = "Modificar computadora";
                    break;
                case ToDo.Repair:
                    this.Text = "Reparar computadora";
                    break;
                default:
                    this.Text = "Agregar computadora";
                    break;
            }
        }
    }
}

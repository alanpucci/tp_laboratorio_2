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
using Files;
using Exceptions;
using SQL;
using System.Threading;

namespace FrmPrincipal
{
    public partial class FrmComputer : Form
    {
        Computer computer;
        Computer newComputer;
        Thread thread;
        User user;
        ToDo toDo;

        public FrmComputer(User user)
        {
            InitializeComponent();
            this.toDo = ToDo.Add;
            this.user = user;
            CoreProcedure.RepairComputerEvent += this.Loading;
        }

        public Computer GetNewComputer
        {
            get
            {
                return this.newComputer;
            }
        }

        public FrmComputer(User user, Computer computer, ToDo toDo):this(user)
        {
            this.computer = computer;
            this.toDo = toDo;
        }


        /// <summary>
        /// Get combobox values, autocomplete inputs if computer isn't null
        /// </summary>
        private void FrmAddComputer_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbOS.DataSource = Enum.GetValues(typeof(OS));
                this.cmbGraphicCard.DataSource = Enum.GetValues(typeof(GraphicCard));
                this.cmbHardDisk.DataSource = Enum.GetValues(typeof(HardDisk));
                this.cmbProcessor.DataSource = Enum.GetValues(typeof(Processor));
                this.cmbRAM.DataSource = Enum.GetValues(typeof(RAM));
                this.cmbType.DataSource = Enum.GetValues(typeof(ComType));
                if (!(computer is null))
                {
                    this.txtClientName.Text = computer.ClientName;
                    this.txtClientName.Enabled = false;
                    this.rtbDesc.Text = computer.Desc;
                    this.cmbOS.SelectedItem = computer.OperativeSystem;
                    this.cmbGraphicCard.SelectedItem = computer.ComputerGraphicCard;
                    this.cmbHardDisk.SelectedItem = computer.ComputerHardDisk;
                    this.cmbProcessor.SelectedItem = computer.ComputerProcessor;
                    this.cmbRAM.SelectedItem = computer.ComputerRAM;
                    this.cmbType.SelectedItem = computer.ComputerType;
                    this.cmbType.Enabled = false;
                    this.ShowSelectors(true);
                    if(this.toDo == ToDo.Repair)
                    {
                        this.chkAccesory1.Enabled = false;
                        this.chkAccesory2.Enabled = false;
                    }
                    if(computer is Notebook)
                    {
                        this.cmbExtra.SelectedItem = ((Notebook)computer).Brand;
                        this.chkAccesory1.Checked = ((Notebook)computer).Charger;
                        this.chkAccesory2.Checked = ((Notebook)computer).TouchScreen;
                    }
                    else
                    {
                        this.cmbExtra.SelectedItem = ((Desktop)computer).Cooler;
                        this.chkAccesory1.Checked = ((Desktop)computer).DvdBurner;
                        this.chkAccesory2.Checked = ((Desktop)computer).ExtraAccesory;
                    }
                }
                else
                {
                    this.cmbOS.SelectedIndex = -1;
                    this.cmbGraphicCard.SelectedIndex = -1;
                    this.cmbHardDisk.SelectedIndex = -1;
                    this.cmbProcessor.SelectedIndex = -1;
                    this.cmbRAM.SelectedIndex = -1;
                    this.cmbType.SelectedIndex = -1;
                    this.ShowSelectors(false);
                }
                this.ModifyModal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Implements THREADS, completes the loading label
        /// </summary>
        /// <param name="text"></param>
        private void Loading(char text)
        {
            if (this.InvokeRequired)
            {
                RepairDelegate d = new RepairDelegate(this.Loading);
                object[] objs = new object[] { text };
                this.Invoke(d, objs);
            }
            else
            {
                this.lblLoading.Text = this.lblLoading.Text + text;
            }
        }

        /// <summary>
        /// Add, modify or repair a computer
        /// </summary>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.EnableAccept())
                {
                    throw new Exception("Debes llenar todos los campos.");
                }
                if (this.cmbType.SelectedIndex == 0)
                {
                    this.newComputer = new Notebook(this.txtClientName.Text, (Brand)this.cmbExtra.SelectedItem, this.chkAccesory1.Checked,this.chkAccesory2.Checked,(OS)this.cmbOS.SelectedItem,
                        (ComType)this.cmbType.SelectedItem, (Processor)this.cmbProcessor.SelectedItem, (HardDisk)this.cmbHardDisk.SelectedItem, (RAM)this.cmbRAM.SelectedItem,this.rtbDesc.Text, (GraphicCard)this.cmbGraphicCard.SelectedItem);
                }
                else
                {
                    this.newComputer = new Desktop(this.txtClientName.Text, (Cooler)this.cmbExtra.SelectedItem, this.chkAccesory1.Checked, this.chkAccesory2.Checked, (OS)this.cmbOS.SelectedItem,
                        (ComType)this.cmbType.SelectedItem, (Processor)this.cmbProcessor.SelectedItem, (HardDisk)this.cmbHardDisk.SelectedItem, (RAM)this.cmbRAM.SelectedItem, this.rtbDesc.Text, (GraphicCard)this.cmbGraphicCard.SelectedItem);
                }
                if (!(this.computer is null))
                {
                    if(this.toDo == ToDo.Repair)
                    {
                        this.thread = new Thread(this.Repair);
                        this.thread.Start();
                        MessageBox.Show("¡La computadora fue reparada exitosamente!\n" +
                            "¡No te olvides de enviarsela al recepcionista!", "Reparar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.user.UpdateComputer(this.computer, this.newComputer);
                        MessageBox.Show("¡La computadora fue modificada exitosamente!", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (((Receptionist)this.user).AddComputer(this.newComputer))
                    {
                        MessageBox.Show("¡La computadora se cargó exitosamente dentro del sistema!", "Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Repair()
        {
            try
            {
                ((Technician)this.user).Repair(this.computer, this.newComputer);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Show or hide extra combo box and check boxes
        /// </summary>
        /// <param name="state"></param>
        private void ShowSelectors(bool state)
        {
            this.cmbExtra.Visible = state;
            this.lblExtra.Visible = state;
            this.chkAccesory1.Visible = state;
            this.chkAccesory2.Visible = state;
        }

        /// <summary>
        /// Modifies title and description depending if user add, modify or repair computer
        /// </summary>
        private void ModifyModal()
        {
            this.HandleButtons(true);
            switch (this.toDo)
            {
                case ToDo.Edit:
                    this.lblTitle.Text = "Modificar computadora";
                    this.lblDescription.Text = "・No es necesario que modifiques todos los componentes";
                    break;
                case ToDo.Repair:
                    this.lblTitle.Text = "Reparar computadora";
                    this.lblDescription.Text = "・Es necesario que modifiques algún componente y cambiar la descripción";
                    this.txtClientName.ReadOnly = true;
                    this.cmbType.Enabled = false;
                    break;
                default:
                    this.lblTitle.Text = "Agregar computadora";
                    this.lblDescription.Text = "・Llena todos los campos para cargar la computadora";
                    this.HandleButtons(false);
                    break;
            }
        }

        /// <summary>
        /// Show desktop or notebook extra combo box and checkboxes
        /// </summary>
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.ShowSelectors(true);
                this.HandleButtons(true);
                if (this.cmbType.SelectedIndex == 0)
                {
                    this.lblExtra.Text = "Marca";
                    this.cmbExtra.DataSource = Enum.GetValues(typeof(Brand));
                    this.chkAccesory1.Text = "Cargador";
                    this.chkAccesory2.Text = "Pantalla táctil";
                }
                else
                {
                    this.lblExtra.Text = "Cooler";
                    this.cmbExtra.DataSource = Enum.GetValues(typeof(Cooler));
                    this.chkAccesory1.Text = "Grabadora DVD";
                    this.chkAccesory2.Text = "Accesorio extra";
                }
                this.cmbExtra.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Enable / disabled combo boxes
        /// </summary>
        /// <param name="state"></param>
        private void HandleButtons(bool state)
        {
            this.cmbOS.Enabled = state;
            this.cmbGraphicCard.Enabled = state;
            this.cmbHardDisk.Enabled = state;
            this.cmbProcessor.Enabled = state;
            this.cmbRAM.Enabled = state;
        }

        /// <summary>
        /// Enables accept button
        /// </summary>
        private bool EnableAccept()
        {
            return (this.cmbType.SelectedIndex != -1 && this.cmbOS.SelectedIndex != -1 && this.cmbHardDisk.SelectedIndex != -1 && this.cmbProcessor.SelectedIndex != -1 &&
                    this.cmbGraphicCard.SelectedIndex != -1 && this.cmbExtra.SelectedIndex != -1 && this.txtClientName.Text.Trim() != "" && this.rtbDesc.Text.Trim() != "");
        }

        /// <summary>
        /// Closes the form and the thread
        /// </summary>
        private void FrmComputer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!(this.thread is null) && this.thread.IsAlive)
            {
                this.thread.Abort();
            }
        }
    }
}

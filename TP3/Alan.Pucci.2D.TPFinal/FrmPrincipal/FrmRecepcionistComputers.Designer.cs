
namespace FrmPrincipal
{
    partial class FrmRecepcionistComputers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvComputers = new System.Windows.Forms.DataGridView();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operativeSystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerProcessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerRAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerHardDiskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerGraphicCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeliver = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbShow = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.desktopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desktopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComputers
            // 
            this.dgvComputers.AllowUserToAddRows = false;
            this.dgvComputers.AllowUserToDeleteRows = false;
            this.dgvComputers.AllowUserToResizeColumns = false;
            this.dgvComputers.AllowUserToResizeRows = false;
            this.dgvComputers.AutoGenerateColumns = false;
            this.dgvComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComputers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientNameDataGridViewTextBoxColumn,
            this.Date,
            this.computerTypeDataGridViewTextBoxColumn,
            this.operativeSystemDataGridViewTextBoxColumn,
            this.computerProcessorDataGridViewTextBoxColumn,
            this.computerRAMDataGridViewTextBoxColumn,
            this.computerHardDiskDataGridViewTextBoxColumn,
            this.computerGraphicCardDataGridViewTextBoxColumn,
            this.descDataGridViewTextBoxColumn,
            this.computerStateDataGridViewTextBoxColumn});
            this.dgvComputers.DataSource = this.computerBindingSource;
            this.dgvComputers.Location = new System.Drawing.Point(0, 83);
            this.dgvComputers.Name = "dgvComputers";
            this.dgvComputers.ReadOnly = true;
            this.dgvComputers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvComputers.Size = new System.Drawing.Size(1094, 405);
            this.dgvComputers.TabIndex = 0;
            this.dgvComputers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComputers_CellClick);
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Nombre del cliente";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clientNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clientNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Fecha de alta";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 130;
            // 
            // computerTypeDataGridViewTextBoxColumn
            // 
            this.computerTypeDataGridViewTextBoxColumn.DataPropertyName = "ComputerType";
            this.computerTypeDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.computerTypeDataGridViewTextBoxColumn.Name = "computerTypeDataGridViewTextBoxColumn";
            this.computerTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.computerTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.computerTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // operativeSystemDataGridViewTextBoxColumn
            // 
            this.operativeSystemDataGridViewTextBoxColumn.DataPropertyName = "OperativeSystem";
            this.operativeSystemDataGridViewTextBoxColumn.HeaderText = "Sistema operativo";
            this.operativeSystemDataGridViewTextBoxColumn.Name = "operativeSystemDataGridViewTextBoxColumn";
            this.operativeSystemDataGridViewTextBoxColumn.ReadOnly = true;
            this.operativeSystemDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.operativeSystemDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // computerProcessorDataGridViewTextBoxColumn
            // 
            this.computerProcessorDataGridViewTextBoxColumn.DataPropertyName = "ComputerProcessor";
            this.computerProcessorDataGridViewTextBoxColumn.HeaderText = "Procesador";
            this.computerProcessorDataGridViewTextBoxColumn.Name = "computerProcessorDataGridViewTextBoxColumn";
            this.computerProcessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.computerProcessorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.computerProcessorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // computerRAMDataGridViewTextBoxColumn
            // 
            this.computerRAMDataGridViewTextBoxColumn.DataPropertyName = "ComputerRAM";
            this.computerRAMDataGridViewTextBoxColumn.HeaderText = "RAM";
            this.computerRAMDataGridViewTextBoxColumn.Name = "computerRAMDataGridViewTextBoxColumn";
            this.computerRAMDataGridViewTextBoxColumn.ReadOnly = true;
            this.computerRAMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.computerRAMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // computerHardDiskDataGridViewTextBoxColumn
            // 
            this.computerHardDiskDataGridViewTextBoxColumn.DataPropertyName = "ComputerHardDisk";
            this.computerHardDiskDataGridViewTextBoxColumn.HeaderText = "Disco duro";
            this.computerHardDiskDataGridViewTextBoxColumn.Name = "computerHardDiskDataGridViewTextBoxColumn";
            this.computerHardDiskDataGridViewTextBoxColumn.ReadOnly = true;
            this.computerHardDiskDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.computerHardDiskDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // computerGraphicCardDataGridViewTextBoxColumn
            // 
            this.computerGraphicCardDataGridViewTextBoxColumn.DataPropertyName = "ComputerGraphicCard";
            this.computerGraphicCardDataGridViewTextBoxColumn.HeaderText = "Placa de video";
            this.computerGraphicCardDataGridViewTextBoxColumn.Name = "computerGraphicCardDataGridViewTextBoxColumn";
            this.computerGraphicCardDataGridViewTextBoxColumn.ReadOnly = true;
            this.computerGraphicCardDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.computerGraphicCardDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descDataGridViewTextBoxColumn
            // 
            this.descDataGridViewTextBoxColumn.DataPropertyName = "Desc";
            this.descDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            this.descDataGridViewTextBoxColumn.ReadOnly = true;
            this.descDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // computerStateDataGridViewTextBoxColumn
            // 
            this.computerStateDataGridViewTextBoxColumn.DataPropertyName = "ComputerState";
            this.computerStateDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.computerStateDataGridViewTextBoxColumn.Name = "computerStateDataGridViewTextBoxColumn";
            this.computerStateDataGridViewTextBoxColumn.ReadOnly = true;
            this.computerStateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.computerStateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataSource = typeof(Entities.Computer);
            // 
            // btnDeliver
            // 
            this.btnDeliver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnDeliver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeliver.FlatAppearance.BorderSize = 0;
            this.btnDeliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliver.ForeColor = System.Drawing.Color.White;
            this.btnDeliver.Location = new System.Drawing.Point(12, 494);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(235, 43);
            this.btnDeliver.TabIndex = 1;
            this.btnDeliver.Text = "Enviar al técnico";
            this.btnDeliver.UseVisualStyleBackColor = false;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnClose.Location = new System.Drawing.Point(849, 494);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(235, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(566, 494);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(235, 43);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(175)))), ((int)(((byte)(214)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(292, 494);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(235, 43);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Modificar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbShow
            // 
            this.cmbShow.BackColor = System.Drawing.Color.White;
            this.cmbShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbShow.FormattingEnabled = true;
            this.cmbShow.Items.AddRange(new object[] {
            "Recibidas",
            "Por reparar",
            "Reparadas",
            "Por entregar",
            "Devueltas",
            "Todas"});
            this.cmbShow.Location = new System.Drawing.Point(914, 34);
            this.cmbShow.Name = "cmbShow";
            this.cmbShow.Size = new System.Drawing.Size(168, 21);
            this.cmbShow.TabIndex = 9;
            this.cmbShow.SelectedIndexChanged += new System.EventHandler(this.cmbShow_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(910, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filtrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bandeja de entrada Recepcionista";
            // 
            // desktopBindingSource
            // 
            this.desktopBindingSource.DataSource = typeof(Entities.Desktop);
            // 
            // notebookBindingSource
            // 
            this.notebookBindingSource.DataSource = typeof(Entities.Notebook);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbShow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 71);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 476);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1095, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 476);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 546);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1094, 1);
            this.panel4.TabIndex = 13;
            // 
            // FrmRecepcionistComputers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1096, 547);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.dgvComputers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRecepcionistComputers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de computadoras";
            this.Load += new System.EventHandler(this.FrmRecepcionistComputers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desktopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComputers;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cmbShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource computerBindingSource;
        private System.Windows.Forms.BindingSource desktopBindingSource;
        private System.Windows.Forms.BindingSource notebookBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operativeSystemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerProcessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerRAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerHardDiskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerGraphicCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerStateDataGridViewTextBoxColumn;
    }
}
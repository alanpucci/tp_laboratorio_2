
namespace FrmPrincipal
{
    partial class FrmTechnicalComputers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbShow = new System.Windows.Forms.ComboBox();
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComputers
            // 
            this.dgvComputers.AllowUserToAddRows = false;
            this.dgvComputers.AutoGenerateColumns = false;
            this.dgvComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dgvComputers.Location = new System.Drawing.Point(0, 82);
            this.dgvComputers.Name = "dgvComputers";
            this.dgvComputers.ReadOnly = true;
            this.dgvComputers.Size = new System.Drawing.Size(1113, 416);
            this.dgvComputers.TabIndex = 1;
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
            this.operativeSystemDataGridViewTextBoxColumn.Width = 120;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bandeja de entrada Técnico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(929, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mostrar";
            // 
            // cmbShow
            // 
            this.cmbShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShow.FormattingEnabled = true;
            this.cmbShow.Items.AddRange(new object[] {
            "Por reparar",
            "Reparadas",
            "Ambas"});
            this.cmbShow.Location = new System.Drawing.Point(932, 29);
            this.cmbShow.Name = "cmbShow";
            this.cmbShow.Size = new System.Drawing.Size(171, 21);
            this.cmbShow.TabIndex = 6;
            this.cmbShow.SelectedIndexChanged += new System.EventHandler(this.cmbShow_SelectedIndexChanged);
            // 
            // btnRepair
            // 
            this.btnRepair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnRepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepair.ForeColor = System.Drawing.Color.White;
            this.btnRepair.Location = new System.Drawing.Point(12, 504);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(235, 43);
            this.btnRepair.TabIndex = 7;
            this.btnRepair.Text = "Reparar";
            this.btnRepair.UseVisualStyleBackColor = false;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // btnDeliver
            // 
            this.btnDeliver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeliver.Enabled = false;
            this.btnDeliver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliver.ForeColor = System.Drawing.Color.White;
            this.btnDeliver.Location = new System.Drawing.Point(442, 504);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(235, 43);
            this.btnDeliver.TabIndex = 8;
            this.btnDeliver.Text = "Entregar";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnClose.Location = new System.Drawing.Point(868, 504);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(235, 43);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbShow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 68);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 561);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 1);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 493);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1114, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 493);
            this.panel4.TabIndex = 13;
            // 
            // FrmTechnicalComputers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 562);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.dgvComputers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTechnicalComputers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tecnico";
            this.Load += new System.EventHandler(this.FrmTechnical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComputers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbShow;
        private System.Windows.Forms.BindingSource computerBindingSource;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.Button btnClose;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
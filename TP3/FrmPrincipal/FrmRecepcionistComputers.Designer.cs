
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
            this.btnDeliver = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbShow = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operativeSystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerProcessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerRAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerHardDiskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerGraphicCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComputers
            // 
            this.dgvComputers.AllowUserToAddRows = false;
            this.dgvComputers.AutoGenerateColumns = false;
            this.dgvComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientNameDataGridViewTextBoxColumn,
            this.operativeSystemDataGridViewTextBoxColumn,
            this.computerTypeDataGridViewTextBoxColumn,
            this.computerProcessorDataGridViewTextBoxColumn,
            this.computerRAMDataGridViewTextBoxColumn,
            this.computerHardDiskDataGridViewTextBoxColumn,
            this.descDataGridViewTextBoxColumn,
            this.computerStateDataGridViewTextBoxColumn,
            this.computerGraphicCardDataGridViewTextBoxColumn});
            this.dgvComputers.DataSource = this.computerBindingSource;
            this.dgvComputers.Location = new System.Drawing.Point(12, 48);
            this.dgvComputers.Name = "dgvComputers";
            this.dgvComputers.ReadOnly = true;
            this.dgvComputers.Size = new System.Drawing.Size(1038, 416);
            this.dgvComputers.TabIndex = 0;
            // 
            // btnDeliver
            // 
            this.btnDeliver.Location = new System.Drawing.Point(11, 470);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(235, 43);
            this.btnDeliver.TabIndex = 1;
            this.btnDeliver.Text = "Enviar al técnico";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(814, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(235, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(540, 470);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(235, 43);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(276, 470);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(235, 43);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Modificar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbShow
            // 
            this.cmbShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShow.FormattingEnabled = true;
            this.cmbShow.Items.AddRange(new object[] {
            "Todas",
            "Recibidas",
            "Por reparar",
            "Reparadas",
            "Por entregar",
            "Devueltas"});
            this.cmbShow.Location = new System.Drawing.Point(929, 21);
            this.cmbShow.Name = "cmbShow";
            this.cmbShow.Size = new System.Drawing.Size(121, 21);
            this.cmbShow.TabIndex = 9;
            this.cmbShow.SelectedIndexChanged += new System.EventHandler(this.cmbShow_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(926, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mostrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bandeja de entrada Recepcionista";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Entities.User);
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataSource = typeof(Entities.Computer);
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
            // operativeSystemDataGridViewTextBoxColumn
            // 
            this.operativeSystemDataGridViewTextBoxColumn.DataPropertyName = "OperativeSystem";
            this.operativeSystemDataGridViewTextBoxColumn.HeaderText = "Sistema operativo";
            this.operativeSystemDataGridViewTextBoxColumn.Name = "operativeSystemDataGridViewTextBoxColumn";
            this.operativeSystemDataGridViewTextBoxColumn.ReadOnly = true;
            this.operativeSystemDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.operativeSystemDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // computerGraphicCardDataGridViewTextBoxColumn
            // 
            this.computerGraphicCardDataGridViewTextBoxColumn.DataPropertyName = "ComputerGraphicCard";
            this.computerGraphicCardDataGridViewTextBoxColumn.HeaderText = "Placa de video";
            this.computerGraphicCardDataGridViewTextBoxColumn.Name = "computerGraphicCardDataGridViewTextBoxColumn";
            this.computerGraphicCardDataGridViewTextBoxColumn.ReadOnly = true;
            this.computerGraphicCardDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.computerGraphicCardDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmRecepcionistComputers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 526);
            this.Controls.Add(this.cmbShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.dgvComputers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRecepcionistComputers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de computadoras";
            this.Load += new System.EventHandler(this.FrmRecepcionistComputers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComputers;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cmbShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operativeSystemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerProcessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerRAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerHardDiskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerGraphicCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource computerBindingSource;
    }
}
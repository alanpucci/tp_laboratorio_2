
namespace FrmPrincipal
{
    partial class FrmComputer
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
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbOS = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHardDisk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRAM = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProcessor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGraphicCard = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.chkAccesory2 = new System.Windows.Forms.CheckBox();
            this.chkAccesory1 = new System.Windows.Forms.CheckBox();
            this.cmbExtra = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(18, 131);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(191, 20);
            this.txtClientName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de computadora";
            // 
            // cmbType
            // 
            this.cmbType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(41, 227);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbOS
            // 
            this.cmbOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOS.Enabled = false;
            this.cmbOS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbOS.FormattingEnabled = true;
            this.cmbOS.Location = new System.Drawing.Point(41, 299);
            this.cmbOS.Name = "cmbOS";
            this.cmbOS.Size = new System.Drawing.Size(121, 21);
            this.cmbOS.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sistema operativo";
            // 
            // cmbHardDisk
            // 
            this.cmbHardDisk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbHardDisk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHardDisk.Enabled = false;
            this.cmbHardDisk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbHardDisk.FormattingEnabled = true;
            this.cmbHardDisk.Location = new System.Drawing.Point(41, 371);
            this.cmbHardDisk.Name = "cmbHardDisk";
            this.cmbHardDisk.Size = new System.Drawing.Size(121, 21);
            this.cmbHardDisk.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tamaño del disco";
            // 
            // cmbRAM
            // 
            this.cmbRAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRAM.Enabled = false;
            this.cmbRAM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbRAM.FormattingEnabled = true;
            this.cmbRAM.Location = new System.Drawing.Point(238, 371);
            this.cmbRAM.Name = "cmbRAM";
            this.cmbRAM.Size = new System.Drawing.Size(121, 21);
            this.cmbRAM.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Memoria RAM";
            // 
            // cmbProcessor
            // 
            this.cmbProcessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProcessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcessor.Enabled = false;
            this.cmbProcessor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbProcessor.FormattingEnabled = true;
            this.cmbProcessor.Location = new System.Drawing.Point(238, 227);
            this.cmbProcessor.Name = "cmbProcessor";
            this.cmbProcessor.Size = new System.Drawing.Size(121, 21);
            this.cmbProcessor.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Procesador";
            // 
            // cmbGraphicCard
            // 
            this.cmbGraphicCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGraphicCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGraphicCard.Enabled = false;
            this.cmbGraphicCard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbGraphicCard.FormattingEnabled = true;
            this.cmbGraphicCard.Location = new System.Drawing.Point(238, 299);
            this.cmbGraphicCard.Name = "cmbGraphicCard";
            this.cmbGraphicCard.Size = new System.Drawing.Size(121, 21);
            this.cmbGraphicCard.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tarjeta gráfica";
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(12, 444);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(543, 129);
            this.rtbDesc.TabIndex = 10;
            this.rtbDesc.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Descripción";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblExtra);
            this.groupBox1.Controls.Add(this.chkAccesory2);
            this.groupBox1.Controls.Add(this.chkAccesory1);
            this.groupBox1.Controls.Add(this.cmbExtra);
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 237);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Componentes";
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(413, 24);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(0, 13);
            this.lblExtra.TabIndex = 19;
            // 
            // chkAccesory2
            // 
            this.chkAccesory2.AutoSize = true;
            this.chkAccesory2.Location = new System.Drawing.Point(416, 194);
            this.chkAccesory2.Name = "chkAccesory2";
            this.chkAccesory2.Size = new System.Drawing.Size(15, 14);
            this.chkAccesory2.TabIndex = 9;
            this.chkAccesory2.UseVisualStyleBackColor = true;
            this.chkAccesory2.Visible = false;
            // 
            // chkAccesory1
            // 
            this.chkAccesory1.AutoSize = true;
            this.chkAccesory1.Location = new System.Drawing.Point(416, 126);
            this.chkAccesory1.Name = "chkAccesory1";
            this.chkAccesory1.Size = new System.Drawing.Size(15, 14);
            this.chkAccesory1.TabIndex = 8;
            this.chkAccesory1.UseVisualStyleBackColor = true;
            this.chkAccesory1.Visible = false;
            // 
            // cmbExtra
            // 
            this.cmbExtra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExtra.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbExtra.FormattingEnabled = true;
            this.cmbExtra.Location = new System.Drawing.Point(416, 50);
            this.cmbExtra.Name = "cmbExtra";
            this.cmbExtra.Size = new System.Drawing.Size(121, 21);
            this.cmbExtra.TabIndex = 7;
            this.cmbExtra.Visible = false;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(41, 579);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(188, 43);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnCancel.Location = new System.Drawing.Point(336, 579);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(188, 43);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 77);
            this.panel1.TabIndex = 17;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(27, 44);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 18;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 31);
            this.lblTitle.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 563);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(566, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 563);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(4, 636);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(562, 4);
            this.panel4.TabIndex = 19;
            // 
            // FrmComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 640);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.cmbGraphicCard);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbProcessor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbRAM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbHardDisk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario computadora";
            this.Load += new System.EventHandler(this.FrmAddComputer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHardDisk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRAM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProcessor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGraphicCard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkAccesory2;
        private System.Windows.Forms.CheckBox chkAccesory1;
        private System.Windows.Forms.ComboBox cmbExtra;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
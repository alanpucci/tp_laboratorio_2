
namespace FrmPrincipal
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.btnAddComputer = new System.Windows.Forms.Button();
            this.btnListComputers = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddComputer = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddComputer
            // 
            this.btnAddComputer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddComputer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddComputer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddComputer.Image")));
            this.btnAddComputer.Location = new System.Drawing.Point(550, 127);
            this.btnAddComputer.Name = "btnAddComputer";
            this.btnAddComputer.Size = new System.Drawing.Size(146, 139);
            this.btnAddComputer.TabIndex = 3;
            this.btnAddComputer.UseVisualStyleBackColor = false;
            this.btnAddComputer.Click += new System.EventHandler(this.btnAddComputer_Click);
            // 
            // btnListComputers
            // 
            this.btnListComputers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnListComputers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListComputers.Image = ((System.Drawing.Image)(resources.GetObject("btnListComputers.Image")));
            this.btnListComputers.Location = new System.Drawing.Point(305, 127);
            this.btnListComputers.Name = "btnListComputers";
            this.btnListComputers.Size = new System.Drawing.Size(146, 139);
            this.btnListComputers.TabIndex = 2;
            this.btnListComputers.UseVisualStyleBackColor = false;
            this.btnListComputers.Click += new System.EventHandler(this.btnListComputers_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(334, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Bienvenido al sistema, ";
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.Location = new System.Drawing.Point(44, 127);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(146, 139);
            this.btnUser.TabIndex = 1;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Modificar usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista de computadoras";
            // 
            // lblAddComputer
            // 
            this.lblAddComputer.AutoSize = true;
            this.lblAddComputer.Location = new System.Drawing.Point(573, 269);
            this.lblAddComputer.Name = "lblAddComputer";
            this.lblAddComputer.Size = new System.Drawing.Size(103, 13);
            this.lblAddComputer.TabIndex = 7;
            this.lblAddComputer.Text = "Cargar computadora";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(15, 80);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 65);
            this.panel1.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnClose.Location = new System.Drawing.Point(607, 299);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 41);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Cerrar sesión";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 287);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(758, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 287);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 351);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(757, 1);
            this.panel4.TabIndex = 12;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 352);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAddComputer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnAddComputer);
            this.Controls.Add(this.btnListComputers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRecepcionist_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRecepcionist_FormClosed);
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListComputers;
        private System.Windows.Forms.Button btnAddComputer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAddComputer;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
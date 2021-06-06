
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
            this.SuspendLayout();
            // 
            // btnAddComputer
            // 
            this.btnAddComputer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddComputer.Image")));
            this.btnAddComputer.Location = new System.Drawing.Point(89, 128);
            this.btnAddComputer.Name = "btnAddComputer";
            this.btnAddComputer.Size = new System.Drawing.Size(146, 139);
            this.btnAddComputer.TabIndex = 2;
            this.btnAddComputer.UseVisualStyleBackColor = true;
            this.btnAddComputer.Click += new System.EventHandler(this.btnAddComputer_Click);
            // 
            // btnListComputers
            // 
            this.btnListComputers.Image = ((System.Drawing.Image)(resources.GetObject("btnListComputers.Image")));
            this.btnListComputers.Location = new System.Drawing.Point(330, 128);
            this.btnListComputers.Name = "btnListComputers";
            this.btnListComputers.Size = new System.Drawing.Size(146, 139);
            this.btnListComputers.TabIndex = 1;
            this.btnListComputers.UseVisualStyleBackColor = true;
            this.btnListComputers.Click += new System.EventHandler(this.btnListComputers_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddComputer);
            this.Controls.Add(this.btnListComputers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRecepcionist_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRecepcionist_FormClosed);
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListComputers;
        private System.Windows.Forms.Button btnAddComputer;
    }
}
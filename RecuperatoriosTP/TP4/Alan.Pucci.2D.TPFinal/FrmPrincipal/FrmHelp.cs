﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmHelp : Form
    {
        /// <summary>
        /// Initialize the text to show
        /// </summary>
        /// <param name="text">Text to show</param>
        public FrmHelp(string text)
        {
            InitializeComponent();
            this.lblHelp.Text = text;
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

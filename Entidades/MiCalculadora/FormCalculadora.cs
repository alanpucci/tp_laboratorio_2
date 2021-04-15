﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero primerNumero = new Numero(numero1);
            Numero segundoNumero = new Numero(numero2);
            return Calculadora.Operar(primerNumero, segundoNumero, operador);
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.SelectedIndex = 0;
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirABinario.Enabled = false;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if(this.txtNumero1.Text == "" || this.txtNumero2.Text == "")
            {
                MessageBox.Show("Debes tener todos los campos llenos para operar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string resultado = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
            if (resultado == double.MinValue.ToString())
            {
                MessageBox.Show("No se puede dividir por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.lblResultado.Text = "Error";
                return;
            }
            this.lblResultado.Text = resultado;
            this.btnConvertirABinario.Enabled = true;
            this.btnConvertirADecimal.Enabled = false;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = string.Empty;
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirABinario.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != "")
            {
                Numero numero = new Numero();
                this.lblResultado.Text = numero.DecimalBinario(this.lblResultado.Text);
                this.btnConvertirADecimal.Enabled = true;
                this.btnConvertirABinario.Enabled = false;
            }

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            this.lblResultado.Text = numero.BinarioDecimal(this.lblResultado.Text);
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirABinario.Enabled = true;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro que querés cerrar la calculadora?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtNumero1_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod || (e.Control && e.KeyCode == Keys.V)) && (this.txtNumero1.Text.Contains(',') || this.txtNumero1.Text.Contains('.')))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtNumero2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod || (e.Control && e.KeyCode == Keys.V)) && (this.txtNumero2.Text.Contains(',') || this.txtNumero2.Text.Contains('.')))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
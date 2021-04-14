using System;
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

        public static double Operar(string numero1, string numero2, string operador)
        {
            Numero primerNumero = new Numero(numero1);
            Numero segundoNumero = new Numero(numero2);
            return Calculadora.Operar(primerNumero, segundoNumero, operador);
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.SelectedIndex = 0;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if(txtNumero1.Text == "" || txtNumero2.Text == "" || cmbOperador.SelectedIndex == -1)
            {
                MessageBox.Show("Debes tener todos los campos llenos para operar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string resultado = FormCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.SelectedItem.ToString()).ToString();
            if(resultado == double.MinValue.ToString())
            {
                MessageBox.Show("No se puede dividir por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultado.Text = "Error";
                return;
            }
            lblResultado.Text = resultado;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            cmbOperador.SelectedIndex = 0;
            lblResultado.Text = string.Empty;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro que querés cerrar la calculadora?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

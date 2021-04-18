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
        
        /// <summary>
        /// Constructor del form, instancia todos sus atributos
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Recibe dos numeros y un operador, realiza el calculo correspondiente al operador
        /// </summary>
        /// <param name="numero1">Primer numero a operar</param>
        /// <param name="numero2">Segundo numero a operar</param>
        /// <param name="operador">Operador a utilizar</param>
        /// <returns>Retorna el resultado en double</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero primerNumero = new Numero(numero1);
            Numero segundoNumero = new Numero(numero2);
            return Calculadora.Operar(primerNumero, segundoNumero, operador);
        }

        /// <summary>
        /// Inicializa el combobox en la posicion de la suma y deshabilita los botones de conversion
        /// </summary>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.SelectedIndex = 0;
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirABinario.Enabled = false;
        }

        /// <summary>
        /// Boton "Operar", realiza el calculo correspondiente
        /// </summary>
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
                this.btnConvertirABinario.Enabled = false;
                this.btnConvertirADecimal.Enabled = false;
                return;
            }
            this.lblResultado.Text = resultado;
            this.btnConvertirABinario.Enabled = true;
            this.btnConvertirADecimal.Enabled = false;

        }

        /// <summary>
        /// Boton "Limpiar", vacia los inputs, label de resultado y coloca al combobox por defecto (suma)
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.lblResultado.Text = string.Empty;
            this.cmbOperador.SelectedIndex = 0;
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirABinario.Enabled = false;
        }

        /// <summary>
        /// Boton "Cerrar", cierra la aplicacion
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Boton "Convertir a binario", convierte el resultado (decimal) a binario
        /// </summary>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != "")
            {
                Numero numero = new Numero();
                this.lblResultado.Text = numero.DecimalBinario(this.lblResultado.Text);
                if(this.lblResultado.Text != "Valor invalido")
                {
                    this.btnConvertirADecimal.Enabled = true;
                }
                this.btnConvertirABinario.Enabled = false;
            }

        }

        /// <summary>
        /// Boton "Convertir a decimal", convierte el resultado (binario) a decimal
        /// </summary>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            this.lblResultado.Text = numero.BinarioDecimal(this.lblResultado.Text);
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirABinario.Enabled = true;
        }

        /// <summary>
        /// Metodo que es llamado cuando se quiere cerrar la aplicacion
        /// </summary>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro que querés cerrar la calculadora?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Validacion del primer TextBox, impide el ingreso de letras y el reingreso de alguna , (coma) o . (punto)
        /// </summary>
        private void txtNumero1_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Oemcomma) && (this.txtNumero1.Text.Contains(',') || this.txtNumero1.Text.Contains('.')))
            {
                e.SuppressKeyPress = true;
            }
        }

        /// <summary>
        /// Validacion del segundo TextBox, impide el ingreso de letras y el reingreso de alguna , (coma) o . (punto)
        /// </summary>
        private void txtNumero2_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.GetData(this.lblResultado.Text);
            if ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Oemcomma) && (this.txtNumero2.Text.Contains(',') || this.txtNumero2.Text.Contains('.')))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Constructor por defecto, inicializa 'numero' en 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Inicializa 'numero' con el argumento recibido en formato double
        /// </summary>
        /// <param name="numero">Numero a asignar al atributo numero</param>
        public Numero(double numero): this()
        {
            this.numero = numero;
        }

        /// <summary>
        /// Convierte el string recibido en formato double e inicializa 'numero'
        /// </summary>
        /// <param name="numero">String a convertir y asignar al atributo numero</param>
        public Numero(string numero):this()
        {
            this.SetNumero = numero;
        }

        /// <summary>
        /// Propiedad que asigna un valor a 'numero'
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }

        /// <summary>
        /// Valida si el string recibido corresponde a un valor numerico
        /// </summary>
        /// <param name="strNumero">String a validar</param>
        /// <returns>Retorna el numero en formato double o 0 en caso que el string no fuera un numero</returns>
        private double ValidarNumero(string strNumero)
        {
            double.TryParse(strNumero.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), out double bufferDouble);
            return bufferDouble;
        }

        /// <summary>
        /// Valida que la cadena de caracteres este compuesta solo por 0 o 1
        /// </summary>
        /// <param name="binario">String a validar</param>
        /// <returns>Retorna true en caso que tenga 0 o 1 o false en caso contrario</returns>
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Convierte el resultado de binario a decimal
        /// </summary>
        /// <param name="valor">Resultado (en string) a convertir</param>
        /// <returns>El valor convertido a decimal</returns>
        public string BinarioDecimal(string valor)
        {
            if (this.EsBinario(valor))
            {
                int acumulador = 0;
                for (int i = 0; i < valor.Length; i++)
                {
                    if (valor[i] != '0')
                    {
                        acumulador += (int)Math.Pow(2, (valor.Length - i - 1));
                    }
                }
                return acumulador.ToString();
            }
            return "Valor invalido";
        }

        /// <summary>
        /// Convierte el resultado de decimal a binario
        /// </summary>
        /// <param name="numero">Resultado (en double) a convertir</param>
        /// <returns>El valor convertido a binario</returns>
        public string DecimalBinario(double numero)
        {
            string numeroBinario = "";
            int bufferInt = Math.Abs((int)numero);
            while (bufferInt / 2 != 0)
            {
                numeroBinario = (bufferInt % 2).ToString() + numeroBinario;
                bufferInt = bufferInt / 2;
            }
            numeroBinario = (bufferInt % 2).ToString() + numeroBinario;
            return numeroBinario;
        }

        /// <summary>
        /// Convierte el resultado de decimal a binario
        /// </summary>
        /// <param name="numero">Resultado (en string) a convertir</param>
        /// <returns>El valor convertido a binario</returns>
        public string DecimalBinario(string numero)
        {
            if(double.TryParse(numero, out double bufferDouble) && bufferDouble < int.MaxValue)
            {
                return this.DecimalBinario(bufferDouble);
            }
            return "Valor invalido";
        }

        /// <summary>
        /// Sobrecarga de operador +, realiza la suma entre 2 numeros
        /// </summary>
        /// <param name="num1">Primer numero a sumar</param>
        /// <param name="num2">Segundo numero a sumar</param>
        /// <returns>Resultado en double</returns>
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// Sobrecarga de operador -, realiza la resta entre 2 numeros
        /// </summary>
        /// <param name="num1">Primer numero a restar</param>
        /// <param name="num2">Segundo numero a restar</param>
        /// <returns>Resultado en double</returns>
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// Sobrecarga de operador *, realiza la multiplicacion entre 2 numeros
        /// </summary>
        /// <param name="num1">Primer numero a multiplicar</param>
        /// <param name="num2">Segundo numero a multiplicar</param>
        /// <returns>Resultado en double</returns>
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// Sobrecarga de operador /, realiza la division entre 2 numeros
        /// </summary>
        /// <param name="num1">Primer numero a dividir</param>
        /// <param name="num2">Segundo numero a dividir</param>
        /// <returns>Resultado en double. Si el segundo numero es 0, retornara el valor minimo de un double</returns>
        public static double operator /(Numero num1, Numero num2)
        {
            if(num2.numero != 0)
            {
                return num1.numero / num2.numero;
            }
            return double.MinValue;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            this.SetNumero = numero;
        }


        public string SetNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }

        private double ValidarNumero(string strNumero)
        {
            double bufferDouble;
            if (double.TryParse(strNumero.Replace(",","."), out bufferDouble))
            {
                return bufferDouble;
            }
            return 0;
        }

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

        public string DecimalBinario(double numero)
        {
            string numeroBinario = "";
            int bufferInt = (int)numero;
            while (bufferInt / 2 != 0)
            {
                numeroBinario = (bufferInt % 2).ToString() + numeroBinario;
                bufferInt = bufferInt / 2;
            }
            numeroBinario = (bufferInt % 2).ToString() + numeroBinario;
            return numeroBinario;
        }

        public string DecimalBinario(string numero)
        {
            double bufferDouble;
            if (double.TryParse(numero, out bufferDouble))
            {
                return this.DecimalBinario(bufferDouble);

            }
            return "Valor invalido";
        }


        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

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

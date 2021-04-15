using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static string ValidarOperador(char operador)
        {
            if(operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador.ToString();
            }
            return "+";
        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno=0;
            string bufferOperador = ValidarOperador(char.Parse(operador));
            switch (bufferOperador)
            {
                case "+":
                    retorno = num1 + num2;
                    break;
                case "-":
                    retorno = num1 - num2;
                    break;
                case "*":
                    retorno = num1 * num2;
                    break;
                case "/":
                    retorno = num1 / num2;
                    break;
                default:
                    break;
            }
            if(retorno > double.MaxValue)
            {
                retorno = double.MaxValue;
            }
            return Math.Round(retorno,4);
        }
    }
}

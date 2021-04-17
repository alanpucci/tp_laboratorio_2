using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que el operador recibido sea +, -, / p *
        /// </summary>
        /// <param name="operador">Operador en forma de char</param>
        /// <returns>Retorna el operador validado convertido en string, de no ser ninguno de los mencionados retornara +</returns>
        private static string ValidarOperador(char operador)
        {
            if(operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador.ToString();
            }
            return "+";
        }

        /// <summary>
        /// Recibe dos numeros y hace el calculo correspondiente (suma, resta, division o multiplicacion)
        /// </summary>
        /// <param name="num1">Primer numero</param>
        /// <param name="num2">Segundo numero</param>
        /// <param name="operador">Operador a utilizar</param>
        /// <returns>Retorna resultado con 4 decimales</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno=0;
            char bufferChar = operador != "" ? char.Parse(operador) : '+';
            string bufferOperador = ValidarOperador(bufferChar);
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
            }
            return Math.Round(retorno,4);
        }
    }
}

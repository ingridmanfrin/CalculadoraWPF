using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraWPF.Model
{
    internal class CalculoRequest
    {
        public double Numerador { get; set; }
        public double Denominador { get; set; }
        public string Operador { get; set; }

        public CalculoRequest(double numerador, double denominador, string operador)
        {
            Numerador = numerador;
            Denominador = denominador;
            Operador = operador;
        }
    }
}

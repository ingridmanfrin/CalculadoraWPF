using CalculadoraWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraWPF.Controller
{
    internal class CalculoController
    {
        public double? Calcular(CalculoRequest requisicao) // a função calcular vai receber um parâmetro do tipo CalculoRequest(que é minha model)
        {

            if (string.IsNullOrEmpty(requisicao.Operador))
            {
                return null;
            }

            double ContaFinal = 0;

            if (requisicao.Operador == "+")
            {
                ContaFinal = requisicao.Numerador + requisicao.Denominador;
            }
            else if (requisicao.Operador == "-")
            {
                ContaFinal = requisicao.Numerador - requisicao.Denominador;
            }
            else if (requisicao.Operador == "*")
            {
                ContaFinal = requisicao.Numerador * requisicao.Denominador;
            }
            else if (requisicao.Operador == "/")
            {
                ContaFinal = requisicao.Numerador / requisicao.Denominador;
            }
            
            return ContaFinal;
        }
    }
}

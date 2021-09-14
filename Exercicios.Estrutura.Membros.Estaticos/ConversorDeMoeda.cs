using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Estrutura.Membros.Estaticos
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        /// <summary> Converte Dolar para Real com desconto de IOF </summary>
        public static double DolarParaReal(double valor, double cotacao)
        {
            double imposto = (IOF / 100.0) * valor;
            double valorCorrigido = cotacao * (valor + imposto);
            return valorCorrigido;
        }
    }
}

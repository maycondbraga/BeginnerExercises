using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Estrutura.Membros.Estaticos
{
    class CalculadoraRaio
    {
        public static double Pi = 3.14;

        /// <summary> Calcula circunferência do raio </summary>
        public static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }
        public static double Volume(double raio)
        {
            return (4.0 / 3.0) * Pi * (raio * raio * raio);
        }
    }
}

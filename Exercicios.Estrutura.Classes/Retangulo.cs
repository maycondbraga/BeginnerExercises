using System;
using System.Globalization;

namespace Exercicios.Estrutura.Classes
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        /// <summary> Retorna a área do retângulo </summary>
        public double CalculaArea()
        {
            double area = Largura * Altura;
            return area;
        }

        /// <summary> Retorna o perímetro do retângulo </summary>
        public double CalculaPerimetro()
        {
            double perimetro = 2 * (Largura + Altura);
            return perimetro;
        }

        /// <summary> Retorna a diagonal do retângulo </summary>
        public double CalculaDiagonal()
        {
            double p = (Largura * Largura) + (Altura * Altura);
            double diagonal = Math.Sqrt(p);
            return diagonal;
        }

        /// <summary> Formata corretamente o objeto Retângulo </summary>
        public override string ToString()
        {
            string area = CalculaArea().ToString("F2", CultureInfo.InvariantCulture);
            string perimetro = CalculaPerimetro().ToString("F2", CultureInfo.InvariantCulture);
            string diagonal = CalculaDiagonal().ToString("F2", CultureInfo.InvariantCulture);
            return "\nÁrea = " + area + "\nPerímetro = " + perimetro + "\nDiagonal = " + diagonal;
        }
    }
}

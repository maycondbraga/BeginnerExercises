using System;

namespace Exercicios.Estrutura.Classes
{
    /// <summary>
    /// Classe Triângulo que instancia seus três lados 
    /// </summary>
    public class Triangulo
    {
        public double A;
        public double B;
        public double C;

        /// <summary> Calcula o valor P da area do triângulo </summary>
        public double CalculaArea()
        {
            double p = (A + B + C) / 2.0;
            double resolucaoP = p * (p - A) * (p - B) * (p - C);
            double area = Math.Sqrt(resolucaoP);
            return area;
        }
    }
}

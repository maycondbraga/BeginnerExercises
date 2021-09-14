using System;
using System.Globalization;

namespace Exercicios.Estrutura.Membros.Estaticos
{
    public class ExerciciosMembrosEstaticos
    {
        /// <summary> Calcula circunferência e volume baseado no Raio </summary>
        public static void Exercicio1()
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = CalculadoraRaio.Circunferencia(raio);
            double volume = CalculadoraRaio.Volume(raio);

            Console.WriteLine($"Circunferência: {circunferencia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {CalculadoraRaio.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        /// <summary> Converte Dolar para Real com desconto de IOF </summary>
        public static void Exercicio2()
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nQuantos dólares você vai comprar? ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string valorConvertido = ConversorDeMoeda.DolarParaReal(valor, cotacao).ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine($"\nValor a ser pago em reais = {valorConvertido}");
        }
    }
}

using System;
using System.Globalization;

namespace Exercicios.Estrutura.Repetitiva.For
{
    public class ExerciciosFor
    {
        /// <summary> Calcula a soma de números especificados pelo usuário </summary>
        public static void ExercicioAula34()
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int total = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int contador = 0; contador < total; contador++)
            {
                Console.Write($"{contador + 1}o. Valor = ");
                soma += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nSoma = {soma}");
        }

        /// <summary> Retorna todos os números ímpares de 1 até o número informado </summary>
        public static void Exercicio1()
        {
            bool verifica = true;
            int numero = 0;

            while (verifica)
            {
                Console.Write("\nDigite um número (entre 1 e 1000): ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 1 || numero > 1000)
                {
                    Console.WriteLine("\nNúmero inválido");
                }
                else
                {
                    verifica = false;
                }
            }

            for (int i = 1; i <= numero; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary> Retorna quantos valores estão dentro e fora do intervalo [10,20] </summary>
        public static void Exercicio2()
        {
            int acumulador, dentro = 0, fora = 0;

            Console.Write("Quantos números inteiros você vai digitar? ");
            int total = int.Parse(Console.ReadLine());

            for (int i = 0; i < total; i++)
            {
                Console.Write($"{i + 1}o. Valor = ");
                acumulador = int.Parse(Console.ReadLine());

                if (acumulador < 10 || acumulador > 20)
                {
                    fora++;
                }
                else
                {
                    dentro++;
                }

            }

            Console.WriteLine($"\n{dentro} In \n{fora} Out");
        }

        /// <summary> Retorna a média ponderada dos valores inseridos </summary>
        public static void Exercicio3()
        {
            string[] valores;
            double a, b, c, media;
            int i, total;

            Console.Write("\nQuantos números você vai digitar? ");
            total = int.Parse(Console.ReadLine());

            for (i = 0; i < total; i++)
            {
                Console.Write("\nDigite os valores: ");
                valores = Console.ReadLine().Split(" ");

                a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                c = double.Parse(valores[2], CultureInfo.InvariantCulture);

                media = (a * 0.2) + (b * 0.3) + (c * 0.5);
                Console.WriteLine($"Média ponderada = {media.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }

        /// <summary> Retorna a divisão dos números informados </summary>
        public static void Exercicio4()
        {
            Console.Write("\nQuantos números você vai digitar? ");
            int total = int.Parse(Console.ReadLine());

            for (int i = 0; i < total; i++)
            {
                Console.Write("\nDigite os valores: ");
                string[] valores = Console.ReadLine().Split(" ");

                double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valores[1], CultureInfo.InvariantCulture);

                if (b == 0.0)
                {
                    Console.WriteLine("Divisão impossivel");
                }
                else
                {
                    double resultado = (double)a / b;
                    Console.WriteLine($"{resultado.ToString("F1", CultureInfo.InvariantCulture)}");
                }
            }
        }

        /// <summary> Calcula o fatorial do número informado </summary>
        public static void Exercicio5()
        {
            Console.WriteLine("\nDigite um número:");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);
        }

        /// <summary> Retorna todos os divisores do número informado </summary>
        public static void Exercicio6()
        {
            Console.WriteLine("\nDigite um número:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// <summary> Retorna uma lista de numeros ao quadraro e ao cubo a partir do número informado </summary>
        public static void Exercicio7()
        {
            int quadrado, cubo;

            Console.WriteLine("\nDigite um número:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= numero; i++)
            {
                quadrado = i * i;
                cubo = i * i * i;
                
                Console.WriteLine($"{i} {quadrado} {cubo}");
            }
        }
    }
}
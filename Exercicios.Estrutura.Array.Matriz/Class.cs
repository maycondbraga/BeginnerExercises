using System;

namespace Exercicios.Estrutura.Array.Matriz
{
    public class ExerciciosMatriz
    {
        /// <summary> Define matriz que captura as linhas e retorna os números da diagonal e quantidade de negativos </summary>
        public static void ExercicioAula80()
        {
            Console.Write("Digite o número total da ordem da matriz: ");
            int ordemMatriz = int.Parse(Console.ReadLine());

            int[,] matriz = new int[ordemMatriz, ordemMatriz];
            int contadorColuna = matriz.GetLength(1) - 1;
            string[] numeroLinhas = { };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write($"{i + 1}a linha: ");
                numeroLinhas = Console.ReadLine().Split(" ");
                
                for (int x = 0; x <= contadorColuna; x++)
                {
                    matriz[i, x] = int.Parse(numeroLinhas[x]);
                }
            }

            System.Array.Clear(numeroLinhas, 0, numeroLinhas.Length);

            Console.WriteLine("\nMain diagonal:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                numeroLinhas[i] = matriz[i, i].ToString();
            }

            Console.WriteLine("{0}", string.Join(" ", numeroLinhas));

            int negativos = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int x = 0; x < matriz.GetLength(1); x++)
                {
                    negativos += matriz[i, x] < 0 ? 1 : 0; 
                }
            }

            Console.WriteLine("\nNegatives numbers = {0}", negativos);
        }

        /// <summary> Define matriz e retorna a posição, e elementos ao redor do número especificado </summary>
        public static void ExercicioAula81()
        {
            Console.Write("Digite o número de linhas e colunas: ");
            string[] ordemString = Console.ReadLine().Split(" ");
            int[] ordemInt = System.Array.ConvertAll(ordemString, int.Parse);

            int[,] matriz = new int[ordemInt[0], ordemInt[1]];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write($"{i + 1}a linha: ");
                ordemString = Console.ReadLine().Split(" ");

                for (int x = 0; x <= (matriz.GetLength(1) - 1); x++)
                {
                    matriz[i, x] = int.Parse(ordemString[x]);
                }
            }

            Console.Write("\nDigite o número: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int x = 0; x < matriz.GetLength(1); x++)
                {
                    if (matriz[i, x] == numero)
                    {
                        Console.WriteLine($"\nPosition [{i},{x}]:");

                        if (x > 0)
                        {
                            Console.WriteLine($"Left: {matriz[i, x - 1]}");
                        }
                        if (x != (matriz.GetLength(1) - 1))
                        {
                            Console.WriteLine($"Right: {matriz[i, x + 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {matriz[i - 1, x]}");
                        }
                        if (i != (matriz.GetLength(0) - 1))
                        {
                            Console.WriteLine($"Down: {matriz[i + 1, x]}");
                        }
                    }
                }
            }
        }
    }
}
using System;

namespace Exercicios.Estrutura.Array.Vetor
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        /// <summary> Adiciona um objeto Quarto para o Array </summary>
        public static void AdicionaQuarto(Quarto[] quartos)
        {
            Console.Write("\nName: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Room: ");
            int numeroQuarto = int.Parse(Console.ReadLine());

            quartos[numeroQuarto] = new Quarto { Nome = nome, Email = email };
        }

        /// <summary> Limpa o objeto Quarto no index definido </summary>
        public static void DesocupaQuarto(Quarto[] quartos, int numeroQuarto)
        {
            quartos[numeroQuarto] = null;
        }

        /// <summary> Detalha o Array de objeto Quarto </summary>
        public static void DetalhesQuarto(Quarto[] quartos)
        {
            Console.WriteLine("\nQuartos:\n");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"{i}: {quartos[i].Nome}, {quartos[i].Email}");
                }
                else
                {
                    Console.WriteLine($"{i}: Vazio");
                }
            }
        }
    }
}
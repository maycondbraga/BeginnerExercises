using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicios.Estrutura.Array.Vetor
{
    public class ExerciciosVetor
    {
        /// <summary> Calcula a média de alturas definidas </summary>
        public static void ExercicioAula69()
        {
            Console.Write("Digite o número de pessoas: ");
            int total = int.Parse(Console.ReadLine());

            double[] alturas = new double[total];
            double media = 0;

            for (int i= 0; i < total; i++)
            {
                Console.Write("Digite a altura: ");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                alturas[i] = altura;
            }

            for (int i = 0; i < total; i++)
            {
                media += alturas[i];
            }

            media /= total;
            Console.WriteLine($"\nAverage Height = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        /// <summary> Calcula a média de preços entre os produtos </summary>
        public static void ExercicioAula70()
        {
            Console.Write("Digite o número de produtos: ");
            int total = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[total];
            double media = 0;

            for (int i = 0; i < total; i++)
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produtos[i] = new Produto { Nome = nome, Preco = preco };
            }

            for (int i = 0; i < total; i++)
            {
                media += produtos[i].Preco;
            }

            media /= total;
            Console.WriteLine($"\nAverage Price = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        /// <summary> Permite acrescentar inquilinos a quartos de uma pensão </summary>
        public static void Exercicio1()
        {
            Quarto[] quartos = new Quarto[10];

            Console.Write("How many rooms will be rented? ");
            int total = int.Parse(Console.ReadLine());

            for (int i = 0; i < total; i++)
            {
                Console.Write($"\nRent #{i + 1}:");
                
                Console.Write("\nName: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Quarto { Nome = nome, Email = email };
            }

            Console.WriteLine("\nBusy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"{i}: {quartos[i].Nome}, {quartos[i].Email}");
                }
            }
        }

        /// <summary> Permite acrescentar inquilinos a quartos de uma pensão, mais completo e performático </summary>
        public static void Exercicio1Alternativo()
        {
            Quarto[] quartos = new Quarto[10];
            string continua;

            do
            {
                Console.WriteLine("\nO que deseja fazer?");
                Console.WriteLine("\n1. Detalhes da pensão \n2. Alugar Quarto \n3. Desocupar Quarto \n4. Sair");
                int decide = int.Parse(Console.ReadLine());

                switch (decide)
                {
                    case 1:
                        Quarto.DetalhesQuarto(quartos);
                        break;
                    case 2:
                        Quarto.AdicionaQuarto(quartos);
                        break;
                    case 3:
                        Console.Write("\nQual o número do quarto? ");
                        int numeroQuarto = int.Parse(Console.ReadLine());
                        Quarto.DesocupaQuarto(quartos, numeroQuarto);
                        break;
                    case 4:
                        Console.WriteLine("Finalizando sistema..");
                        Thread.Sleep(1500);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Comando inválido");
                        break;
                }

                Console.Write("\nDeseja continuar (s/n)? ");
                continua = Console.ReadLine();
            }
            while (continua.ToUpper() == "S");
        }

        /// <summary> Armazena dados de funcionários e calcula o aumento do salario em porcentagem </summary>
        public static void Exercicio2()
        {
            Console.Write("How many employees will be registred? ");
            int total = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"\nEmployee #{i + 1}:");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int idAumento = int.Parse(Console.ReadLine());
            Funcionario funcionario = funcionarios.Find(x => x.Id == idAumento);

            if (funcionario != null)
            {
                Console.Write("\nEnter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.AumentaSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("\nThis id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (Funcionario func in funcionarios)
            {
                Console.WriteLine($"{func.Id}, {func.Nome}, {func.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
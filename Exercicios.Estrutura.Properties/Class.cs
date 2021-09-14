using System;
using System.Threading;
using System.Globalization;

namespace Exercicios.Estrutura.Properties
{
    public class ExerciciosProperties
    {
        /// <summary> Cadastra um produto e adiciona e remove unidades do estoque, agora utilizando encapsulamento manual </summary>
        public static void ExercicioAula55Encapsulamento()
        {
            ProdutoEncapsulamento produto;
            string nome;
            double preco;
            int quantidade;

            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nTem estoque (s/n)? ");
            string estoque = Console.ReadLine().ToUpper();

            if (estoque != "S")
            {
                produto = new ProdutoEncapsulamento(nome, preco);
                Console.WriteLine($"\nDados do produto: {produto}");
            }
            else
            {
                Console.Write("Quantidade no estoque: ");
                quantidade = int.Parse(Console.ReadLine());
                
                produto = new ProdutoEncapsulamento(nome, preco, quantidade);
                Console.WriteLine($"\nDados do produto: {produto}");
            }

            string continua;

            do
            {
                Console.WriteLine("\nO que deseja fazer?");
                Console.WriteLine("\n1. Detalhes do produto \n2. Alterar Nome \n3. Alterar Preço \n4. Alterar Quantidade  \n5. Sair");
                int decide = int.Parse(Console.ReadLine());

                switch (decide)
                {
                    case 1:
                        break;
                    case 2:
                        Console.Write("\nDigite o nome: ");
                        nome = Console.ReadLine();
                        produto.SetNome(nome);
                        break;
                    case 3:
                        Console.Write("\nDigite o preço: ");
                        preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        produto.SetPreco(preco);
                        break;
                    case 4:
                        Console.WriteLine("\n1. Adicionar \n2. Remover");
                        int verifica = int.Parse(Console.ReadLine());
                        if (verifica == 1)
                        {
                            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
                            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
                        }
                        else if (verifica == 2)
                        {
                            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
                            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
                        }
                        else
                        {
                            Console.WriteLine("\nComando Inválido");
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nFinalizando sistema..");
                        Thread.Sleep(1500);
                        Environment.Exit(0);
                        break;
                    default:
                        {
                            Console.WriteLine("\nComando Inválido");
                            break;
                        }
                }

                Console.WriteLine($"\nDados do produto: {produto}");
                Console.WriteLine("\nDeseja continuar (s/n)?");
                continua = Console.ReadLine();

            } while (continua.ToUpper() == "S");

            Console.WriteLine("\nFinalizando sistema..");
        }

        /// <summary> Cadastra um produto e adiciona e remove unidades do estoque, agora utilizando Properties </summary>
        public static void ExercicioAula56Properties()
        {
            ProdutoProperties produto;
            string nome;
            double preco;
            int quantidade;

            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nTem estoque (s/n)? ");
            string estoque = Console.ReadLine().ToUpper();

            if (estoque != "S")
            {
                produto = new ProdutoProperties(nome, preco);
                Console.WriteLine($"\nDados do produto: {produto}");
            }
            else
            {
                Console.Write("Quantidade no estoque: ");
                quantidade = int.Parse(Console.ReadLine());

                produto = new ProdutoProperties(nome, preco, quantidade);
                Console.WriteLine($"\nDados do produto: {produto}");
            }

            string continua;

            do
            {
                Console.WriteLine("\nO que deseja fazer?");
                Console.WriteLine("\n1. Detalhes do produto \n2. Alterar Nome \n3. Alterar Preço \n4. Alterar Quantidade  \n5. Sair");
                int decide = int.Parse(Console.ReadLine());

                switch (decide)
                {
                    case 1:
                        break;
                    case 2:
                        Console.Write("\nDigite o nome: ");
                        nome = Console.ReadLine();
                        produto.Nome = nome;
                        break;
                    case 3:
                        Console.Write("\nDigite o preço: ");
                        preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        produto.Preco = preco;
                        break;
                    case 4:
                        Console.WriteLine("\n1. Adicionar \n2. Remover");
                        int verifica = int.Parse(Console.ReadLine());
                        if (verifica == 1)
                        {
                            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
                            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
                        }
                        else if (verifica == 2)
                        {
                            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
                            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
                        }
                        else
                        {
                            Console.WriteLine("\nComando Inválido");
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nFinalizando sistema..");
                        Thread.Sleep(1500);
                        Environment.Exit(0);
                        break;
                    default:
                        {
                            Console.WriteLine("\nComando Inválido");
                            break;
                        }
                }

                Console.WriteLine($"\nDados do produto: {produto}");
                Console.WriteLine("\nDeseja continuar (s/n)?");
                continua = Console.ReadLine();

            } while (continua.ToUpper() == "S");

            Console.WriteLine("\nFinalizando sistema..");
        }

        /// <summary> Cadastra uma conta bancária e permite depositar e sacar valores </summary>
        public static void Exercicio1()
        {
            ContaBancaria contaBancaria;
            string nome;
            int conta;
            double saldo;
        
            Console.Write("Entre com o número da conta: ");
            conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o nome do titular da conta: ");
            nome = Console.ReadLine();

            Console.Write("\nHaverá depósito inicial (s/n)? ");
            string deposito = Console.ReadLine().ToUpper();

            if (deposito != "S")
            {
                contaBancaria = new ContaBancaria(nome, conta);
                Console.WriteLine($"\nDados da conta: \n{contaBancaria}");
            }
            else
            {
                Console.Write("Entre o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                contaBancaria = new ContaBancaria(nome, saldo, conta);
                Console.WriteLine($"\nDados da conta: \n{contaBancaria}");
            }

            string continua;

            do
            {
                Console.WriteLine("\nO que deseja fazer?");
                Console.WriteLine("\n1. Detalhes da conta \n2. Depósito \n3. Saque \n4. Alterar Nome \n5. Sair");
                int decide = int.Parse(Console.ReadLine());

                switch (decide)
                {
                    case 1:
                        Console.WriteLine($"\nDados da conta: \n{contaBancaria}");
                        break;
                    case 2:
                        Console.Write("\nDigite o valor: ");
                        saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        contaBancaria.Deposito(saldo);
                        Console.WriteLine($"\nDados da conta atualizados: \n{contaBancaria}");
                        break;
                    case 3:
                        Console.Write("\nDigite o valor: ");
                        saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        contaBancaria.Saque(saldo);
                        Console.WriteLine($"\nDados da conta atualizados: \n{contaBancaria}");
                        break;
                    case 4:
                        Console.Write("\nDigite o Nome: ");
                        nome = Console.ReadLine();
                        contaBancaria.Nome = nome;
                        Console.WriteLine($"\nDados da conta atualizados: \n{contaBancaria}");
                        break;
                    case 5:
                        Console.WriteLine("\nFinalizando sistema..");
                        Thread.Sleep(1500);
                        Environment.Exit(0);
                        break;
                    default:
                        {
                            Console.WriteLine("\nComando Inválido");
                            break;
                        }
                }

                do
                {
                    Console.WriteLine("\nDeseja continuar (s/n)?");
                    continua = Console.ReadLine();
                    if (continua.ToUpper() != "S" && continua.ToUpper() != "N") Console.WriteLine("\nComando Inválido");

                } while (continua.ToUpper() != "S" && continua.ToUpper() != "N");

            } while (continua.ToUpper() == "S");

            Console.WriteLine("\nFinalizando sistema..");
            Thread.Sleep(1500);
            Environment.Exit(0);
        }
    }
}
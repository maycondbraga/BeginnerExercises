using System;
using System.Globalization;

namespace Exercicios.Estrutura.Classes
{
    public class ExerciciosClasses
    {
        /// <summary> Calcula as medidas de dois triângulos e retorna qual possui a maior área </summary>
        public static void ExercicioAula38()
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double xArea = x.CalculaArea();
            double yArea = y.CalculaArea();

            Console.WriteLine($"Área de X = {xArea.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {yArea.ToString("F4", CultureInfo.InvariantCulture)}");

            if (xArea > yArea)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }

        /// <summary> Cadastra um produto e adiciona e remove unidades do estoque </summary>
        public static void ExercicioAula42()
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDados do produto: {produto}");

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"\nDados do produto: {produto}");

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            
            Console.WriteLine($"\nDados do produto: {produto}");
        }

        /// <summary> Cadastra um produto e adiciona e remove unidades do estoque, agora utilizando um construtor </summary>
        public static void ExercicioAula42Construtor()
        {
            ProdutoConstrutor produtoConstrutor;

            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nTem estoque (s/n)? ");
            string estoque = Console.ReadLine().ToUpper();

            if (estoque != "S")
            {
                produtoConstrutor = new ProdutoConstrutor(nome, preco);
                Console.WriteLine($"\nDados do produto: {produtoConstrutor}");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            produtoConstrutor = new ProdutoConstrutor(nome, preco, quantidade);

            Console.WriteLine($"\nDados do produto: {produtoConstrutor}");

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            produtoConstrutor.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"\nDados do produto: {produtoConstrutor}");

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            produtoConstrutor.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"\nDados do produto: {produtoConstrutor}");
        }

        ///<summary> Retorna qual pessoa é a mais velha </summary>
        public static void Exercicio1()
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");

            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Ddados da segunda pessoa:");

            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");
            }
        }

        /// <summary> Retorna a média salarial entre dois funcionários </summary>
        public static void Exercicio2()
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");

            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            funcionario1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funcionário:");

            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            funcionario2.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario1.SalarioBruto + funcionario2.SalarioBruto) / 2.0;
            Console.WriteLine($"Salário médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        /// <summary> Calcula as medidas de área, perímetro e diagonal de um retângulo </summary>
        public static void Exercicio3()
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(retangulo);
        }

        /// <summary> Calcula o imposto e o aumento salarial do funcionário </summary>
        public static void Exercicio4()
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"\nFuncionário: {funcionario}");

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(aumento);

            Console.WriteLine($"\nDados Atualizados: {funcionario}");
        }

        /// <summary> Verifica se aluno foi aprovado ou reprovado </summary>
        public static void Exercicio5()
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("\nDigite as três notas do aluno:");
            aluno.Notas = Console.ReadLine().Split(" ");

            string notaFinal = aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine($"\nNota Final = {notaFinal}");

            if (aluno.Aprovado())
            {
                Console.WriteLine($"\nAprovado");
            }
            else
            {
                string diferenca = aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture);
                Console.WriteLine($"\nReprovado \nFaltaram {diferenca} Pontos");
            }
        }
    }
}
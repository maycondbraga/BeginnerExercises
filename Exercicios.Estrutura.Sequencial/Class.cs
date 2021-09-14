using System;
using System.Globalization;

namespace Exercicios.Estrutura.Sequencial
{
    public class ExerciciosSequencial
    {
        /// <summary> Exercicio da aula 18 </summary>
        public static void ExercicioAula18()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("\nProdutos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");

            Console.WriteLine($"\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine($"\nMedida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariante culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }

        /// <summary> Exercicio da aula 23 </summary>
        public static void ExercicioAula23()
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu útimo nome, idade e altura (na mesma linha):");
            string[] vetor = Console.ReadLine().Split(' ');

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(vetor[0].ToString());
            Console.WriteLine(int.Parse(vetor[1]));
            Console.WriteLine(double.Parse(vetor[2], CultureInfo.InvariantCulture));
        }

        /// <summary> Calcula a soma de dois números inteiros </summary>
        public static void Exercicio1()
        {
            Console.WriteLine("Digite o primeiro número:");
            int numeroUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int numeroDois = int.Parse(Console.ReadLine());

            int soma = numeroUm + numeroDois;
            Console.WriteLine($"Soma = {soma}");
        }

        /// <summary> Calcula a área do raio </summary>
        public static void Exercicio2()
        {
            double pi = 3.14159;

            Console.WriteLine("Digite o raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * (raio * raio);
            Console.WriteLine($"Area = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }

        /// <summary> Calcula a diferença dos produtos (A * B) e (C * D) </summary>
        public static void Exercicio3()
        {
            Console.WriteLine("Digite A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite B:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite C:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite D:");
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b) - (c * d);
            Console.WriteLine($"Diferença = {diferenca}");
        }

        /// <summary> Calcula o valor total do salário devido </summary>
        public static void Exercicio4()
        {
            Console.WriteLine("Digite o número do funcinário:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de horas trabalhadas:");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da hora trabalhada:");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorTotal = (double)horas * valorHora;

            Console.WriteLine($"Number = {id}");
            Console.WriteLine($"Salary = U$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        /// <summary> Calcula o valor total das peças </summary>
        public static void Exercicio5()
        {
            Console.WriteLine("Digite o código, quantidade e valor únitario da peça 1:");
            string[] peca1 = Console.ReadLine().Split(" ");

            Console.WriteLine("Digite o código, quantidade e valor únitario da peça 2:");
            string[] peca2 = Console.ReadLine().Split(" ");

            double valorTotal1 = int.Parse(peca1[1]) * double.Parse(peca1[2], CultureInfo.InvariantCulture);
            double valorTotal2 = int.Parse(peca2[1]) * double.Parse(peca2[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a pagar = {(valorTotal1 + valorTotal2).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        /// <summary> Calcula o triangulo, circulo, trapezio, quadrado e retangulo </summary>
        public static void Exercicio6()
        {
            Console.WriteLine("Digite A, B e C:");
            string[] vetor = Console.ReadLine().Split(" ");

            double a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            double triangulo = (a * c) / 2;
            double circulo = 3.14159 * (c * c);
            double trapezio = ((a + b) / 2) * c;
            double quadrado = b * b;
            double retangulo = a * b;

            Console.WriteLine($"Triangulo = {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circulo = {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapezio = {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado = {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retangulo = {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
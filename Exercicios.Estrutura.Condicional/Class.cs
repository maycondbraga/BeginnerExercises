using System;
using System.Globalization;

namespace Exercicios.Estrutura.Condicional
{
    public class ExerciciosCondicional
    {
        /// <summary> Retorna se número inteiro é negativo ou não </summary>
        public static void Exercicio1()
        {
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Não negativo");
            }
        }

        /// <summary> Retorna se número inteiro é impar ou par </summary>
        public static void Exercicio2()
        {
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }

        /// <summary> Retorna se os números são multiplos entre si ou não </summary>
        public static void Exercicio3()
        {
            Console.WriteLine("Digite A e B:");
            string[] valores = Console.ReadLine().Split(" ");

            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }

        /// <summary> Calcula o total de horas de jogo </summary>
        public static void Exercicio4()
        {
            Console.WriteLine("Digite a hora inicial e hora final:");
            string[] valores = Console.ReadLine().Split(" ");

            int duracao;
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine($"O jogo durou {duracao} hora(s)");
        }

        /// <summary> Calcula valor total do item </summary>
        public static void Exercicio5()
        {
            Console.WriteLine("Digite o código e quantidade do item:");
            string[] valores = Console.ReadLine().Split(" ");

            double valorTotal = 0.0;
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            if (codigo == 1)
            {
                valorTotal = (double)quantidade * 4.00;
            }
            else if (codigo == 2)
            {
                valorTotal = (double)quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                valorTotal = (double)quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                valorTotal = (double)quantidade * 2.00;
            }
            else if (codigo == 5)
            {
                valorTotal = (double)quantidade * 1.50;
            }
            else
            {
                Console.WriteLine($"Código {codigo} inválido");
                Environment.Exit(0);
            }

            Console.WriteLine($"Total: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        /// <summary> Calcula o intervalo ([0,25], [25,50],[50,75], [75,100]) que o numero se encontra </summary>
        public static void Exercicio6()
        {
            Console.WriteLine("Digite um número:");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero >= 0.00 && numero <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero > 25.00 && numero <= 50.0)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (numero > 50.00 && numero <= 75.00)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if (numero > 75.00 && numero <= 100.00)
            {
                Console.WriteLine("Intervalo [75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
                Environment.Exit(0);
            }
        }

        /// <summary> Calcula a coordenada do ponto em um plano cartesiano </summary>
        public static void Exercicio7()
        {
            Console.WriteLine("Digite o ponto X e Y:");
            string[] valores = Console.ReadLine().Split(" ");

            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            string a = x.ToString("F1", CultureInfo.InvariantCulture);
            string b = y.ToString("F1", CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine($"A coordenada {a}, {b} pertence a ORIGEM");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine($"A coordenada {a}, {b} pertence ao EIXO Y");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine($"A coordenada {a}, {b} pertence ao EIXO X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine($"A coordenada {a}, {b} pertence ao QUADRANTE - 1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"A coordenada {a}, {b} pertence ao QUADRANTE - 2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"A coordenada {a}, {b} pertence ao QUADRANTE - 3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"A coordenada {a}, {b} pertence ao QUADRANTE - 4");
            }
        }

        /// <summary> Calcula o imposto de uma moeda fictícia (Rombus) </summary>
        public static void Exercicio8()
        {
            Console.WriteLine("Digite um valor:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (valor >= 0.00 && valor <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (valor >= 2000.01 && valor <= 3000.00)
            {
                valor -= 2000.00;
                imposto = valor * 0.08;

                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (valor >= 3000.01 && valor <= 4500.00)
            {
                valor -= 3000.00;
                imposto = (1000.00 * 0.08) + (valor * 0.18);

                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (valor > 4500.00)
            {
                valor -= 4500.00;
                imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + (valor * 0.28);

                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Valor inválido");
                Environment.Exit(0);
            }
        }
    }
}
using System;
using System.Globalization;

namespace Exercicios.Estrutura.Repetitiva.While
{
    public class ExerciciosWhile
    {
        /// <summary> Verifica se a senha informada é igual a definida no método </summary>
        public static void Exercicio1()
        {
            bool validaWhile = true;

            while (validaWhile)
            {
                Console.WriteLine("Digite a senha:");
                int senha = int.Parse(Console.ReadLine());

                if (senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    validaWhile = false;
                }
                else
                {
                    Console.WriteLine("Senha Inválida");
                }
            }
        }

        /// <summary> Retorna o quadrante das coordenadas no plano cartesiano </summary>
        public static void Exercicio2()
        {
            bool verificaWhile = true;

            while (verificaWhile)
            {
                Console.WriteLine("Digite o ponto X e Y:");
                string[] valores = Console.ReadLine().Split(" ");

                double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

                string a = x.ToString("F1", CultureInfo.InvariantCulture);
                string b = y.ToString("F1", CultureInfo.InvariantCulture);

                if (x == 0 || y == 0)
                {
                    verificaWhile = false;
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
        }

        ///<summary> Determina a preferência dos clientes aos produtos de um posto de gasolina </summary>
        public static void Exercicio3()
        {
            int codigo, alcool = 0, gasolina = 0, diesel = 0;

            do
            {
                Console.WriteLine("\nDigite o código:");
                Console.WriteLine("\n1. Álcool \n2. Gasolina \n3. Diesel \n4. Finalizar");

                codigo = int.Parse(Console.ReadLine());

                if (codigo < 1 || codigo > 4)
                {
                    Console.WriteLine("\nCódigo inválido, tente novamente");
                }
                else if (codigo == 1)
                {
                    alcool++;
                }
                else if (codigo == 2)
                {
                    gasolina++;
                }
                else if (codigo == 3)
                {
                    diesel++;
                }

            } while (codigo != 4);

            Console.WriteLine("\nMuito Obrigado");
            Console.WriteLine($"\nÁlcool: {alcool} \nGasolina: {gasolina} \nDiesel: {diesel}");
        }
    }
}
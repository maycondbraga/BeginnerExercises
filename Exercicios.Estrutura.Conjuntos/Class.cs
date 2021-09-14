using System;
using System.Collections.Generic;

namespace Exercicios.Estrutura.Conjuntos
{
    public class ExerciciosConjuntos
    {
        /// <summary> Define os alunos do instrutor e retorna a quantidade de alunos total </summary>
        public static void Exercicio1()
        {
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int totalAluno = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite os códigos dos alunos do curso A:");
            for (int i = 0; i < totalAluno; i++)
            {
                Console.Write($"{i + 1}o: ");
                cursoA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("\nO curso B possui quantos alunos? ");
            totalAluno = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite os códigos dos alunos do curso B:");
            for (int i = 0; i < totalAluno; i++)
            {
                Console.Write($"{i + 1}o: ");
                cursoB.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("\nO curso C possui quantos alunos? ");
            totalAluno = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite os códigos dos alunos do curso C:");
            for (int i = 0; i < totalAluno; i++)
            {
                Console.Write($"{i + 1}o: ");
                cursoC.Add(int.Parse(Console.ReadLine()));
            }

            cursoA.UnionWith(cursoB);
            cursoA.UnionWith(cursoC);

            Console.WriteLine($"\nTotal de alunos: {cursoA.Count}");
        }
    }
}
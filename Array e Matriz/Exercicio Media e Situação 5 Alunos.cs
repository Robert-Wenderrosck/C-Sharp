using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

//Crie um programa que solicite ao usuário que digite as notas de 5 alunos em 3 provas diferentes.
//Armazene as notas em uma matriz 5x3 e, em seguida, o programa deve calcular a média de cada aluno em cada prova.
//Verifique também se o aluno foi aprovado ou reprovado, considerando a média mínima de 7.0

namespace Exercicio_Media_e_Situação_5_Alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz = new int[5, 3];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Digite as notas do aluno {i+1}: ");
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n---------------Resultados----------------");

            for (int i = 0; i < 5; i++)
            {
                int mediaAluno = (matriz[i, 0] + matriz[i, 1] + matriz[i, 2]);
                Console.WriteLine("Aluno " + (i+1) + ": " + "Média: " + mediaAluno / 3);
                
                if (mediaAluno/3 >= 7)
                {
                    Console.WriteLine("Aprovado!\n");
                }
                else
                {
                    Console.WriteLine("\nReprovado!\n");
                }            
            }
        }
    }
}

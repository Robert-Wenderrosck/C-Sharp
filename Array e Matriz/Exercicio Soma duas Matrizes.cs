using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercício
//Crie um programa que leia duas matrizes de números inteiros de mesma dimensão (ex.: 3x3) e imprima a soma das duas matrizes

namespace Exercicio_Soma_duas_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz1 = new int[3, 3];

            Console.WriteLine("Digite os valores da Matriz 1: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatriz 1: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz1[i, j] + "    ");
                }

                Console.WriteLine();
            }

            int[,] matriz2 = new int[3, 3];

            Console.WriteLine("\n---------------------------------\n");

            Console.WriteLine("Digite os valores da Matriz 2: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatriz 2: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz1[i, j] + "    ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nA soma das duas matrizes é:");


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz1[i, j] + matriz2[i, j] + "    ");
                }
                Console.WriteLine();
            }

        }
    }
}

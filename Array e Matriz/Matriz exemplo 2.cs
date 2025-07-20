using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_exemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar uma matriz de inteiros de 3x4
            int[,] notas = new int[3, 4];

            //Laço para preencher a matriz com as notas
            for (int linha = 0; linha < 3; linha++)
            {
                Console.WriteLine($"Digite as notas do {linha + 1}º aluno");
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    notas[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Notas dos alunos: ");

            for (int linha = 0; linha < 3; linha++)
            {
                Console.Write($"Aluno {linha + 1}:\n");
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.WriteLine($"{notas[linha, coluna]}");
                }

                Console.WriteLine(); //Cria uma quebra de linha 
            }

        }
    }
}

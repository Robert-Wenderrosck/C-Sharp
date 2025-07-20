using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_Exemplo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cria uma matriz de 3x3
            int[,] matriz = new int[3, 3];
            Console.WriteLine("Digite os valores da matriz: ");

            //Preenche a matriz com os valores inseridos pelo usuário
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna=0; coluna < 3; coluna++)
                {
                    Console.Write($"Digite o valor da linha: {linha}, Coluna: {coluna} = ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine("\n---------------------------");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "    "); //Adiciona os valores de cada coluna de uma linha dando um espaço
                    
                }

                Console.WriteLine(); //Pula linha assim que imprime cada linha da matriz

            }

            int soma = 0;

            //Somando os valores da diagonal
            for (int linha = 0; linha < 3; linha++)
            {
                Console.WriteLine(matriz[linha, linha]); //Escreve os valores da diagonal da matriz 
                soma += matriz[linha, linha]; //Linha, linha porque ambas tem o mesmo número (representa os números da diagonal da matriz)
            }

            Console.WriteLine("Total Diagonal: " + soma);


        }
    }
}

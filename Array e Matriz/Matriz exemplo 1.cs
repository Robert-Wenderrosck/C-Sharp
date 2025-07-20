using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_exemplo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matriz de 3 linhas e 4 colunas (Matriz é formada por vários arrays)
            int[,] matriz = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            for (int linha = 0; linha < 3; linha++) //Loop pelas linhas
            {
                for (int coluna = 0; coluna < 4; coluna++) //Loop pelas colunas
                {
                    //Usar 'Console.Write' pra não ficar no formato de matriz
                    Console.Write(matriz[linha, coluna] + "   "); //Imprime o valor da posição (linha, coluna) seguido por um espaço em branco
                }

                Console.WriteLine(); //Pula uma linha para imprimir a próxima linha da matriz
            }

        }
    }
}

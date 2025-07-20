using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um programa que solicita ao usuário que digite 10 números inteiros e armazena esses números em um array.
//Em seguida, o programa deve exibir na tela os 3 maiores números digitados pelo usuário.

namespace Exercício_3_Maiores_Valores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numerosDigitados = new int[10];

            for (int i = 0; i < numerosDigitados.Length; i++)
            {

                Console.WriteLine("Digite o número do array da posição: " + i);
                numerosDigitados[i] = int.Parse(Console.ReadLine());

                
            }

            //Ordena os números em ordem decrescente 
            Array.Sort(numerosDigitados);
            Array.Reverse(numerosDigitados);

            Console.WriteLine("Maior Número: " + numerosDigitados[0]);
            Console.WriteLine("Segundo maior:" + numerosDigitados[1]);
            Console.WriteLine("Terceiro maior: " + numerosDigitados[2]);

        }
    }
}

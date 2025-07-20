using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um programa que solicita ao usuário que digite 5 números inteiros e armazene esses números em um array.
//Em seguida, exiba na tela a soma de todos os números.

namespace Exercício_Soma_5_Números
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numerosDigitados = new int[5];
            int soma = 0;

            foreach (int i in numerosDigitados)
            {

                Console.WriteLine("Digite o número do array da posição: " + i);
                numerosDigitados[i] = int.Parse(Console.ReadLine());
                soma = soma + numerosDigitados[i];
            }

            Console.WriteLine("A soma dos números digitado é: " + soma); 

        }
    }
}

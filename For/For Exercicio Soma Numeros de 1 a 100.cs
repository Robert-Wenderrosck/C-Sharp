using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escreva um programa que calcule a soma dos números de 1 a 100 e imprima o resultado na tela

namespace For_Exercicio_Soma_Numeros_de_1_a_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma = soma + i;
                Console.WriteLine(soma);

            }
        }
    }
}

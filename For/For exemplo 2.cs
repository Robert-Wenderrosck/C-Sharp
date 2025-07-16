using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_exemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i<= 100; i++)
            {

                if (i % 2 == 0)
                {
                    //Imprime a mensagem indicando que o número é par
                    Console.WriteLine(i + " é um número par");
                }
            }
            
            Console.WriteLine("-----------------------------");

            //Cria um array de inteiros
            int[] numeros = { 10, 25, 30, 45, 50 };
            int soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {

                soma += numeros[i];
            }

            double media = (double)soma / numeros.Length;
            Console.WriteLine("A média dos números é: " + media);

        }
    }
}

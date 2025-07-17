using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercicio:
//Faça um programa que receba dois números inteiros e gere os números inteiros que estão no intervalo compreendido por eles

namespace Exercicio_Numeros_Inteiros_em_um_Intervalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                for (numero2 = numero2 + 1; numero2 < numero1; numero2++)
                {
                    Console.WriteLine(numero2);

                }
            }
            else
            {
                for (numero1 = numero1 + 1; numero1 < numero2; numero1++)
                {
                    Console.WriteLine(numero1);

                }
            }
        }
    }
}




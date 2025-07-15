using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Crie um algoritmo que solicite a entrada de dois números para o usuário 
leia esses dois números e apresente na tela qual é o maior número 
 */

namespace Exercício_Maior_Número
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");

            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número");

            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O primeiro número digitado: " + numero1 + " é MAIOR que o segundo número digitado " + numero2);

            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("O primeiro número digitado: " + numero1 + " é MENOR que o segundo número digitado " + numero2);

            }
            else
            {
                Console.WriteLine("Os números são iguais");
            }

                Console.ReadKey();
        }
    }
}

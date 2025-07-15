using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um algoritmo que solicite um número inteiro para o usuário e na sequência, imprima na tela se o número é Par ou Ímpar

namespace Exercício_Par_ou_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite um número");

            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            //% 2 verifica se o número dividido por 2 tem resto 0 
            if (numeroDigitado % 2 == 0)
            {
                Console.WriteLine("O número digitado é par");
            }
            else
            {
                Console.WriteLine("O número digitado é ímpar");
            }

            Console.ReadKey();


        }
    }
}

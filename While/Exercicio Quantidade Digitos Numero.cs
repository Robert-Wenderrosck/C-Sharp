using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escreva um programa que leia um número inteiro positivo do usuário e exiba a quantidade de dígitos que o número inserido
//possui. O programa deve utilizar um loop While para realizar essa tarefa.

namespace Exercicio_Quantidade_Digitos_Numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro positivo para contabilizar a sua quantidade de dígitos:");
            int numeroDigitado = int.Parse(Console.ReadLine());
            int contador = 0;


            while (numeroDigitado != 0)
            {
                contador++;

                //numeroDigitado = numeroDigitado / 10
                numeroDigitado /= 10; //Divide o número por 10 a cada iteração do loop

            }
            Console.WriteLine("O número {0} possui {1} dígitos.", numeroDigitado, contador);
            Console.ReadKey();
        }
    }
}

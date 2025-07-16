using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escreva um programa que solicite ao usuário um número inteiro positivo e, em seguida, imprima todos os números ímpares
//de 1 até o número digitado. O programa deve utilizar um loop while para realizar a tarefa.

namespace Exercicio_Numeros_Impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro positivo:");
            int numeroDigitado = int.Parse(Console.ReadLine());

            int contador = 0;

            while (contador <= numeroDigitado)
            {
                if (contador % 2 != 0)
                {
                    Console.WriteLine(contador + "\n");
                    contador++;
                }
                else
                {
                    contador++;
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[5];

            int i = 0;

            //Preenchendo o vetor
            foreach (int numero in numeros) //Percorre o vetor de números
            {

                Console.WriteLine("Digite o número da posição {0}: ", i + 1); //Solicita um número para armazenar no vetor
                numeros[i] = int.Parse(Console.ReadLine()); //Lê um número digitado pelo usuário e armazena no vetor


                i++;
            }
            
            Console.WriteLine("\nNúmeros digitados: ");

            foreach (int numero in numeros) //Percorre o vetor de números
            {
                Console.WriteLine(numero); //Escreve cada número na tela
            }
            

        }
    }
}

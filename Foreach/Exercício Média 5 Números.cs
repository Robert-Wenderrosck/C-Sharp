using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

//Exercício:
//Crie um programa utilizando Foreach para solicitar ao usuário que digite 5 números em uma lista de inteiros
//e depois calcule a média aritmética dos valores 

namespace Exercício_Média_5_Números
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 5 números para calcular a média aritmética deles: ");
            double[] numerosDigitados = new double[5]; //Cria uma lista de 5 posições vazias
            int i = 0;
            double soma = 0;
            double media = 0;

            foreach (int item in numerosDigitados)
            {
                
                Console.WriteLine("Digite o número da posição {0}", i+1);
                numerosDigitados[i] = int.Parse(Console.ReadLine()); //Adiciona o número digitado em cada posição

                soma = soma + numerosDigitados[i];
                
                i++;
            }

            media = soma / i;
            Console.WriteLine("A média aritmétrica dos números digitados é: " + media);
            

        }
    }
}

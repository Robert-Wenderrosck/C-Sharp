using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
          Exercício
          Crie um programa em C# que peça ao usuário para digitar dois números inteiros
          e, em seguida, exiba a soma desses números na tela. 

 */


namespace Exercicio_Entrada_e_Saida_de_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nDigite o primeiro número inteiro:\n");

            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo número inteiro:\n");

            int numero2 = Convert.ToInt32(Console.ReadLine());

            int soma = numero1 + numero2;

            Console.WriteLine("\nA soma dos números digitado é: " + soma + "\n");

            Console.ReadKey();
        }
    }
}

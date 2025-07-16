using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tabuada

namespace While_exemplo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro para gerar a tabela de multiplicação:");
            int num = int.Parse(Console.ReadLine());

            int contador = 1;

            while (contador <= 10)
            {
                //Exibe a tabela de multiplicação do número
                Console.WriteLine(num + " x " + contador + " = " + (num * contador));
                contador++;

            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 5");

            //Lê o número digitado pelo usuário a partir do console
            int num = int.Parse(Console.ReadLine());

            //Switch - Escolha
            //case - caso
            switch (num)
            {
                case 1:

                    Console.WriteLine("Você digitou o número 1");

                    break;

                case 2:

                    Console.WriteLine("Você digitou o número 2");

                    break;

                case 3:

                    Console.WriteLine("Você digitou o número 3");

                    break;

                case 4:

                    Console.WriteLine("Você digitou o número 4");

                    break;

                case 5:

                    Console.WriteLine("Você digitou o número 5");

                    break;

                //default = outro caso
                default:

                    Console.WriteLine("Número inválido");
                    break;

            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}

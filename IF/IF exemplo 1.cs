using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_exemplo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //IF - SE
            //else if - Senão Se
            //else - Senão

            int idade = 18;

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");

            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }

            //----------------------------------------

            int numero = 10;

            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");

            }
            else
            {
                Console.WriteLine("O número é negativo.");
            }

            //----------------------------------------

            string fruta = "banana";

            if (fruta == "maça")
            {
                Console.WriteLine("Você escolheu uma maça!");

            }
            else if( fruta == "laranja")
            {
                Console.WriteLine("Você escolheu uma laranja!");

            }
            else if (fruta == "uva")
            {
                Console.WriteLine("Você escolheu uma uva!");

            }
            else
            {
                Console.WriteLine("Desculpe, não temos essa fruta!");
            }

                //Espera até que o usuário faça algo para sair
                Console.ReadKey();





        }
    }
}

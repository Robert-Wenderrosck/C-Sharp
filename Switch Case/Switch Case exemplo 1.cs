using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_exemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu gênero? (M para masculino, F para Feminino)");
            char genero = Console.ReadKey().KeyChar;

            switch(genero)
            {
                case 'm':
                case 'M':
                    Console.WriteLine("\nGênero Masculino");
                    break;

                case 'F':
                case 'f':
                    Console.WriteLine("\nGênero Feminino");
                    break;

                default:
                    Console.WriteLine("Você não digitou nem M nem F");
                    break;

             }

            Console.ReadKey();

        }
    }
}

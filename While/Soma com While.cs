using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int soma = 0;

            while (contador <= 10) 
            {
                soma += contador;
                Console.WriteLine("Adicionado " + contador + " à soma atual: " + soma);

                contador++;
             }

            Console.ReadKey();
        }
    }
}

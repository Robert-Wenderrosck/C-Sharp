using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_exemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 10, 5, 20, 35, 50 }; //Cria um array de números inteiros 
            int contador = 0;

            foreach(int posicao in numeros)
            {
                Console.WriteLine("Item da posição: {0} = {1}", contador + 1, posicao);

                contador++;

            }
            Console.WriteLine("Exemplo com Letras");

            string[] letras = { "A", "B", "C", "D", "Casa", "Carro" }; //Cria um array de letras 
            int ordem = 0;

            foreach (string item in letras)
            {
                Console.WriteLine("Item da posição: {0} = {1}", ordem, item);

                ordem++;

            }

        }
    }
}

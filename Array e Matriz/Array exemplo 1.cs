using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaração e inicialização de um array de inteiros
            int[] numeros = { 10, 20, 25, 45, 19 };

            //Exibir os valores do array ma tela 
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);

            }

            Console.WriteLine("\n\n----------------Array de Strings ----------------");

            string[] cores = new string[4]; //Cria um novo array com 4 posições

            cores[0] = "vermelho";
            cores[1] = "verde";
            cores[2] = "azul";
            cores[3] = "amarelo";

            foreach (string cor in cores)
            {
                Console.WriteLine(cor);
            }


        }
    }
}

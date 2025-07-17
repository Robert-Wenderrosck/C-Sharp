using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Exemplo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define uma matriz de 5 posições para armazenar os números
            int[] numeros = new int[5];

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            //Cria uma variável para armazenar o primeiro valor da matriz
            int maximo = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                //Verifica se a posição atual da matriz que estiver passando é maior que o valor que está na variável máximo
                //Se for maior, substitui o valor da variável máximo pelo valor da Matriz
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }

            }

            Console.WriteLine("O valor máximo é " + maximo);
           
        }
    }
}

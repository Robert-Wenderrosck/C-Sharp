using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercício:
//Suponha que você tenha um array de strings contendo o nome de algumas cidades. 
//Escreva um programa que utilize o foreach para percorrer esse array e exibir na tela a mensagem:
//"Bem-vindo(a) à cidade de {nome da cidade}" para cada cidade.

namespace Exercício_Exibe_Nome_Cidades_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] cidades = { "Rio das Ostras", "Casimiro de Abreu", "Macaé", "Saquarema", "Carapebus" };
            int i = 1;

            foreach (string cidade in cidades)
            {
                Console.WriteLine("Bem-vindo(a) {0}º cidade: {1}", i, cidade);

                i++;
            }


        }
    }
}

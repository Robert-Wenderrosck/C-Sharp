using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_exemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 21;
            string sexo = "masculino";

            //& - Duas condições têm que ser válidas 
            if (idade >= 18 & sexo == "masculino")
            {
                Console.WriteLine("Você é um homem maior de idade");
            }
            else
            {
                Console.WriteLine("Você não é um homem maior de idade");
            }

            //---------------------------------------------

            int numero = 20;

            if (numero >= 10 & numero <= 20)
            {
                Console.WriteLine("O número está entre 10 e 20");
            }
            else
            {
                Console.WriteLine("O número não está entre 10 e 20");
            }

            //---------------------------------------------

            bool estaChovendo = true;
            bool estaFrio = false;

            if (estaChovendo == true & estaFrio == true)
            {
                Console.WriteLine("Está chovendo e está frio");
            }
            else
            {
                Console.WriteLine("Condição inválida!");
            }

            //---------------------------------------------

            // | Ou 
            int n = 15;

            if (n < 10 | n > 20)
            {
                Console.WriteLine("O número não é menor que 10 nem maior que 20");
            }
            else if (n == 10 | n == 20)
            {
                Console.WriteLine("O número é igual a 10 ou 20");
            }
            else
            {
                Console.WriteLine("O número está entre 11 e 19");
            }

            
            //---------------------------------------------

            string cor = "azul";

            if (cor == "azul" | cor == "verde")
            {
                Console.WriteLine("A cor é azul ou verde");
            }
            else
            {
                Console.WriteLine("A cor não é azul ou verde");
            }

            //---------------------------------------------
            // != diferente 

            string tom = "cinza";

            if (tom != "azul")
            {
                Console.WriteLine("A cor é diferente de azul");
            }
            else
            {
                Console.WriteLine("A cor é azul");


            }

            Console.ReadKey();
        }
    }
}
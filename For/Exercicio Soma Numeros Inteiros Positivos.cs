using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercício:
//Escreva um programa que leia uma sequência de números inteiros positivos do usuário (só vai parar quando o usuário digitar
//um número negativo) e calcule a média dos números lidos.

namespace Exercicio_Soma_Numeros_Inteiros_Positivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int contador = 0;

            //;; Forma de escrever um loop que não tem condição explícita
            for (; ; )
            {
                Console.WriteLine("Digite um número inteiro: \n(Digite um negativo para sair) ");
                int numeroDigitado = int.Parse(Console.ReadLine());

                if (numeroDigitado >= 0)
                {
                    soma = soma + numeroDigitado;
                    contador++;
                }
                else
                {
                    double media = (soma / contador);
                    Console.WriteLine("A média dos números digitados é: " + media);
                    break; //Sai do for

                }
            }

        }
    }
}

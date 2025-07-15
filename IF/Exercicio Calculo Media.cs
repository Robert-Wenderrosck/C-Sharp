using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Faça um programa para a leitura de duas notas parciais de um aluno. O programa deve calcular a média alcançada por aluno
 * e apresentar:
 * 
 * A mensagem "Aprovado" se a média alcançada for maior ou igual a 7;
 * A mensagem "Reprovado" se a média for menor que 7;
 * A memsagem "Aprovado com Distinção" se a média for igual a 10; 
 */

namespace Exercicio_Calculo_Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float aceita números decimais
            //float.Parse - transforma um número digitado em float para ser lido com casa decimal
            Console.WriteLine("Digita a nota 1 do aluno:");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digita a nota 2 do aluno:");
            float nota2 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2) / 2;

            Console.WriteLine("\nA média do aluno é:\n" + media);

            if (media >= 7 & media <10)
            {
                Console.WriteLine("\nAluno aprovado!\n");
            }
            else if (media < 7)
            {
                Console.WriteLine("\nAluno Reprovado!\n");
            }
            else
            {
                Console.WriteLine("\nAprovado com Distinção\n");
            }

            Console.ReadKey();
        }
    }
}

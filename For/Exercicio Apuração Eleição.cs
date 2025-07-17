using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Numa eleição existem três candidatos. Faça um programa que peça o número total de eleitores. Peça para cada eleitor
//votar e ao final mostrar o número de votos de cada candidato.

namespace Exercicio_Apuração_Eleição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string voto;
            int votosCandidato1 = 0;
            int votosCandidato2 = 0;
            int votosCandidato3 = 0;
            int votosNulos = 0;

            Console.WriteLine("Digite o número total de eleitores: ");
            int numeroEleitores = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroEleitores; i++)
            {

                Console.WriteLine("Digite o número do candidato que se quer votar:\n");
                Console.WriteLine("1- Candidato 1\n 2- Candidato 2\n 3-Candidato 3\n");
                voto = Console.ReadLine();

                if (voto == "1")
                {
                    votosCandidato1++;
                }
                else if (voto == "2")
                {
                    votosCandidato2++;
                }
                else if (voto == "3") 
                {
                    votosCandidato3++;
                }
                else
                {
                    votosNulos++;
                }

            }

            Console.WriteLine("Número de votos de cada candidato:\nCandidato 1: " + votosCandidato1 + "\nCandidato 2: " + votosCandidato2 + "\nCandidato 3:" + votosCandidato3 + "\nVotos Nulos:" + votosNulos);

            
        }
        
    }
}

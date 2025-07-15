using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_Aninhado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declara as variáveis
            int idade = 18;
            bool temCarteira = true;

            if (idade >= 18)
            {
                //IF aninhado é um IF dentro do outro
                if (temCarteira == true)
                {
                    Console.WriteLine("Você pode dirigir");
                }
                else
                {
                    Console.WriteLine("Não pode dirigir sem a carteira de motorista");
                }
            }
            else
            {
                Console.WriteLine("Não pode dirigir por ser menor de idade.");
            }

            //Espera que o usuário aperte uma tecla para fechar a janela
            Console.ReadKey();

        }
    }
}

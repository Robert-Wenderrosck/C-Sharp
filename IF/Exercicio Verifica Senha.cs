using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um algoritmo que solicite ao usuário a entrada de uma senha depois verifique se a senha digitada é 1234 se for,
//exiba a mensagem "Acesso Permitido", caso contrário exiba "Acesso negado".

namespace Exercicio_Verifica_Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma senha de 4 dígitos: ");

            int senha = Convert.ToInt32(Console.ReadLine());

            if (senha == 1234)
            {
                Console.WriteLine("Acesso permitido");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }
            Console.ReadKey();
        }
    }
}

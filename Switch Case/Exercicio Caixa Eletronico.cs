using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Exercício: Escreva um programa que simule um caixa eletrônico com as seguintes opções:
 
 * Depósito: O usuário deve informar o valor a ser depositado, que será adicionado ao saldo atual.
 * Saque: O usuário deve informar o valor a ser sacado, que será subtraído do saldo atual.
 * Ver saldo: O programa deve imprimir o saldo atual

 * O programa deve continuar executando até que o usuário escolha a opção de sair.
 
 */

namespace Exercicio_Caixa_Eletronico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double saldo = 100;

            //Coloca-se ; ; quando o for não tem um parâmetro
            //return() para sair do FOR
            for (; ; )
            {
                Console.WriteLine("\n--------- Bem-Vindo ao caixa eletrônico ---------\n");
                Console.WriteLine("\nDigite o número de uma opção:");
                Console.WriteLine(" 1: Depósito\n 2: Saque \n 3: Ver Saldo \n 4: Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe o valor a ser depositado");
                        double deposito = double.Parse(Console.ReadLine());

                        saldo = (saldo + deposito);

                        Console.WriteLine("\nDepósito adicionado com sucesso\n");
                        break;

                    case 2:
                        Console.WriteLine("Informe o valor a ser sacado");
                        double saque = double.Parse(Console.ReadLine());

                        if (saque <= saldo)
                        {
                            saldo = (saldo - saque);
                            Console.WriteLine("\nVocê irá sacar " + saque + "\n Aguarde a saída das notas ");
                            Console.WriteLine("\nSeu saldo restante é de  " + saldo + "\n");
                        }
                        else
                        {
                            Console.WriteLine("\nSeu saldo é de " + saldo + "\n");
                            Console.WriteLine("Por favor digite um valor de saque válido!\n");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nSeu saldo é de " + saldo + "\n");
                        break;

                    case 4:
                        Console.WriteLine("Obrigado por usar o caixa eletrônico");
                        return; //Sai do FOR

                    default:
                        Console.WriteLine("\nOpção não encontrada!\n");
                        break;
                }
            }
        }
    }
}

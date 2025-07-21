using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria
{

    class ContaBancaria
    {
        //Atributos
        private string titular;
        private int numero;
        private double saldo;

        //Construtor da classe que recebe o nome, numero e saldo
        public ContaBancaria(string titularConta, int numeroConta)
        {
            //Atribui os valores dos parâmetros aos atributos da classe
            this.titular = titularConta;
            this.numero = numeroConta;
            this.saldo = 0.0;
        }

        //Métodos
        //Método público que retorna o nome do titular da conta
        public string GetTitular()
        {
            return titular;
        }
        //Método público que retorna o número da conta
        public int GetNumero()
        {
            return numero;
        }
        //Método público que retorna o saldo da conta
        public double GetSaldo()
        {
            return saldo;
        }

        //Método público que realiza um depósito na conta
        public void Depositar(double valor)
        {
            saldo += valor; //saldo = saldo + valor
        }
        //Método público para sacar um valor da conta
        public void Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor; //saldo = saldo - valor
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }

        }
        public override string ToString()
        {
            return "Titular: " + titular +
                    "\nNúmero da conta: " + numero +
                    "\nSaldo: " + saldo + "\n";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Chamou a classe e passou as informações 
            ContaBancaria minhaconta = new ContaBancaria("João da Silva", 12345);

            Console.WriteLine("=========== Dados do Usuário =============\n");
            Console.WriteLine(minhaconta.ToString());

            minhaconta.Depositar(500);

            Console.WriteLine("=========== Depósito =============\n");
            Console.WriteLine("Titular: " + minhaconta.GetTitular());
            Console.WriteLine("Número da Conta: " + minhaconta.GetNumero());
            Console.WriteLine("Valor Depositado: 500,00\n");

            Console.WriteLine("=========== Saldo após Depósito ===============");
            Console.WriteLine(minhaconta.ToString());

            minhaconta.Sacar(200);

            Console.WriteLine("=========== Saque =============\n");
            Console.WriteLine("Titular: " + minhaconta.GetTitular());
            Console.WriteLine("Número da Conta: " + minhaconta.GetNumero());
            Console.WriteLine("Valor Saque: 200,00\n");

            Console.WriteLine("=========== Saldo após Saque ===============");
            Console.WriteLine(minhaconta.ToString());


        }
    }
}

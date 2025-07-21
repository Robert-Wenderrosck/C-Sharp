using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_e_Objetos___POO
{
    class Pessoa
    {
        //Atributos
        public string nome;
        public int idade;

        //Construtor
        public Pessoa(string nomeAtual, int idadeAtual)
        {
            this.nome = nomeAtual;
            this.idade = idadeAtual;
        }

        //Método 
        public void Falar()
        {
            Console.WriteLine("Olá, meu nome é " + nome + " tenho " + idade + " anos.");
            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Com esse método não precisa digitar a mesma informação para diferentes usuários, basta chamar o método da função

            Console.WriteLine("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da pessoa: ");
            int idade = int.Parse(Console.ReadLine());

            Pessoa pessoa1 = new Pessoa(nome, idade);

            pessoa1.Falar();

            //-------------------------------------------

            Pessoa pessoa2 = new Pessoa("Beatriz", 25);

            pessoa2.Falar();

            //-------------------------------------------

            Pessoa pessoa3 = new Pessoa("Ricardo", 40);

            pessoa3.Falar();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Contato
{
    class Contato
    {
        //Atributos 
        private string nome;
        private string email;
        private string telefone;

        //Construtor 
        public Contato(string nomeContato, string emailContato, string telefoneContato)
        {
            //Atribui os valores dos parâmetros aos campos correspondentes da classe
            this.nome = nomeContato;
            this.email = emailContato;
            this.telefone = telefoneContato;
        }

        //Métodos get e set
        public string Nome
        {
            get { return nome; } // Retorna o valor do campo 
            set { nome = value; } //Define um novo valor para o campo (substitui)
        }
        public string Email
        {
            get { return email; } // Retorna o valor do campo 
            set { email = value; } //Define um novo valor para o campo (substitui)
        }
        public string Telefone
        {
            get { return telefone; } // Retorna o valor do campo 
            set { telefone = value; } //Define um novo valor para o campo (substitui)
        }

    }
    class GerenciadorDeContatos
    {
        private List<Contato> contatos = new List<Contato>(); //Cria um campo privado do tipo List para armazenar os contatos

        //Método para adicionar um novo contato
        public void AdicionarContato()
        {
            //Solicita o nome do contato ao usuário e armazena em uma variável local 
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            //Solicita o email do contato ao usuário e armazena em uma variável local 
            Console.WriteLine("E-mail: ");
            string email = Console.ReadLine();

            //Solicita o telefone do contato ao usuário e armazena em uma variável local 
            Console.WriteLine("Telefone: ");
            string telefone = Console.ReadLine();

            //Cria um novo objeto Contato com as informações fornecidas pelo usuário e adiciona à lista de contatos
            Contato novoContato = new Contato(nome, email, telefone);
            contatos.Add(novoContato);

            Console.WriteLine("Contato adicionado com sucesso!");
        }

        public void EditarContato()
        {
            Console.Write("Digite o nome do contato que deseja alterar: ");
            string nome = Console.ReadLine();

            //Procura o contato na lista de contatos pelo nome 
            Contato contatoParaAlterar = contatos.Find(contato => contato.Nome == nome);

            if (contatoParaAlterar != null)
            {

                Console.WriteLine("Nome: " + contatoParaAlterar.Nome);
                Console.WriteLine("E-mail: " + contatoParaAlterar.Email);
                Console.WriteLine("Telefone: " + contatoParaAlterar.Telefone);

                //Solicita o nome do contato ao usuário e armazena em uma variável local 
                Console.WriteLine("Novo Nome: ");
                contatoParaAlterar.Nome = Console.ReadLine();

                //Solicita o email do contato ao usuário e armazena em uma variável local 
                Console.WriteLine("Novo E-mail: ");
                contatoParaAlterar.Email = Console.ReadLine();

                //Solicita o telefone do contato ao usuário e armazena em uma variável local 
                Console.WriteLine("Novo Telefone: ");
                contatoParaAlterar.Telefone = Console.ReadLine();

                Console.WriteLine("Contato alterado com sucesso!");

            }
            else
            {
                Console.WriteLine("Contato não encontrado!");
            }

        }

        public void ExcluirContato()
        {
            Console.Write("Digite o nome do contato que deseja excluir: ");
            string nome = Console.ReadLine();

            Contato contatoParaExcluir = contatos.Find(contato => contato.Nome == nome);

            if (contatoParaExcluir != null)
            {
                contatos.Remove(contatoParaExcluir);
                Console.WriteLine("Contato excluído com sucesso!");

            }
            else
            {
                Console.WriteLine("Contato não encontrado!");
            }
        }

        public void ExibirContatos()
        {
            if (contatos.Count ==0)
            {
                Console.WriteLine("Nenhum contato encontrado.");
            }
            else
            {
                Console.WriteLine("--------------- Lista de Contatos ---------------- ");
                //Imprime os contatos salvos na lista
                foreach (Contato contato in contatos)
                {
                    Console.WriteLine("Nome: " + contato.Nome);
                    Console.WriteLine("E-mail: " + contato.Email);
                    Console.WriteLine("Telefone: " + contato.Telefone);
                    Console.WriteLine("---------------------------\n: ");
                }
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Cria uma instância da classe GerenciadorDeContato (ativar) 
            GerenciadorDeContatos gerenciadorDeContatos = new GerenciadorDeContatos();

            //Laço infinito para mostrar o menu opções 
            while (true)
            {
                //Imprime as opções do Menu
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adicionar contato");
                Console.WriteLine("2 - Editar contato");
                Console.WriteLine("3 - Excluir contato");
                Console.WriteLine("4 - Exibir os contatos");
                Console.WriteLine("0 - Sair");

                //Lê a opção escolhida pelo usuário
                int opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        gerenciadorDeContatos.AdicionarContato();
                        break;
                    case 2: 
                        gerenciadorDeContatos.EditarContato();
                        break;
                    case 3:
                        gerenciadorDeContatos.ExcluirContato();
                        break;
                    case 4:
                        gerenciadorDeContatos.ExibirContatos();
                        break;
                    case 0:
                        Environment.Exit(0); //Encerra o while
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                //Imprime uma linha em branco para separar a próxima execução do menu
                Console.WriteLine();
            }

        }
    }
}

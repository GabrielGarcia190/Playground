using System;
using System.Collections.Generic;

namespace BibliotecaBaguncada
{
    class Program
    {
        static List<Dictionary<string, object>> livros = new List<Dictionary<string, object>>();
        static List<Dictionary<string, object>> usuarios = new List<Dictionary<string, object>>();
        static List<Dictionary<string, object>> emprestimos = new List<Dictionary<string, object>>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 - Adicionar Livro");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Registrar Usuário");
                Console.WriteLine("4 - Emprestar Livro");
                Console.WriteLine("5 - Devolver Livro");
                Console.WriteLine("6 - Sair");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.WriteLine("Digite o título do livro:");
                    string titulo = Console.ReadLine();
                    Console.WriteLine("Digite o autor:");
                    string autor = Console.ReadLine();
                    Console.WriteLine("Digite o ISBN:");
                    string isbn = Console.ReadLine();
                    livros.Add(new Dictionary<string, object> { { "Titulo", titulo }, { "Autor", autor }, { "ISBN", isbn }, { "Disponivel", true } });
                }
                else if (opcao == "2")
                {
                    foreach (var livro in livros)
                    {
                        Console.WriteLine($"Título: {livro["Titulo"]}, Disponível: {livro["Disponivel"]}");
                    }
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Digite o nome do usuário:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite o CPF:");
                    string cpf = Console.ReadLine();
                    usuarios.Add(new Dictionary<string, object> { { "Nome", nome }, { "CPF", cpf }, { "Bloqueado", false } });
                }
                else if (opcao == "4")
                {
                    Console.WriteLine("Digite o CPF do usuário:");
                    string cpf = Console.ReadLine();
                    Console.WriteLine("Digite o ISBN do livro:");
                    string isbn = Console.ReadLine();

                    var usuario = usuarios.Find(u => (string)u["CPF"] == cpf);
                    var livro = livros.Find(l => (string)l["ISBN"] == isbn);

                    if (usuario == null || livro == null)
                    {
                        Console.WriteLine("Usuário ou livro não encontrado!");
                        continue;
                    }

                    if ((bool)livro["Disponivel"] && !(bool)usuario["Bloqueado"])
                    {
                        livro["Disponivel"] = false;
                        emprestimos.Add(new Dictionary<string, object>
                        {
                            { "CPF", cpf },
                            { "ISBN", isbn },
                            { "DataEmprestimo", DateTime.Now },
                            { "DataDevolucao", DateTime.Now.AddDays(14) }
                        });
                        Console.WriteLine("Livro emprestado!");
                    }
                    else
                    {
                        Console.WriteLine("Livro indisponível ou usuário bloqueado!");
                    }
                }
                else if (opcao == "5")
                {
                    Console.WriteLine("Digite o ISBN do livro:");
                    string isbn = Console.ReadLine();
                    var emprestimo = emprestimos.Find(e => (string)e["ISBN"] == isbn);
                    var livro = livros.Find(l => (string)l["ISBN"] == isbn);

                    if (emprestimo == null || livro == null)
                    {
                        Console.WriteLine("Empréstimo não encontrado!");
                        continue;
                    }

                    livro["Disponivel"] = true;
                    DateTime dataDevolucao = (DateTime)emprestimo["DataDevolucao"];
                    if (DateTime.Now > dataDevolucao)
                    {
                        int diasAtraso = (DateTime.Now - dataDevolucao).Days;
                        decimal multa = diasAtraso * 2.50m;
                        Console.WriteLine($"Multa de R${multa} por {diasAtraso} dias de atraso!");
                    }
                    emprestimos.Remove(emprestimo);
                    Console.WriteLine("Livro devolvido!");
                }
                else if (opcao == "6")
                {
                    break;
                }
            }
        }
    }
}
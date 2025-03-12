using System;
using System.Data.SQLite;

namespace ExemploCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbPath = "biblioteca.db";
            var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            connection.Open();

            // Criação de tabelas
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Livros (
                    ISBN TEXT PRIMARY KEY,
                    Titulo TEXT,
                    Autor TEXT,
                    Disponivel INTEGER
                );
                CREATE TABLE IF NOT EXISTS Usuarios (
                    CPF TEXT PRIMARY KEY,
                    Nome TEXT,
                    Bloqueado INTEGER
                );
                CREATE TABLE IF NOT EXISTS Emprestimos (
                    CPF TEXT,
                    ISBN TEXT,
                    DataEmprestimo TEXT,
                    DataDevolucao TEXT
                )";
            cmd.ExecuteNonQuery();

            while (true)
            {
                Console.WriteLine("\n1 - Adicionar Livro\n2 - Listar Livros\n3 - Registrar Usuário\n4 - Emprestar Livro\n5 - Devolver Livro\n6 - Sair");
                var opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.WriteLine("Título:");
                    var titulo = Console.ReadLine();
                    Console.WriteLine("Autor:");
                    var autor = Console.ReadLine();
                    Console.WriteLine("ISBN:");
                    var isbn = Console.ReadLine();
                    var insertCmd = connection.CreateCommand();
                    insertCmd.CommandText = $"INSERT INTO Livros VALUES ('{isbn}', '{titulo}', '{autor}', 1)";
                    insertCmd.ExecuteNonQuery();
                }
                else if (opcao == "2")
                {
                    var selectCmd = connection.CreateCommand();
                    selectCmd.CommandText = "SELECT * FROM Livros";
                    var reader = selectCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Livro: {reader["Titulo"]}, Disponível: {(Convert.ToInt32(reader["Disponivel"]) == 1 ? "Sim" : "Não")}");
                    }
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Nome:");
                    var nome = Console.ReadLine();
                    Console.WriteLine("CPF:");
                    var cpf = Console.ReadLine();
                    var insertCmd = connection.CreateCommand();
                    insertCmd.CommandText = $"INSERT INTO Usuarios VALUES ('{cpf}', '{nome}', 0)";
                    insertCmd.ExecuteNonQuery();
                }
                else if (opcao == "4")
                {
                    Console.WriteLine("CPF do usuário:");
                    var cpf = Console.ReadLine();
                    Console.WriteLine("ISBN do livro:");
                    var isbn = Console.ReadLine();

                    var checkUserCmd = connection.CreateCommand();
                    checkUserCmd.CommandText = $"SELECT Bloqueado FROM Usuarios WHERE CPF = '{cpf}'";
                    var user = checkUserCmd.ExecuteScalar();

                    var checkBookCmd = connection.CreateCommand();
                    checkBookCmd.CommandText = $"SELECT Disponivel FROM Livros WHERE ISBN = '{isbn}'";
                    var book = checkBookCmd.ExecuteScalar();

                    if (user == null || book == null || Convert.ToInt32(book) == 0)
                    {
                        Console.WriteLine("Não foi possível emprestar!");
                        continue;
                    }

                    var updateCmd = connection.CreateCommand();
                    updateCmd.CommandText = $"UPDATE Livros SET Disponivel = 0 WHERE ISBN = '{isbn}'";
                    updateCmd.ExecuteNonQuery();

                    var insertEmprestimoCmd = connection.CreateCommand();
                    insertEmprestimoCmd.CommandText = $"INSERT INTO Emprestimos VALUES ('{cpf}', '{isbn}', datetime('now'), datetime('now', '+14 days'))";
                    insertEmprestimoCmd.ExecuteNonQuery();
                }
                else if (opcao == "5")
                {
                    Console.WriteLine("ISBN do livro:");
                    var isbn = Console.ReadLine();

                    var getEmprestimoCmd = connection.CreateCommand();
                    getEmprestimoCmd.CommandText = $"SELECT DataDevolucao FROM Emprestimos WHERE ISBN = '{isbn}'";
                    var data = getEmprestimoCmd.ExecuteScalar();

                    if (data != null)
                    {
                        var devolucao = DateTime.Parse(data.ToString());
                        if (DateTime.Now > devolucao)
                        {
                            var dias = (DateTime.Now - devolucao).Days;
                            Console.WriteLine($"Multa de R${dias * 2.5m}!");
                        }
                    }

                    var updateCmd = connection.CreateCommand();
                    updateCmd.CommandText = $"UPDATE Livros SET Disponivel = 1 WHERE ISBN = '{isbn}'";
                    updateCmd.ExecuteNonQuery();

                    var deleteCmd = connection.CreateCommand();
                    deleteCmd.CommandText = $"DELETE FROM Emprestimos WHERE ISBN = '{isbn}'";
                    deleteCmd.ExecuteNonQuery();
                }
                else if (opcao == "6")
                {
                    break;
                }
            }

            connection.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FazendoUrbanaCRUD.BackEnd
{
    public static class Database
    {
        public static List<Funcionario> Funcionarios = new List<Funcionario>();
        public static List<Produto> Produtos = new List<Produto>();
        public static List<Venda> Vendas = new List<Venda>();

        private static readonly string connectionString = "Server=localhost;Database=FazendaUrbanaDB;User Id=Brenno.Oliveira;Password=Asp.Net12";

        // Método para adicionar um produto
        public static void AdicionarProduto(Produto produto)
        {
            produto.Id = Produtos.Count > 0 ? Produtos[Produtos.Count - 1].Id + 1 : 1;
            Produtos.Add(produto);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Produtos (Nome, Categoria, Preco, Quantidade) VALUES (@Nome, @Categoria, @Preco, @Quantidade)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@Categoria", produto.Categoria);
                    cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                    cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para atualizar um produto existente
        public static void AtualizarProduto(Produto produto)
        {
            var produtoExistente = Produtos.Find(p => p.Id == produto.Id);
            if (produtoExistente != null)
            {
                produtoExistente.Nome = produto.Nome;
                produtoExistente.Categoria = produto.Categoria;
                produtoExistente.Preco = produto.Preco;
                produtoExistente.Quantidade = produto.Quantidade;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Produtos SET Nome = @Nome, Categoria = @Categoria, Preco = @Preco, Quantidade = @Quantidade WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                        cmd.Parameters.AddWithValue("@Categoria", produto.Categoria);
                        cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                        cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                        cmd.Parameters.AddWithValue("@Id", produto.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Método para excluir um produto
        public static void ExcluirProduto(int id)
        {
            var produto = Produtos.Find(p => p.Id == id);
            if (produto != null)
            {
                Produtos.Remove(produto);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Produtos WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Método para adicionar uma venda
        public static void AdicionarVenda(Venda venda)
        {
            venda.Id = Vendas.Count > 0 ? Vendas[Vendas.Count - 1].Id + 1 : 1;
            Vendas.Add(venda);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Vendas (Data, Produto, Quantidade, Preco) VALUES (@Data, @Produto, @Quantidade, @Preco)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Data", venda.Data);
                    cmd.Parameters.AddWithValue("@Produto", venda.Produto);
                    cmd.Parameters.AddWithValue("@Quantidade", venda.Quantidade);
                    cmd.Parameters.AddWithValue("@Preco", venda.Preco);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para obter o histórico de vendas
        public static List<Venda> ObterHistoricoVendas()
        {
            if (Vendas.Count == 0)
            {
                Vendas.AddRange(new List<Venda>
                {
                    // Exemplo de vendas aqui
                });
            }

            return Vendas;
        }

        // Método para adicionar um funcionário
        public static void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionario.Id = Funcionarios.Count > 0 ? Funcionarios[Funcionarios.Count - 1].Id + 1 : 1;
            Funcionarios.Add(funcionario);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Funcionarios (Nome, Cargo, Salario) VALUES (@Nome, @Cargo, @Salario)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                    cmd.Parameters.AddWithValue("@Salario", funcionario.Salario);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para atualizar um funcionário existente
        public static void AtualizarFuncionario(Funcionario funcionario)
        {
            var funcionarioExistente = Funcionarios.Find(f => f.Id == funcionario.Id);
            if (funcionarioExistente != null)
            {
                funcionarioExistente.Nome = funcionario.Nome;
                funcionarioExistente.Cargo = funcionario.Cargo;
                funcionarioExistente.Salario = funcionario.Salario;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Funcionarios SET Nome = @Nome, Cargo = @Cargo, Salario = @Salario WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                        cmd.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                        cmd.Parameters.AddWithValue("@Salario", funcionario.Salario);
                        cmd.Parameters.AddWithValue("@Id", funcionario.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Método para excluir um funcionário
        public static void ExcluirFuncionario(int id)
        {
            var funcionario = Funcionarios.Find(f => f.Id == id);
            if (funcionario != null)
            {
                Funcionarios.Remove(funcionario);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Funcionarios WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}

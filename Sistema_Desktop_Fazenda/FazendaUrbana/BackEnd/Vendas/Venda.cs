using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class Venda
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public string Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal Preco { get; set; }
    public decimal Total => Quantidade * Preco;

    private string connectionString = "SuaStringDeConexaoAqui"; // Insira sua string de conexão aqui

    // Método para salvar uma nova venda no banco
    public void Salvar()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Vendas (Data, Produto, Quantidade, Preco) VALUES (@Data, @Produto, @Quantidade, @Preco)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Data", Data);
            command.Parameters.AddWithValue("@Produto", Produto);
            command.Parameters.AddWithValue("@Quantidade", Quantidade);
            command.Parameters.AddWithValue("@Preco", Preco);

            command.ExecuteNonQuery();
        }
    }

    // Método para carregar todas as vendas do banco
    public static List<Venda> CarregarVendas()
    {
        var vendas = new List<Venda>();
        string connectionString = "SuaStringDeConexaoAqui"; // Insira sua string de conexão aqui

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT Id, Data, Produto, Quantidade, Preco FROM Vendas";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                vendas.Add(new Venda
                {
                    Id = reader.GetInt32(0),
                    Data = reader.GetDateTime(1),
                    Produto = reader.GetString(2),
                    Quantidade = reader.GetInt32(3),
                    Preco = reader.GetDecimal(4)
                });
            }
        }

        return vendas;
    }
}

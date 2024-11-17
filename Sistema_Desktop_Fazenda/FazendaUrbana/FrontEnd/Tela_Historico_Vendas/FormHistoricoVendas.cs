using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient; // Para a conexão SQL
using FazendoUrbanaCRUD.BackEnd;

namespace FazendoUrbanaCRUD.FrontEnd
{
    public partial class FormHistoricoVendas : Form
    {
        public FormHistoricoVendas()
        {
            InitializeComponent();
            CarregarHistoricoVendas();
        }

        // Método para carregar o histórico de vendas no DataGridView
        private void CarregarHistoricoVendas()
        {
            dgvHistoricoVendas.DataSource = null;
            dgvHistoricoVendas.DataSource = Database.ObterHistoricoVendas(); // Obter dados do banco
        }

        // Evento ao clicar no botão de aplicar filtro
        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            FiltrarHistoricoVendas();
        }

        // Método para filtrar e ordenar o histórico de vendas
        private void FiltrarHistoricoVendas()
        {
            List<Venda> vendas = Database.ObterHistoricoVendas(); // Obter dados do banco novamente

            // Filtrar e ordenar com base nas seleções
            switch (cbFiltro.SelectedItem?.ToString())
            {
                case "Data":
                    vendas = cbOrdem.SelectedItem?.ToString() == "Ascendente" 
                        ? vendas.OrderBy(v => v.Data).ToList()
                        : vendas.OrderByDescending(v => v.Data).ToList();
                    break;
                case "Nome":
                    vendas = cbOrdem.SelectedItem?.ToString() == "Ascendente" 
                        ? vendas.OrderBy(v => v.Produto).ToList()
                        : vendas.OrderByDescending(v => v.Produto).ToList();
                    break;
                case "Quantidade":
                    vendas = cbOrdem.SelectedItem?.ToString() == "Ascendente" 
                        ? vendas.OrderBy(v => v.Quantidade).ToList()
                        : vendas.OrderByDescending(v => v.Quantidade).ToList();
                    break;
                case "Preço":
                    vendas = cbOrdem.SelectedItem?.ToString() == "Ascendente" 
                        ? vendas.OrderBy(v => v.Preco).ToList()
                        : vendas.OrderByDescending(v => v.Preco).ToList();
                    break;
            }

            dgvHistoricoVendas.DataSource = null;
            dgvHistoricoVendas.DataSource = vendas;
        }
    }

    // Classe Database para conexão com o banco
    public static class Database
    {
        private static string connectionString = "Server=localhost;Database=FazendaUrbanaDB;User Id=Brenno.Oliveira;Password=Asp.Net12;";

        // Método para obter o histórico de vendas do banco de dados
        public static List<Venda> ObterHistoricoVendas()
        {
            List<Venda> vendas = new List<Venda>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ProdutoId, Data, Produto, Quantidade, Preco FROM Vendas";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Venda venda = new Venda
                    {
                        Id = (int)reader["Id"],
                        Data = (DateTime)reader["Data"],
                        Produto = reader["Produto"].ToString(),
                        Quantidade = (int)reader["Quantidade"],
                        Preco = (decimal)reader["Preco"]
                    };
                    vendas.Add(venda);
                }
            }

            return vendas;
        }
    }
}

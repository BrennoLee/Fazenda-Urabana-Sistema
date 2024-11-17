using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using FazendoUrbanaCRUD.BackEnd;

namespace FazendoUrbanaCRUD.FrontEnd
{
    public partial class FormProduto : Form
    {
        private List<Produto> produtos;
        private Produto produtoSelecionado;
        private string connectionString = "Server=localhost;Database=FazendaUrbanaDB;User Id=Brenno.Oliveira;Password=Asp.Net12"; 
        public FormProduto()
        {
            InitializeComponent();
            produtos = new List<Produto>();
            produtoSelecionado = null;

            // Populando o ComboBox com as categorias
            cmbCategoriaProduto.Items.AddRange(new string[] { "Fruta", "Legume", "Verdura", "Grãos" });

            CarregarProdutosDoBanco(); // Carrega os produtos do banco ao iniciar
            AtualizarGrid();
        }

        private void CarregarProdutosDoBanco()
        {
            produtos.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ProdutoID, Nome, Categoria, Preco, Quantidade FROM Produtos";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    produtos.Add(new Produto
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Categoria = reader.GetString(2),
                        Preco = reader.GetDecimal(3),
                        Quantidade = reader.GetInt32(4)
                    });
                }
            }
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                // Pegando os dados do formulário
                string nome = txtNomeProduto.Text;
                string categoria = cmbCategoriaProduto.SelectedItem.ToString();
                decimal preco = decimal.Parse(txtPrecoProduto.Text);
                int quantidade = 0;

                Produto novoProduto = new Produto(nome, categoria, preco, quantidade);
                produtos.Add(novoProduto);

                // Adiciona o produto ao banco
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Produtos (Nome, Categoria, Preco, Quantidade) VALUES (@Nome, @Categoria, @Preco, @Quantidade)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Categoria", categoria);
                    command.Parameters.AddWithValue("@Preco", preco);
                    command.Parameters.AddWithValue("@Quantidade", quantidade);
                    command.ExecuteNonQuery();
                }

                LimparFormulario();
                CarregarProdutosDoBanco(); // Atualiza a lista a partir do banco
                AtualizarGrid();
                MessageBox.Show("Produto adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar produto: " + ex.Message);
            }
        }

        private void btnEditProduto_Click(object sender, EventArgs e)
        {
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto para editar.");
                return;
            }

            try
            {
                produtoSelecionado.Nome = txtNomeProduto.Text;
                produtoSelecionado.Categoria = cmbCategoriaProduto.SelectedItem.ToString();
                produtoSelecionado.Preco = decimal.Parse(txtPrecoProduto.Text);

                // Atualiza o produto no banco
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Produtos SET Nome = @Nome, Categoria = @Categoria, Preco = @Preco WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", produtoSelecionado.Id);
                    command.Parameters.AddWithValue("@Nome", produtoSelecionado.Nome);
                    command.Parameters.AddWithValue("@Categoria", produtoSelecionado.Categoria);
                    command.Parameters.AddWithValue("@Preco", produtoSelecionado.Preco);
                    command.ExecuteNonQuery();
                }

                CarregarProdutosDoBanco();
                AtualizarGrid();
                MessageBox.Show("Produto editado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar produto: " + ex.Message);
            }
        }

        private void btnDeleteProduto_Click(object sender, EventArgs e)
        {
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            try
            {
                // Remove o produto do banco
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Produtos WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", produtoSelecionado.Id);
                    command.ExecuteNonQuery();
                }

                produtos.Remove(produtoSelecionado);
                LimparFormulario();
                CarregarProdutosDoBanco();
                AtualizarGrid();
                MessageBox.Show("Produto excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message);
            }
        }

        private void AtualizarGrid()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = produtos;
        }

        private void LimparFormulario()
        {
            txtNomeProduto.Clear();
            cmbCategoriaProduto.SelectedIndex = -1;
            txtPrecoProduto.Clear();
            produtoSelecionado = null;
        }

        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int indice = dgvProdutos.SelectedRows[0].Index;
                produtoSelecionado = produtos[indice];

                txtNomeProduto.Text = produtoSelecionado.Nome;
                cmbCategoriaProduto.SelectedItem = produtoSelecionado.Categoria;
                txtPrecoProduto.Text = produtoSelecionado.Preco.ToString("F2");
            }
        }
    }
}

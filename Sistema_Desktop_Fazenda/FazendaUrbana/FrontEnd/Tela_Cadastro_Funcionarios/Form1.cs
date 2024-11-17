using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FazendoUrbanaCRUD.BackEnd;

namespace FazendoUrbanaCRUD.FrontEnd
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Server=localhost;Database=FazendaUrbanaDB;User Id=Brenno.Oliveira;Password=Asp.Net12";
        private List<Funcionario> funcionarios; // Lista para armazenar funcionários temporariamente

        public Form1()
        {
            InitializeComponent();
            funcionarios = new List<Funcionario>();
            CarregarFuncionariosDoBanco(); // Inicializa a tabela com dados do banco
        }

        private void btnOpenFormProduto_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.ShowDialog();
        }

        // Carrega funcionários do banco de dados
        private void CarregarFuncionariosDoBanco()
        {
            funcionarios.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT FuncionarioID, Nome, Cargo, Salario FROM Funcionarios";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    funcionarios.Add(new Funcionario
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Cargo = reader.GetString(2),
                        Salario = reader.GetDecimal(3)
                    });
                }
                reader.Close();
            }
            AtualizarTabela();
        }

        // Evento do botão de Adicionar
        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cargo = txtCargo.Text;
            decimal salario;

            if (decimal.TryParse(txtSalario.Text, out salario))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Funcionarios (Nome, Cargo, Salario) VALUES (@Nome, @Cargo, @Salario)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Cargo", cargo);
                    command.Parameters.AddWithValue("@Salario", salario);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                CarregarFuncionariosDoBanco();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido para o salário.");
            }
        }

        private void btnOpenHistoricoVendas_Click(object sender, EventArgs e)
        {
            var formHistoricoVendas = new FormHistoricoVendas();
            formHistoricoVendas.Show();
        }

        // Evento do botão de Editar
        private void btnEditFuncionario_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.SelectedRows.Count > 0)
            {
                var selectedRow = dgvFuncionarios.SelectedRows[0];
                var funcionarioId = (int)selectedRow.Cells[0].Value;

                string nome = txtNome.Text;
                string cargo = txtCargo.Text;
                if (decimal.TryParse(txtSalario.Text, out decimal salario))
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Funcionarios SET Nome = @Nome, Cargo = @Cargo, Salario = @Salario WHERE Id = @Id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Cargo", cargo);
                        command.Parameters.AddWithValue("@Salario", salario);
                        command.Parameters.AddWithValue("@Id", funcionarioId);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    CarregarFuncionariosDoBanco();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Por favor, insira um valor válido para o salário.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um funcionário para editar.");
            }
        }

        // Evento do botão de Excluir
        private void btnDeleteFuncionario_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.SelectedRows.Count > 0)
            {
                var selectedRow = dgvFuncionarios.SelectedRows[0];
                var funcionarioId = (int)selectedRow.Cells[0].Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Funcionarios WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", funcionarioId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                CarregarFuncionariosDoBanco();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um funcionário para excluir.");
            }
        }

        // Atualiza a tabela (DataGridView) com dados atualizados
        private void AtualizarTabela()
        {
            dgvFuncionarios.DataSource = null;
            dgvFuncionarios.DataSource = funcionarios;
        }

        // Limpa os campos de entrada após adicionar/editar/excluir
        private void LimparCampos()
        {
            txtNome.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
        }

        // Evento para selecionar um funcionário para edição
        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvFuncionarios.Rows[e.RowIndex];
                var funcionarioId = (int)selectedRow.Cells[0].Value;

                var funcionario = funcionarios.Find(f => f.Id == funcionarioId);
                if (funcionario != null)
                {
                    txtNome.Text = funcionario.Nome;
                    txtCargo.Text = funcionario.Cargo;
                    txtSalario.Text = funcionario.Salario.ToString("F2");
                }
            }
        }
    }
}

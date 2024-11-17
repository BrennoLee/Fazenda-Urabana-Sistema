namespace FazendoUrbanaCRUD.FrontEnd
{
    partial class FormProduto
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOpenHistoricoVendas;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnEditProduto;
        private System.Windows.Forms.Button btnDeleteProduto;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox groupBoxCadastroProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblCategoriaProduto;
        private System.Windows.Forms.Label lblPrecoProduto;
        private System.Windows.Forms.Label lblQuantidadeProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.ComboBox cmbCategoriaProduto;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.btnEditProduto = new System.Windows.Forms.Button();
            this.btnDeleteProduto = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.groupBoxCadastroProduto = new System.Windows.Forms.GroupBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblCategoriaProduto = new System.Windows.Forms.Label();
            this.lblPrecoProduto = new System.Windows.Forms.Label();
            this.lblQuantidadeProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.cmbCategoriaProduto = new System.Windows.Forms.ComboBox();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();

            // Ajustando os componentes
            // btnAddProduto
            this.btnAddProduto.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddProduto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddProduto.Location = new System.Drawing.Point(650, 30);
            this.btnAddProduto.Size = new System.Drawing.Size(120, 40);
            this.btnAddProduto.Text = "Adicionar";
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);

            // btnEditProduto
            this.btnEditProduto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditProduto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditProduto.Location = new System.Drawing.Point(650, 80);
            this.btnEditProduto.Size = new System.Drawing.Size(120, 40);
            this.btnEditProduto.Text = "Editar";
            this.btnEditProduto.Click += new System.EventHandler(this.btnEditProduto_Click);

            // btnDeleteProduto
            this.btnDeleteProduto.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteProduto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteProduto.Location = new System.Drawing.Point(650, 130);
            this.btnDeleteProduto.Size = new System.Drawing.Size(120, 40);
            this.btnDeleteProduto.Text = "Excluir";
            this.btnDeleteProduto.Click += new System.EventHandler(this.btnDeleteProduto_Click);

            // dgvProdutos
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(20, 230);
            this.dgvProdutos.Size = new System.Drawing.Size(680, 250);

            // groupBoxCadastroProduto
            this.groupBoxCadastroProduto.Controls.Add(this.lblNomeProduto);
            this.groupBoxCadastroProduto.Controls.Add(this.lblCategoriaProduto);
            this.groupBoxCadastroProduto.Controls.Add(this.lblPrecoProduto);
            this.groupBoxCadastroProduto.Controls.Add(this.lblQuantidadeProduto);
            this.groupBoxCadastroProduto.Controls.Add(this.txtNomeProduto);
            this.groupBoxCadastroProduto.Controls.Add(this.cmbCategoriaProduto);
            this.groupBoxCadastroProduto.Controls.Add(this.txtPrecoProduto);
            this.groupBoxCadastroProduto.Controls.Add(this.txtQuantidadeProduto);
            this.groupBoxCadastroProduto.Location = new System.Drawing.Point(20, 10);
            this.groupBoxCadastroProduto.Size = new System.Drawing.Size(600, 200); // Ajustado para 200

            // lblNomeProduto
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(30, 30);
            this.lblNomeProduto.Size = new System.Drawing.Size(100, 13);
            this.lblNomeProduto.Text = "Nome:";

            // lblCategoriaProduto
            this.lblCategoriaProduto.AutoSize = true;
            this.lblCategoriaProduto.Location = new System.Drawing.Point(30, 70);
            this.lblCategoriaProduto.Size = new System.Drawing.Size(58, 13);
            this.lblCategoriaProduto.Text = "Categoria:";

            // lblPrecoProduto
            this.lblPrecoProduto.AutoSize = true;
            this.lblPrecoProduto.Location = new System.Drawing.Point(30, 110);
            this.lblPrecoProduto.Size = new System.Drawing.Size(40, 13);
            this.lblPrecoProduto.Text = "Preço:";

            // lblQuantidadeProduto
            this.lblQuantidadeProduto.AutoSize = true;
            this.lblQuantidadeProduto.Location = new System.Drawing.Point(20, 150);
            this.lblQuantidadeProduto.Size = new System.Drawing.Size(70, 13);
            this.lblQuantidadeProduto.Text = "Quantidade:";

            // txtNomeProduto
            this.txtNomeProduto.Location = new System.Drawing.Point(100, 30);
            this.txtNomeProduto.Size = new System.Drawing.Size(200, 20);

            // cmbCategoriaProduto
            this.cmbCategoriaProduto.Location = new System.Drawing.Point(100, 70);
            this.cmbCategoriaProduto.Size = new System.Drawing.Size(200, 21);

            // txtPrecoProduto
            this.txtPrecoProduto.Location = new System.Drawing.Point(100, 110);
            this.txtPrecoProduto.Size = new System.Drawing.Size(200, 20);

            // txtQuantidadeProduto
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(100, 150);
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(200, 20);

            // Ajustando o visual do formulário
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.groupBoxCadastroProduto);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnDeleteProduto);
            this.Controls.Add(this.btnEditProduto);
            this.Controls.Add(this.btnAddProduto);
            this.Name = "FormProduto";
            this.Text = "Cadastro de Produtos";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.groupBoxCadastroProduto.ResumeLayout(false);
            this.groupBoxCadastroProduto.PerformLayout();
            this.ResumeLayout(false);
                        this.btnOpenHistoricoVendas = new System.Windows.Forms.Button();
            this.btnOpenHistoricoVendas.BackColor = System.Drawing.Color.LightCoral;
            this.btnOpenHistoricoVendas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnOpenHistoricoVendas.Location = new System.Drawing.Point(780, 30); // Posição logo abaixo de btnOpenFormProduto
            this.btnOpenHistoricoVendas.Name = "btnOpenHistoricoVendas";
            this.btnOpenHistoricoVendas.Size = new System.Drawing.Size(120, 40);
            this.btnOpenHistoricoVendas.TabIndex = 7;
            this.btnOpenHistoricoVendas.Text = "Histórico de Vendas";
            this.btnOpenHistoricoVendas.UseVisualStyleBackColor = false;
            this.btnOpenHistoricoVendas.Click += new System.EventHandler(this.btnOpenHistoricoVendas_Click);

            // Adiciona o botão ao formulário
            this.Controls.Add(this.btnOpenHistoricoVendas);

        }
    }
}

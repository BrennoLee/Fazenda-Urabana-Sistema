namespace FazendoUrbanaCRUD.FrontEnd
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddFuncionario;
        private System.Windows.Forms.Button btnOpenHistoricoVendas;
        private System.Windows.Forms.Button btnEditFuncionario;
        private System.Windows.Forms.Button btnDeleteFuncionario;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.GroupBox groupBoxCadastro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtSalario;
        
        // Novo botão para abrir o FormProduto
        private System.Windows.Forms.Button btnOpenFormProduto;

        // Método InitializeComponent para configurar os controles do formulário
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddFuncionario = new System.Windows.Forms.Button();
            this.btnEditFuncionario = new System.Windows.Forms.Button();
            this.btnDeleteFuncionario = new System.Windows.Forms.Button();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.groupBoxCadastro = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();

            // Novo botão btnOpenFormProduto
            this.btnOpenFormProduto = new System.Windows.Forms.Button();
            

            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.groupBoxCadastro.SuspendLayout();
            this.SuspendLayout();

            // 
            // btnAddFuncionario
            // 
            this.btnAddFuncionario.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddFuncionario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddFuncionario.Location = new System.Drawing.Point(650, 30);
            this.btnAddFuncionario.Name = "btnAddFuncionario";
            this.btnAddFuncionario.Size = new System.Drawing.Size(120, 40);
            this.btnAddFuncionario.TabIndex = 1;
            this.btnAddFuncionario.Text = "Adicionar";
            this.btnAddFuncionario.UseVisualStyleBackColor = false;
            this.btnAddFuncionario.Click += new System.EventHandler(this.btnAddFuncionario_Click);
            
            // 
            // btnEditFuncionario
            // 
            this.btnEditFuncionario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditFuncionario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditFuncionario.Location = new System.Drawing.Point(650, 80);
            this.btnEditFuncionario.Name = "btnEditFuncionario";
            this.btnEditFuncionario.Size = new System.Drawing.Size(120, 40);
            this.btnEditFuncionario.TabIndex = 2;
            this.btnEditFuncionario.Text = "Editar";
            this.btnEditFuncionario.UseVisualStyleBackColor = false;
            this.btnEditFuncionario.Click += new System.EventHandler(this.btnEditFuncionario_Click);

            // 
            // btnDeleteFuncionario
            // 
            this.btnDeleteFuncionario.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteFuncionario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteFuncionario.Location = new System.Drawing.Point(650, 130);
            this.btnDeleteFuncionario.Name = "btnDeleteFuncionario";
            this.btnDeleteFuncionario.Size = new System.Drawing.Size(120, 40);
            this.btnDeleteFuncionario.TabIndex = 3;
            this.btnDeleteFuncionario.Text = "Excluir";
            this.btnDeleteFuncionario.UseVisualStyleBackColor = false;
            this.btnDeleteFuncionario.Click += new System.EventHandler(this.btnDeleteFuncionario_Click);

            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(20, 200);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(750, 250);
            this.dgvFuncionarios.TabIndex = 4;

            // 
            // groupBoxCadastro
            // 
            this.groupBoxCadastro.Controls.Add(this.lblNome);
            this.groupBoxCadastro.Controls.Add(this.lblCargo);
            this.groupBoxCadastro.Controls.Add(this.lblSalario);
            this.groupBoxCadastro.Controls.Add(this.txtNome);
            this.groupBoxCadastro.Controls.Add(this.txtCargo);
            this.groupBoxCadastro.Controls.Add(this.txtSalario);
            this.groupBoxCadastro.Location = new System.Drawing.Point(20, 30);
            this.groupBoxCadastro.Name = "groupBoxCadastro";
            this.groupBoxCadastro.Size = new System.Drawing.Size(600, 150);
            this.groupBoxCadastro.TabIndex = 5;
            this.groupBoxCadastro.TabStop = false;
            this.groupBoxCadastro.Text = "Cadastro de Funcionário";

            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";

            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(20, 70);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(39, 13);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo:";

            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(20, 110);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(46, 13);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário:";

            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 3;

            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(100, 70);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(200, 20);
            this.txtCargo.TabIndex = 4;

            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(100, 110);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(200, 20);
            this.txtSalario.TabIndex = 5;

            // 
            // btnOpenFormProduto
            // 
            this.btnOpenFormProduto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOpenFormProduto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnOpenFormProduto.Location = new System.Drawing.Point(780, 30); // Agora alinhado com o btnAddFuncionario
            this.btnOpenFormProduto.Name = "btnOpenFormProduto";
            this.btnOpenFormProduto.Size = new System.Drawing.Size(120, 40);
            this.btnOpenFormProduto.TabIndex = 6;
            this.btnOpenFormProduto.Text = "Gerenciar Produtos";
            this.btnOpenFormProduto.UseVisualStyleBackColor = false;
            this.btnOpenFormProduto.Click += new System.EventHandler(this.btnOpenFormProduto_Click);

            // Adiciona o botão ao formulário
            this.Controls.Add(this.btnOpenFormProduto);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.groupBoxCadastro);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnDeleteFuncionario);
            this.Controls.Add(this.btnEditFuncionario);
            this.Controls.Add(this.btnAddFuncionario);
            this.Name = "Form1";
            this.Text = "Cadastro de Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.groupBoxCadastro.ResumeLayout(false);
            this.groupBoxCadastro.PerformLayout();
            this.ResumeLayout(false);

            // Botão para abrir o histórico de vendas
            this.btnOpenHistoricoVendas = new System.Windows.Forms.Button();
            this.btnOpenHistoricoVendas.BackColor = System.Drawing.Color.LightCoral;
            this.btnOpenHistoricoVendas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnOpenHistoricoVendas.Location = new System.Drawing.Point(780, 80); // Posição logo abaixo de btnOpenFormProduto
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

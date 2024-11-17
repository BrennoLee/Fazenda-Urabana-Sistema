namespace FazendoUrbanaCRUD.FrontEnd
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnConectar;

        // Método InitializeComponent
        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnConectar);
            this.Name = "FormLogin";
            this.Text = "Bem-vindo ao sistema de Gerenciamento AgroTech"; // Título da janela
            this.Load += new System.EventHandler(this.Titulo_Login);
            this.ResumeLayout(false);
            this.PerformLayout();

            this.components = new System.ComponentModel.Container();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();

            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblLogin.Location = new System.Drawing.Point(100, 50);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(50, 16);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login:";

            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblSenha.Location = new System.Drawing.Point(100, 100);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(55, 16);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";

            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(160, 50);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(200, 20);
            this.txtLogin.TabIndex = 2;

            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(160, 100);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(200, 20);
            this.txtSenha.TabIndex = 3;

            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnConectar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnConectar.Location = new System.Drawing.Point(160, 150);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(120, 40);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);

            // 
            // FormLogin
            // 
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnConectar);
            this.Name = "FormLogin";
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

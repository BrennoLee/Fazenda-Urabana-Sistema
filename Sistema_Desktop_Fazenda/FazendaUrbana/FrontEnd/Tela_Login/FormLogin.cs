using System;
using System.Windows.Forms;
using System.Drawing;

namespace FazendoUrbanaCRUD.FrontEnd
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // Evento de carregamento do formulário
        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = System.Drawing.Image.FromFile("Login.jpeg");

 // Caminho da imagem de fundo
            this.BackgroundImageLayout = ImageLayout.Stretch; // Ajusta o layout da imagem para cobrir toda a tela
        }

        private void Titulo_Login(object sender, EventArgs e)
        {
            this.Text = "Bem-vindo ao sistema de Gerenciamento AgroTech";
        }

        // Evento de clique no botão "Conectar"
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin.tech" && txtSenha.Text == "1234")
            {
                Form1 form1 = new Form1(); // Abre a tela principal
                form1.Show();
                this.Hide(); // Esconde a tela de login
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos!"); // Mensagem de erro
            }
        }
    }
}

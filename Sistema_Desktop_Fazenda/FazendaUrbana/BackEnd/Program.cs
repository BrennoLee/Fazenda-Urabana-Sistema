using System;
using System.Windows.Forms;
using FazendoUrbanaCRUD.FrontEnd;  // Importando o namespace da interface

namespace FazendoUrbanaCRUD  // Namespace principal do seu projeto
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin()); // Inicializa o FormLogin
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

namespace LSoft
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Configurações padrão do WinForms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Caminho do banco na pasta DataAccess dentro do projeto
            string pastaBanco = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataAccess");
            string caminhoBanco = Path.Combine(pastaBanco, "supermercado.db");

            // Verifica se o banco existe
            if (!File.Exists(caminhoBanco))
            {
                MessageBox.Show(
                    "Banco de dados não encontrado!\nCertifique-se de que 'supermercado.db' esteja na pasta 'DataAccess' do aplicativo.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // Sai do aplicativo
            }

            // Inicializa o Form principal
            Application.Run(new MainForm());
        }
    }
}

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

            // Caminho do banco fixo na pasta do projeto
            string pastaBanco = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\DataAccess\");
            string caminhoBanco = Path.Combine(pastaBanco, "supermercado.db");

            // Checa se o banco existe
            if (!File.Exists(caminhoBanco))
            {
                MessageBox.Show(
                    "Banco de dados não encontrado!\nCertifique-se de que 'supermercado.db' esteja na pasta 'DataAccess' do projeto.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // Sai do aplicativo
            }

            // Aqui você pode inicializar serviços que usam o banco, se quiser
            // Exemplo:
            // var db = new DatabaseService(caminhoBanco);

            // Inicializa o Form principal
            Application.Run(new Form1());
        }
    }
}

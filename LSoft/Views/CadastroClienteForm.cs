using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace LSoft.Views
{
    public partial class CadastroClienteForm : Form
    {
        private string connectionString;

        public CadastroClienteForm()
        {
            InitializeComponent();

            // Cria o caminho dinâmico do banco na pasta DataAccess
            string pastaBanco = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataAccess");
            string caminhoBanco = Path.Combine(pastaBanco, "supermercado.db");
            connectionString = $"Data Source={caminhoBanco}";

            // Associa o evento Load do formulário
            this.Load += CadastroClienteForm_Load;
        }

        // Evento Load do formulário
        private void CadastroClienteForm_Load(object? sender, EventArgs e)
        {
            CarregarClientes();
        }

        // Método que carrega os clientes no DataGridView
        private void CarregarClientes()
        {
            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
SELECT 
    Id,
    Nome,
    Documento,
    Telefone,
    Email,
    Endereco,
    TipoCliente,
    DataCadastro
FROM Cliente
ORDER BY Nome;
";

                    using (var cmd = new SqliteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dgvClientes.DataSource = dt;

                        // Configura cabeçalhos e oculta ID
                        dgvClientes.Columns["Nome"].HeaderText = "Nome";
                        dgvClientes.Columns["Documento"].HeaderText = "CPF/CNPJ";
                        dgvClientes.Columns["Telefone"].HeaderText = "Telefone";
                        dgvClientes.Columns["Email"].HeaderText = "E-mail";
                        dgvClientes.Columns["Endereco"].HeaderText = "Endereço";
                        dgvClientes.Columns["TipoCliente"].HeaderText = "Tipo";
                        dgvClientes.Columns["DataCadastro"].HeaderText = "Cadastro";
                        dgvClientes.Columns["Id"].Visible = false;

                        dgvClientes.AllowUserToAddRows = false;
                        dgvClientes.RowHeadersVisible = false;
                        dgvClientes.ReadOnly = true;
                        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        // Eventos de labels (se houver)
        private void label2_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

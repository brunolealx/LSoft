using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace LSoft.Views
{
    public partial class EstoqueForm : Form
    {
        private string connectionString;

        public EstoqueForm()
        {
            InitializeComponent();

            // Cria o caminho dinâmico do banco na pasta DataAccess
            string pastaBanco = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataAccess");
            string caminhoBanco = Path.Combine(pastaBanco, "supermercado.db");
            connectionString = $"Data Source={caminhoBanco}";

            this.Load += EstoqueForm_Load;
        }

        private void EstoqueForm_Load(object? sender, EventArgs e)
        {
            CarregarEstoqueMovimentos();
        }

        private void CarregarEstoqueMovimentos()
        {
            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
SELECT 
    EM.Id,
    P.Nome AS Produto,
    EM.TipoMovimento,
    EM.Quantidade,
    EM.DataHora,
    EM.UsuarioId AS Usuario,
    EM.MotivoMovimento,
    EM.ReferenciaId
FROM EstoqueMovimento EM
LEFT JOIN Produto P ON EM.ProdutoId = P.Id
ORDER BY EM.DataHora DESC;
";

                    using (var cmd = new SqliteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dgvEstoqueMovimento.DataSource = dt;

                        dgvEstoqueMovimento.Columns["Produto"].HeaderText = "Produto";
                        dgvEstoqueMovimento.Columns["TipoMovimento"].HeaderText = "Tipo";
                        dgvEstoqueMovimento.Columns["Quantidade"].HeaderText = "Quantidade";
                        dgvEstoqueMovimento.Columns["DataHora"].HeaderText = "Data / Hora";
                        dgvEstoqueMovimento.Columns["Usuario"].HeaderText = "Usuário (ID)";
                        dgvEstoqueMovimento.Columns["MotivoMovimento"].HeaderText = "Motivo";
                        dgvEstoqueMovimento.Columns["ReferenciaId"].HeaderText = "Referência";
                        dgvEstoqueMovimento.Columns["Id"].Visible = false;

                        dgvEstoqueMovimento.AllowUserToAddRows = false;
                        dgvEstoqueMovimento.RowHeadersVisible = false;
                        dgvEstoqueMovimento.ReadOnly = true;
                        dgvEstoqueMovimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvEstoqueMovimento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar movimentos de estoque: " + ex.Message);
            }
        }
    }
}

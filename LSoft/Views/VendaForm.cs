using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace LSoft.Views
{
    public partial class VendaForm : Form
    {
        private string connectionString;
        private int vendaAtualId; // Id da venda que você quer exibir

        public VendaForm(int vendaId)
        {
            InitializeComponent();

            vendaAtualId = vendaId;

            // Cria o caminho dinâmico do banco na pasta DataAccess
            string pastaBanco = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataAccess");
            string caminhoBanco = Path.Combine(pastaBanco, "supermercado.db");
            connectionString = $"Data Source={caminhoBanco}";

            this.Load += VendaForm_Load;
        }

        private void VendaForm_Load(object? sender, EventArgs e)
        {
            CarregarItensVenda();
        }

        private void CarregarItensVenda()
        {
            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
SELECT 
    vi.Id,
    vi.ProdutoId,
    p.Nome AS NomeProduto,
    vi.Quantidade,
    vi.PrecoUnitario,
    vi.DescontoItem,
    vi.Subtotal
FROM VendaItem vi
LEFT JOIN Produto p ON vi.ProdutoId = p.Id
WHERE vi.VendaId = @VendaId
ORDER BY vi.Id;
";

                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@VendaId", vendaAtualId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            dgvVendaItem.DataSource = dt;

                            // Configura cabeçalhos e oculta Id interno
                            dgvVendaItem.Columns["NomeProduto"].HeaderText = "Produto";
                            dgvVendaItem.Columns["Quantidade"].HeaderText = "Quantidade";
                            dgvVendaItem.Columns["PrecoUnitario"].HeaderText = "Preço Unitário";
                            dgvVendaItem.Columns["DescontoItem"].HeaderText = "Desconto";
                            dgvVendaItem.Columns["Subtotal"].HeaderText = "Subtotal";
                            dgvVendaItem.Columns["Id"].Visible = false;
                            dgvVendaItem.Columns["ProdutoId"].Visible = false;

                            dgvVendaItem.AllowUserToAddRows = false;
                            dgvVendaItem.RowHeadersVisible = false;
                            dgvVendaItem.ReadOnly = true;
                            dgvVendaItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dgvVendaItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar itens da venda: " + ex.Message);
            }
        }

        private void dgvVendaItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Por enquanto vazio, pode implementar lógica depois
        }
    }
}

using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace LSoft.Views
{
    public partial class CadastroProdutoForm : Form
    {
        private string connectionString;

        public CadastroProdutoForm()
        {
            InitializeComponent();

            // Cria o caminho dinâmico do banco na pasta DataAccess
            string pastaBanco = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataAccess");
            string caminhoBanco = Path.Combine(pastaBanco, "supermercado.db");
            connectionString = $"Data Source={caminhoBanco}";

            // Associa o evento Load do formulário
            this.Load += CadastroProdutoForm_Load;
        }

        // Evento Load do formulário
        private void CadastroProdutoForm_Load(object? sender, EventArgs e)
        {
            CarregarProdutos();
        }

        // Método que carrega os produtos no DataGridView
        private void CarregarProdutos()
        {
            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
SELECT 
    Id,                  -- pode ser oculto no grid, usado internamente
    Nome,                -- nome do produto
    PrecoVenda,          -- preço de venda
    QuantidadeEmEstoque, -- estoque atual
    CategoriaId,         -- você pode mostrar o nome da categoria depois via JOIN
    FornecedorId,        -- você pode mostrar o nome do fornecedor via JOIN
    DataValidade         -- para produtos perecíveis
FROM Produto
WHERE StatusAtivo = 1  -- apenas produtos ativos
ORDER BY Nome;         -- organiza por nome para facilitar a visualização
";

                    using (var cmd = new SqliteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader); // Carrega o DataReader direto no DataTable

                        dgvProdutos.DataSource = dt;

                        // Configura cabeçalhos e oculta ID
                        dgvProdutos.Columns["Nome"].HeaderText = "Nome do Produto";
                        dgvProdutos.Columns["PrecoVenda"].HeaderText = "Preço de Venda";
                        dgvProdutos.Columns["QuantidadeEmEstoque"].HeaderText = "Estoque";
                        dgvProdutos.Columns["CategoriaId"].HeaderText = "Categoria";
                        dgvProdutos.Columns["FornecedorId"].HeaderText = "Fornecedor";
                        dgvProdutos.Columns["DataValidade"].HeaderText = "Validade";
                        dgvProdutos.Columns["Id"].Visible = false;
                        dgvProdutos.AllowUserToAddRows = false;
                        dgvProdutos.RowHeadersVisible = false;
                        dgvProdutos.ReadOnly = true;
                        dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        // Eventos de labels (se quiser manter)
        private void label2_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;

// Importa os formulários que estão na pasta Views
using LSoft.Views;

namespace LSoft
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new CadastroProdutoForm();
            form.ShowDialog(); // Abre a janela de produtos
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new CadastroClienteForm();
            form.ShowDialog(); // Abre modal
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var form = new VendaForm();
            form.ShowDialog(); // Abre modal
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var form = new EstoqueForm();
            form.ShowDialog(); // Abre modal
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var form = new RelatorioForm();
            form.ShowDialog(); // Abre modal
        }
    }
}

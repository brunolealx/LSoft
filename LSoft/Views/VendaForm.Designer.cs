namespace LSoft.Views
{
    partial class VendaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            dgvVendaItem = new DataGridView();
            txtTotal = new TextBox();
            label5 = new Label();
            txtValorPago = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtTroco = new TextBox();
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            comboBox3 = new ComboBox();
            nudQuantidade = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvVendaItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(65, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(333, 23);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(65, 70);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(333, 23);
            comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 73);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Quantidade:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(672, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(588, 73);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 6;
            label4.Text = "Valor Unitário:";
            // 
            // button1
            // 
            button1.Location = new Point(65, 99);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 8;
            button1.Text = "Adicionar Produto";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvVendaItem
            // 
            dgvVendaItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendaItem.Location = new Point(12, 128);
            dgvVendaItem.Name = "dgvVendaItem";
            dgvVendaItem.Size = new Size(760, 231);
            dgvVendaItem.TabIndex = 9;
           
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(75, 365);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(191, 23);
            txtTotal.TabIndex = 11;
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 368);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 10;
            label5.Text = "Total:";
            // 
            // txtValorPago
            // 
            txtValorPago.Location = new Point(75, 394);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(191, 23);
            txtValorPago.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 397);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 12;
            label6.Text = "Desconto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 426);
            label7.Name = "label7";
            label7.Size = new Size(121, 15);
            label7.TabIndex = 14;
            label7.Text = "Forma de pagamento";
            // 
            // txtTroco
            // 
            txtTroco.Location = new Point(75, 452);
            txtTroco.Name = "txtTroco";
            txtTroco.Size = new Size(191, 23);
            txtTroco.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 455);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 16;
            label8.Text = "Troco:";
            // 
            // button2
            // 
            button2.Location = new Point(12, 516);
            button2.Name = "button2";
            button2.Size = new Size(124, 23);
            button2.TabIndex = 18;
            button2.Text = "Concluir Venda";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(142, 516);
            button3.Name = "button3";
            button3.Size = new Size(124, 23);
            button3.TabIndex = 19;
            button3.Text = "Cancelar Venda";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(139, 423);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(127, 23);
            comboBox3.TabIndex = 20;
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(473, 70);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(109, 23);
            nudQuantidade.TabIndex = 21;
            // 
            // VendaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(784, 561);
            Controls.Add(nudQuantidade);
            Controls.Add(comboBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtTroco);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtValorPago);
            Controls.Add(label6);
            Controls.Add(txtTotal);
            Controls.Add(label5);
            Controls.Add(dgvVendaItem);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "VendaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venda";
            Load += VendaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVendaItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Button button1;
        private DataGridView dgvVendaItem;
        private TextBox txtTotal;
        private Label label5;
        private TextBox txtValorPago;
        private Label label6;
        private Label label7;
        private TextBox txtTroco;
        private Label label8;
        private Button button2;
        private Button button3;
        private ComboBox comboBox3;
        private NumericUpDown nudQuantidade;
    }
}
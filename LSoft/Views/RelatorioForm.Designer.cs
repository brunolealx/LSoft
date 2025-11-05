
namespace LSoft.Views
{
    partial class RelatorioForm
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
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            dgvRelatorio = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Filtro por: Produto";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(122, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 23);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(122, 94);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(249, 23);
            comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Data Inicial:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Data Final:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 97);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 5;
            label4.Text = "Tipo de relatório";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(249, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(122, 65);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(249, 23);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 141);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 8;
            button1.Text = "Gerar Relatório";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(122, 141);
            button2.Name = "button2";
            button2.Size = new Size(125, 23);
            button2.TabIndex = 9;
            button2.Text = "Exportar PDF/Excel";
            button2.UseVisualStyleBackColor = true;
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorio.Location = new Point(12, 188);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.Size = new Size(760, 361);
            dgvRelatorio.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(362, 170);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 11;
            label5.Text = "Relatório";
            // 
            // RelatorioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(784, 561);
            Controls.Add(label5);
            Controls.Add(dgvRelatorio);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "RelatorioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório";
            Load += RelatorioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void RelatorioForm_Load(object sender, EventArgs e)
        {
           
          
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private Button button2;
        private DataGridView dgvRelatorio;
        private Label label5;
    }
}

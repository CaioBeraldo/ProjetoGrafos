namespace ProjetoGrafos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownMaxCidades = new System.Windows.Forms.NumericUpDown();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.dgMatriz = new System.Windows.Forms.DataGridView();
            this.btnSalvaMatriz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.comboBoxCidades = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de cidade:";
            // 
            // numericUpDownMaxCidades
            // 
            this.numericUpDownMaxCidades.Location = new System.Drawing.Point(44, 89);
            this.numericUpDownMaxCidades.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownMaxCidades.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMaxCidades.Name = "numericUpDownMaxCidades";
            this.numericUpDownMaxCidades.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownMaxCidades.TabIndex = 1;
            this.numericUpDownMaxCidades.ValueChanged += new System.EventHandler(this.numericUpDownMaxCidades_ValueChanged);
            // 
            // btnMatriz
            // 
            this.btnMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatriz.Location = new System.Drawing.Point(24, 32);
            this.btnMatriz.Margin = new System.Windows.Forms.Padding(4);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(473, 55);
            this.btnMatriz.TabIndex = 2;
            this.btnMatriz.Text = "Matriz de Adjacência do Grafo";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // dgMatriz
            // 
            this.dgMatriz.AllowUserToAddRows = false;
            this.dgMatriz.AllowUserToDeleteRows = false;
            this.dgMatriz.AllowUserToResizeColumns = false;
            this.dgMatriz.AllowUserToResizeRows = false;
            this.dgMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatriz.ColumnHeadersVisible = false;
            this.dgMatriz.Location = new System.Drawing.Point(24, 124);
            this.dgMatriz.Margin = new System.Windows.Forms.Padding(4);
            this.dgMatriz.Name = "dgMatriz";
            this.dgMatriz.RowHeadersVisible = false;
            this.dgMatriz.RowHeadersWidth = 51;
            this.dgMatriz.Size = new System.Drawing.Size(473, 276);
            this.dgMatriz.TabIndex = 3;
            // 
            // btnSalvaMatriz
            // 
            this.btnSalvaMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaMatriz.Location = new System.Drawing.Point(102, 431);
            this.btnSalvaMatriz.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvaMatriz.Name = "btnSalvaMatriz";
            this.btnSalvaMatriz.Size = new System.Drawing.Size(337, 39);
            this.btnSalvaMatriz.TabIndex = 4;
            this.btnSalvaMatriz.Text = "Salvar Matriz de Adjacência";
            this.btnSalvaMatriz.UseVisualStyleBackColor = true;
            this.btnSalvaMatriz.Click += new System.EventHandler(this.btnSalvaMatriz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome das cidades:";
            this.label2.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvaMatriz);
            this.groupBox1.Controls.Add(this.dgMatriz);
            this.groupBox1.Controls.Add(this.btnMatriz);
            this.groupBox1.Location = new System.Drawing.Point(381, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 495);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(44, 198);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(172, 22);
            this.textBoxCidade.TabIndex = 10;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(67, 226);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(109, 35);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // comboBoxCidades
            // 
            this.comboBoxCidades.FormattingEnabled = true;
            this.comboBoxCidades.Location = new System.Drawing.Point(35, 295);
            this.comboBoxCidades.Name = "comboBoxCidades";
            this.comboBoxCidades.Size = new System.Drawing.Size(181, 24);
            this.comboBoxCidades.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBoxCidades);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownMaxCidades);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Projeto Grafos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxCidades;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.DataGridView dgMatriz;
        private System.Windows.Forms.Button btnSalvaMatriz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox comboBoxCidades;
    }
}


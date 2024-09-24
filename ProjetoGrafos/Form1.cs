using System;
using System.Windows.Forms;

namespace ProjetoGrafos
{
    public partial class Form1 : Form
    {
        // Vetor para armazenar os nomes das cidades
        private string[] nomes;
        private int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private ClasseGrafo G1;

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            int tamanho = (int)numericUpDownMaxCidades.Value;
            dgMatriz.RowCount = tamanho;
            dgMatriz.ColumnCount = tamanho;

            // Ajusta a largura das colunas
            for (int i = 0; i < tamanho; i++)
            {
                dgMatriz.Columns[i].Width = 50;
            }

            // Inicializa todas as células com 0
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    dgMatriz.Rows[i].Cells[j].Value = 0;
                }
            }
        }

        private void btnSalvaMatriz_Click(object sender, EventArgs e)
        {
            if (dgMatriz.RowCount == 0 || dgMatriz.ColumnCount == 0)
            {
                MessageBox.Show("A matriz está vazia. Por favor, adicione valores à matriz antes de salvar.");
                return;
            }

            G1 = new ClasseGrafo((int)numericUpDownMaxCidades.Value);

            // Copia os valores da matriz para o objeto ClasseGrafo
            for (int i = 0; i < (int)numericUpDownMaxCidades.Value; i++)
            {
                for (int j = 0; j < (int)numericUpDownMaxCidades.Value; j++)
                {
                    G1.MatrizGrafo[i, j] = Convert.ToInt16(dgMatriz.Rows[i].Cells[j].Value);
                }
            }
            MessageBox.Show("Matriz copiada com sucesso!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializa o ComboBox como vazio
            comboBoxCidades.Items.Clear();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Verifica se o vetor foi inicializado
            if (nomes == null)
            {
                MessageBox.Show("Primeiro defina o tamanho do vetor usando o NumericUpDown.");
                return;
            }

            // Verifica se o vetor está cheio
            if (index >= nomes.Length)
            {
                MessageBox.Show("O vetor está cheio. Não é possível adicionar mais nomes.");
                return;
            }

            // Verifica se o TextBox está vazio
            if (string.IsNullOrWhiteSpace(textBoxCidade.Text))
            {
                MessageBox.Show("O nome da cidade não pode estar vazio.");
                return;
            }

            // Adiciona o nome do TextBox ao vetor
            nomes[index] = textBoxCidade.Text;
            index++;

            // Limpa o TextBox
            textBoxCidade.Clear();

            // Atualiza o ComboBox
            AtualizaComboBox();
        }

        private void numericUpDownMaxCidades_ValueChanged(object sender, EventArgs e)
        {
            int tamanho = (int)numericUpDownMaxCidades.Value;

            if (tamanho <= 0)
            {
                MessageBox.Show("O tamanho do vetor deve ser maior que zero.");
                return;
            }

            // Inicializa o vetor com o tamanho especificado
            nomes = new string[tamanho];
            index = 0;

            // Limpa o ComboBox
            comboBoxCidades.Items.Clear();

            // Ajusta o ComboBox para o número de cidades
            for (int i = 0; i < tamanho; i++)
            {
                comboBoxCidades.Items.Add($"Cidade {i + 1}");
            }
        }

        private void AtualizaComboBox()
        {
            // Limpa o ComboBox e adiciona os nomes do vetor
            comboBoxCidades.Items.Clear();
            for (int i = 0; i < index; i++)
            {
                comboBoxCidades.Items.Add(nomes[i]);
            }
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            // Verifica se o vetor foi inicializado
            if (nomes == null)
            {
                MessageBox.Show("Primeiro defina o tamanho do vetor usando o NumericUpDown.");
                return;
            }

            // Verifica se o vetor está cheio
            if (index >= nomes.Length)
            {
                MessageBox.Show("O vetor está cheio. Não é possível adicionar mais nomes.");
                return;
            }

            // Verifica se o TextBox está vazio
            if (string.IsNullOrWhiteSpace(textBoxCidade.Text))
            {
                MessageBox.Show("O nome da cidade não pode estar vazio.");
                return;
            }

            // Adiciona o nome do TextBox ao vetor
            nomes[index] = textBoxCidade.Text;
            index++;

            // Limpa o TextBox
            textBoxCidade.Clear();

            // Atualiza o ComboBox
            AtualizaComboBox();
        }
    }
}

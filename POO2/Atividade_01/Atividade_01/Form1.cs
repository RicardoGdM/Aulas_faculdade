namespace Atividade_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buscarAluno_Click(object sender, EventArgs e)
        {
            string busca = textBox2.Text.Trim();


            bool buscaOk = false;


            if (busca == "")
            {
                MessageBox.Show("Por favor, insira um nome válido!", "Dados inválidos");
                label2.Visible = true;
            }
            else
            {
                buscaOk = true;
            }

            if (buscaOk)
            {
                if (radioButton1.Checked)
                {
                    MessageBox.Show("Nome encontrado!", "Encontrado");
                }
                else if (radioButton2.Checked)
                {
                    MessageBox.Show("R.A. encontrado!", "Encontrado");
                }

                label2.Visible = false;

                label3.Visible = true;
                comboBox1.Visible = true;

                label4.Visible = true;
                comboBox2.Visible = true;

                label5.Visible = true;
                textBox3.Visible = true;

                label6.Visible = true;
                textBox4.Visible = true;

                salvarNota.Visible = true;

                pictureBox1.Visible = true;

                nomeAluno.Visible = true;
                nomeAluno.Text += "Ricardo Gomes de Moraes";

                label9.Visible = true;
                label9.Text += "42166232809";

                float notaMedia = 100 * 10000 / 12000;

                label7.Visible = true;
                label7.Text += "10000 /12000  (" + notaMedia + "%)";

                progressBar1.Visible = true;
                progressBar1.Value = (int)notaMedia;
            }
            else
            {
                return;
            }
            
        }

        private void salvarNota_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nota adicionada com sucesso!", "Nota adicionada");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

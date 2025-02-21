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
            string nomeAluno = textBox1.Text.Trim();
            string raAluno = textBox2.Text.Trim();

            bool nomeOk = false;
            bool raOk = false;

            if (nomeAluno == "")
            {
                MessageBox.Show("Por favor, insira um nome válido!", "Dados inválidos");
                label8.Visible = true;
            }
            else
            {
                nomeOk = true;
            }

            if (raAluno == "")
            {
                MessageBox.Show("Por favor, insira um R.A. válido!", "Dados inválidos");
                label9.Visible = true;
            }
            else
            {
                raOk = true;
            }

            if (nomeOk && raOk)
            {
                label3.Visible = true;
                comboBox1.Visible = true;

                label4.Visible = true;
                comboBox2.Visible = true;

                label5.Visible = true;
                textBox3.Visible = true;

                label6.Visible = true;
                textBox4.Visible = true;

                salvarNota.Visible = true;
            }
            else
            {
                return;
            }

            progressBar1.Value = 50;
        }

        private void salvarNota_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }
    }
}

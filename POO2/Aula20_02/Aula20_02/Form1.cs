namespace Aula20_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Texto alterado";
            MessageBox.Show("Você clicou no botão!", "Aviso");
            label1.Text = "Você digitou: " + textBox1.Text;
            if (checkBox1.Checked)
            {
                MessageBox.Show("Parabéns!", "Check Box");
            }
            else
            {
                MessageBox.Show("Que pena!", "Check Box");
            }

            if (radioButton1.Checked)
            {
                MessageBox.Show("Opção 1 selecionada!", "Radio button");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Opção 2 selecionada!", "Radio button");
            }

            MessageBox.Show("Estado: " + comboBox1.SelectedItem, "Combobox");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

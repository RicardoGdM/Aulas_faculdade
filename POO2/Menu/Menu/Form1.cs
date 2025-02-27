namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void abreUmaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 novaJanela = new Form2();
            novaJanela.Show();
        }

        private void abreUmaJanelaMDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 novaMDI = new Form2();
            novaMDI.MdiParent = this;
            novaMDI.Show();
        }
    }
}

using System.Drawing.Text;

namespace WinThread
{
    public partial class Form1 : Form
    {
        private Thread trd;
        private bool isRunning = true;

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void ThreadTask()
        {
            Random rnd = new Random();

            while (isRunning)
            {
                int stp = progressBar1.Step * rnd.Next(-1, 2);
                int newVal = progressBar1.Value + stp;
                if (newVal > progressBar1.Maximum)
                {
                    newVal = progressBar1.Maximum;
                }
                else if (newVal < progressBar1.Minimum)
                {
                    newVal = progressBar1.Minimum;
                }

                try
                {
                    if (!IsDisposed && !progressBar1.IsDisposed)
                    {
                        this.Invoke(new Action(() => progressBar1.Value = newVal));
                    }
                }
                catch (ObjectDisposedException)
                {
                    break;
                }
                catch (InvalidOperationException)
                {
                    break;
                }

                Thread.Sleep(100);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este é o processo princial");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trd = new Thread(ThreadTask);
            trd.IsBackground = true;
            trd.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;

            if (trd != null && trd.IsAlive)
            {
                trd.Join(500);
            }
        }

        
}
}

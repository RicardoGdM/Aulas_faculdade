using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado_prova_3
{
    public partial class Form3 : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SimuladoProva;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public Form3()
        {
            InitializeComponent();
        }

        public event Action DadosAtualizados;

        private void btn_cadCidade_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_cidade.Text) && textBox_uf.TextLength == 2)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO Cidades (cidade, uf)" +
                            "VALUES (@cidade, @uf)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@cidade", textBox_cidade.Text);
                            cmd.Parameters.AddWithValue("@uf", textBox_uf.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Cidade cadastrada com sucesso!", "OK");
                }
                catch
                {
                    MessageBox.Show("Erro ao cadastrar cidade!", "OK");
                }


            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            DadosAtualizados?.Invoke();
            this.Close();
        }
    }
}

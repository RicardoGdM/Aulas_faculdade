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

namespace Avaliacao_01
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_avaliacao;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public Form2()
        {
            InitializeComponent();
        }

        private void add_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(cliente_nome.Text) && !string.IsNullOrWhiteSpace(cliente_empresa.Text) && !string.IsNullOrWhiteSpace(cliente_email.Text))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO clientes (nome, empresa, email) " +
                            "values ( @nome, @empresa, @email)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nome", cliente_nome.Text);
                            cmd.Parameters.AddWithValue("@empresa", cliente_empresa.Text);
                            cmd.Parameters.AddWithValue("@email", cliente_email.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Cliente adicionado com sucesso!");

                    cliente_nome.Clear();
                    cliente_empresa.Clear();
                    cliente_email.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos para continuar!");
                }
            }
            catch 
            {
                MessageBox.Show("Erro ao adicionar cliente");
            }
            

        }
    }
}

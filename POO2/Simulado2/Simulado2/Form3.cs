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

namespace Simulado2
{
    public partial class Form3 : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Cad_clientes;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nome_cidade.Text) && uf_estado.TextLength == 2)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Cidades (cidade, estado) VALUES (@cidade, @estado)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cidade", nome_cidade.Text);
                        cmd.Parameters.AddWithValue("@estado", uf_estado.Text);
                        cmd.ExecuteNonQuery();

                    }
                    //CarregarDados();
                    //Form2.CarregarCidades();
                    //nome_cliente.Clear();
                    //idade.Value = 0;
                }
            }
        }
    }
}

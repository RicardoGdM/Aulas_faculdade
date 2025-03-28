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
using static Simulado2.Form1;

namespace Simulado2
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Cad_clientes;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public Form2()
        {
            InitializeComponent();
            CarregarCidades();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCidade;

            if (cb_cidades.SelectedItem != null)
            {
                Cidades cidadeSelecionada = (Cidades)cb_cidades.SelectedItem;
                idCidade = cidadeSelecionada.Id;
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma cidade");
                return;
            }

            if (!string.IsNullOrWhiteSpace(nome_cliente.Text) && idade.Value > 0)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Clientes (nome, idade, fk_cliente_cidade) VALUES (@nome, @idade, @fk_cidade)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome_cliente.Text);
                        cmd.Parameters.AddWithValue("@idade", idade.Value);
                        cmd.Parameters.AddWithValue("@fk_cidade", idCidade);
                        cmd.ExecuteNonQuery();

                    }
                    //Form1.CarregarDados();
                    nome_cliente.Clear();
                    idade.Value = 0;
                }
            }
        }

        public void CarregarCidades()
        {
            List<Cidades> cidades = new List<Cidades>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, cidade, estado FROM Cidades";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cidades.Add(new Cidades { Id = reader.GetInt32(0), Cidade = reader.GetString(1), Uf = reader.GetString(2) });
                        }
                    }
                }
            }
            cb_cidades.DataSource = null;
            cb_cidades.DataSource = cidades;
            cb_cidades.DisplayMember = "Cidades";
        }
    }
}


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
    public partial class Form3 : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_avaliacao;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public Form3()
        {
            InitializeComponent();
            atualizarClientes();
            atualizarTipoTrabalho();
        }

        private void add_trabalho_Click(object sender, EventArgs e)
        {
            string dataFormatada = data_trabalho.Value.ToString("yyyy-MM-dd");
            int trabahoSelecionado = 0;
            int clienteSelecionado = 0;

            if (busca_tipo_trabalho.SelectedItem != null) {
                    TipoTrabalho trabalho = (TipoTrabalho)busca_tipo_trabalho.SelectedItem;
                    trabahoSelecionado = trabalho.Id;
            }
            else
            {
                MessageBox.Show("Por favor, escolha um cliente");
            }

            if (busca_cliente.SelectedItem != null) 
            {
                Cliente cliente = (Cliente)busca_cliente.SelectedItem;
                clienteSelecionado = cliente.Id;
            }
            else
            {
                MessageBox.Show("Por favor, escolha um serviço");
            }

            try
            {
                if (busca_cliente.SelectedItem != null && busca_tipo_trabalho.SelectedItem != null)
                {



                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO manutencoes_realizadas ( " +
                            "fk_tipo_servico, fk_cliente, data_servico) " +
                            "values (@fk_servico, @fk_cliente, @data_servico)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@fk_servico", trabahoSelecionado);
                            cmd.Parameters.AddWithValue("@fk_cliente", clienteSelecionado);
                            cmd.Parameters.AddWithValue("@data_servico", dataFormatada);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Não foi possível adicionar o serviço!");
            }

            
            
        }

        private void atualizarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, nome, empresa, email FROM clientes";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                clientes.Add(new Cliente
                                {
                                    Id = reader.GetInt32(0),
                                    Nome = reader.GetString(1),
                                    Empresa = reader.GetString(2),
                                    Email = reader.GetString(3)
                                });
                            }
                        }

                    }
                }
                busca_cliente.DataSource = null;
                busca_cliente.DataSource = clientes;
            }
            catch
            {

            }


        }

        private void atualizarTipoTrabalho()
        {
            List<TipoTrabalho> tipoTrabalhos = new List<TipoTrabalho>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, servico, valor FROM tipo_servico";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tipoTrabalhos.Add(new TipoTrabalho
                                {
                                    Id = reader.GetInt32(0),
                                    Servico = reader.GetString(1),
                                    Valor = reader.GetDecimal(2)
                                });
                            }
                        }

                    }
                }
                busca_tipo_trabalho.DataSource = null;
                busca_tipo_trabalho.DataSource = tipoTrabalhos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }


        }


        public class Cliente
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Empresa { get; set; }
            public string Email { get; set; }

            public override string ToString()
            {
                return $"{Nome} - {Empresa}, {Email}";
            }
        }

        public class TipoTrabalho
        {
            public int Id { get; set; }
            public string Servico { get; set; }
            public decimal Valor { get; set; }

            public override string ToString()
            {
                return $"{Servico} - Valor: {Valor}";
            }
        }
    }
}

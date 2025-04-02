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
using static Simulado_prova_3.Form1;
using static Simulado_prova_3.Form2;

namespace Simulado_prova_3
{
    public partial class Form4 : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SimuladoProva;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public Form4()
        {
            InitializeComponent();
        }

        public event Action DadosAtualizados;

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            ListarDados();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            if (lst_busca.SelectedItem != null)
            {
                try
                {
                    cliente = (Cliente)lst_busca.SelectedItem;

                    int delete_id = cliente.ID;

                    DialogResult resultado =

                    MessageBox.Show($"O cliente {cliente.ID} - {cliente.NOME} será apagado!", "Deseja continuar?", MessageBoxButtons.OKCancel);

                    if (resultado == DialogResult.OK)
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "DELETE FROM Clientes WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", delete_id);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        busca_nome.Clear();
                    }
                    else
                    {
                        return;
                    }

                }
                catch
                {
                    MessageBox.Show("Não foi possível excluir o usuário");
                }

            }
            ListarDados();
            DadosAtualizados?.Invoke();
        }

        public void ListarDados()
        {
            if (!string.IsNullOrWhiteSpace(busca_nome.Text))
            {
                try
                {
                    List<Cliente> clientes = new List<Cliente>();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT " +
                            "c.id, c.nome, c.idade, " +
                            "cid.cidade, cid.uf " +
                            "FROM Clientes c " +
                            "LEFT JOIN Cidades cid ON c.fk_cidade = cid.id " +
                            "WHERE nome LIKE @nome";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nome", $"%{busca_nome.Text}%");
                            cmd.ExecuteNonQuery();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    clientes.Add(new Cliente
                                    {
                                        ID = reader.GetInt32(0),
                                        NOME = reader.GetString(1),
                                        IDADE = reader.GetInt32(2),
                                        CIDADE = reader.GetString(3),
                                        UF = reader.GetString(4)
                                    });
                                }
                            }
                            lst_busca.DataSource = null;
                            lst_busca.DataSource = clientes;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao encontrar clientes!\n{ex}", "OK");
                }

            }
        }

        private void atualizarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            if (lst_busca.SelectedItem != null)
            {
                cliente = (Cliente)lst_busca.SelectedItem;

                Form2 attCliente = new Form2(cliente);
                attCliente.Show();
            }

        }
    }
}

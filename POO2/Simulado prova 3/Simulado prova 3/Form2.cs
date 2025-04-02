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

namespace Simulado_prova_3
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SimuladoProva;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public Form2()
        {
            InitializeComponent();
            carregarCidades();
        }

        public Form2(Cliente cliente)
        {
            InitializeComponent();
            atualizarDados(cliente);
        }

        public event Action DadosAtualizados;

        private bool atualizar = false;
        private int id_atualizar;

        private void btn_cadCliente_Click(object sender, EventArgs e)
        {
            salvarDados();
        }

        public void carregarCidades()
        {
            List<Cidade> cidades = new List<Cidade>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, cidade, uf FROM Cidades";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cidades.Add(new Cidade { ID = reader.GetInt32(0), CIDADE = reader.GetString(1), UF = reader.GetString(2) });
                            }
                        }
                    }
                }
                cb_cidades.DataSource = null;
                cb_cidades.DataSource = cidades;
                cb_cidades.DisplayMember = "Cidades";

            }
            catch (Exception e)
            {
                MessageBox.Show($"Não foi possível carregar as cidades!\n {e}");
            }
        }

        public void atualizarDados(Cliente cliente)
        {
            textBox_nome.Text = cliente.NOME;
            num_idade.Value = cliente.IDADE;

            carregarCidades();

            atualizar = true;

            id_atualizar = cliente.ID;
        }

        private void salvarDados()
        {
            int cidadeSelecionada;

            if (!string.IsNullOrWhiteSpace(textBox_nome.Text) && num_idade.Value > 0)
            {
                if (cb_cidades.SelectedItem != null)
                {
                    Cidade cidade = (Cidade)cb_cidades.SelectedItem;

                    cidadeSelecionada = cidade.ID;
                }
                else
                {
                    MessageBox.Show("Por favor, escolha uma cidade!");
                    return;
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query;
                        if (atualizar)
                        {
                            query = "UPDATE Clientes SET nome = @nome, idade = @idade, fk_cidade = @fk_cidade WHERE id = @id";
                        }
                        else
                        {
                            query = "INSERT INTO Clientes (nome, idade, fk_cidade) " +
                            "VALUES (@nome, @idade, @fk_cidade)";
                        }

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            if (atualizar)
                            {
                                cmd.Parameters.AddWithValue("@id", id_atualizar);
                            }
                            cmd.Parameters.AddWithValue("@nome", textBox_nome.Text);
                            cmd.Parameters.AddWithValue("@idade", num_idade.Value);
                            cmd.Parameters.AddWithValue("@fk_cidade", cidadeSelecionada);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Cliente adicionado com sucesso!", "OK");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Não foi possível concluir o cadastro!\n {ex}", "OK");
                }

            }
            else
            {
                MessageBox.Show("Por favor, escolha uma cidade!", "OK");
            }

            DadosAtualizados?.Invoke();
            this.Close();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

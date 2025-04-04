using Microsoft.Data.SqlClient;
using static Avaliacao_01.Form3;

namespace Avaliacao_01
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_avaliacao;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public Form1()
        {
            InitializeComponent();
            atualizaDados();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void novoServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void lst_relatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void atualizaDados()
        {
            List<Relatorio> relatorios = new List<Relatorio>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                        manu.id, c.nome, c.empresa, s.servico, manu.data_servico
                        FROM manutencoes_realizadas AS manu
                        LEFT JOIN clientes c ON manu.fk_cliente = c.id
                        LEFT JOIN tipo_servico s ON manu.fk_tipo_servico = s.id
                        ORDER BY c.id DESC; ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                relatorios.Add(new Relatorio
                                {
                                    Id_manutencao = reader.GetInt32(0),
                                    Nome_cliente = reader.GetString(1),
                                    Empresa_cliente = reader.GetString(2),
                                    Trabalho_realizado = reader.GetString(3),
                                    Data_trabalho = reader.GetDateTime(4).ToString()
                                });
                            }
                        }
                    }
                }
                lst_relatorio.DataSource = null;
                lst_relatorio.DataSource = relatorios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível carregar os dados!\n {ex}");
            }
        }
        public class Relatorio
        {
            public int Id_manutencao { get; set; }
            public string Nome_cliente { get; set; }
            public string Empresa_cliente { get; set; }
            public string Trabalho_realizado { get; set; }
            public string Data_trabalho { get; set; }

            public override string ToString()
            {
                return $"Cliente: {Nome_cliente}, empresa: {Empresa_cliente} - Trabalho realizado: {Trabalho_realizado}, Data: {Data_trabalho}";
            }
        }
    }
}

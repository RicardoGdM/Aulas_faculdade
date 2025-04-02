using Microsoft.Data.SqlClient;

namespace Simulado_prova_3
{
    public partial class Form1 : Form
    {

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SimuladoProva;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public Form1()
        {
            InitializeComponent();
            carregaDados();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 cadClientes = new Form2();
            cadClientes.DadosAtualizados += carregaDados;
            cadClientes.Show();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 cadCidades = new Form3();
            cadCidades.DadosAtualizados += carregaDados;
            cadCidades.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 buscaCliente = new Form4();
            buscaCliente.DadosAtualizados += carregaDados;
            buscaCliente.Show();

        }

        public class Cliente
        {
            public int ID { get; set; }
            public string NOME { get; set; }
            public int IDADE { get; set; }
            public int FK_CIDADE { get; set; }
            public string CIDADE { get; set; }
            public string UF { get; set; }

            public override string ToString()
            {
                return $"{ID} - {NOME}, {IDADE} - {CIDADE}, {UF}";
            }
        }

        public class Cidade
        {
            public int ID { get; set; }
            public string CIDADE { get; set; }
            public string UF { get; set; }

            public override string ToString()
            {
                return $"{CIDADE}, {UF}";
            }
        }

        private void carregaDados()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT " +
                                    "c.id, c.nome, c.idade, " +
                                    "cid.cidade, cid.uf " +
                                    "FROM Clientes AS c " +
                                    "LEFT JOIN Cidades cid ON c.fk_cidade = cid.id " +
                                    "ORDER BY c.id DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
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
                    }
                }
                lst_cadastros.DataSource = null;
                lst_cadastros.DataSource = clientes;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Não foi possível carregar os dados!\n {e}");
            }
        }        
    }
}

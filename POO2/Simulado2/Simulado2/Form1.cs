using Microsoft.Data.SqlClient;

namespace Simulado2
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Cad_clientes;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        public class Cliente
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Cidade { get; set; }
            public string Uf { get; set; }

            public override string ToString()
            {
                return $"{Id} - {Nome}, {Idade} anos - {Cidade}, {Uf}";
            }
        }

        public class Cidades
        {
            public int Id { get; set; }
            public string Cidade { get; set; }
            public string Uf { get; set; }

            public override string ToString()
            {
                return $"{Cidade}, {Uf}";
            }
        }


        private void CarregarDados()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT " +
                    "c.id, c.nome, c.idade, " +
                    "ci.cidade, ci.estado " +
                    "FROM Clientes c " +
                    "LEFT JOIN Cidades ci ON c.fk_cliente_cidade = ci.id " +
                    "ORDER BY c.id DESC";

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
                                Idade = reader.GetInt32(2),
                                Cidade = reader.GetString(3),
                                Uf = reader.GetString(4)
                            });
                        }
                    }
                }
            }

            lstClientes.DataSource = null;
            lstClientes.DataSource = clientes;
            lstClientes.DisplayMember = "Clientes";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 cadClientes = new Form2();
            cadClientes.Show();
        }

        private void cadastrarCidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 cadCidades = new Form3();
            cadCidades.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}

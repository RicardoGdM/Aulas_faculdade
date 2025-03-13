using Microsoft.Data.SqlClient;

namespace WinDb
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WinDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Itens (Descricao) VALUES (@Descricao)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                        cmd.ExecuteNonQuery();

                    }
                    CarregarDados();
                    txtDescricao.Clear();
                }
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (lstItens.SelectedItem is Item itemSelecionado)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Itens SET Descricao = @Descricao WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@Id", itemSelecionado.Id);
                        cmd.ExecuteNonQuery();
                    }
                    CarregarDados();
                    txtDescricao.Clear();
                }
            }
        }

        public class Item
        {
            public int Id { get; set; }
            public string Descricao { get; set; }

            public override string ToString()
            {
                return $"{Id} - {Descricao}";
            }
        }

        

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (lstItens.SelectedItem is Item itemSelecionado)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Itens WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", itemSelecionado.Id);
                        cmd.ExecuteNonQuery();
                    }
                    CarregarDados();
                    txtDescricao.Clear();
                }
            }
        }

        private void CarregarDados()
        {
            List<Item> itens = new List<Item>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, Descricao FROM Itens";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            itens.Add(new Item { Id = reader.GetInt32(0), Descricao = reader.GetString(1) });
                        }
                    }
                }
            }
            lstItens.DataSource = null;
            lstItens.DataSource = itens;
            lstItens.DisplayMember = "Descrição";
        }
    }
}

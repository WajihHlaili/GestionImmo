using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionD_AgenceImmobilière
{
    public partial class annonces : Form
    {
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=gestion;Integrated Security=True;TrustServerCertificate=True";

        public annonces()
        {
            InitializeComponent();
            DisplayAnnonce();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            admin f = new admin();
            f.Show();
            this.Hide();
        }
        public static int id = 0;
        private void DisplayAnnonce()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT a.Id, a.typebien, u.Nom, u.Prenom, u.telephone " +
                                   "FROM ajoutimmo a " +
                                   "JOIN utilisateurs u ON a.userId = u.Id " +
                                   "WHERE u.Id IS NOT NULL";

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    dataGridView1.Columns.Clear();


                    dataGridView1.Columns.Add("typebien", "Type de Bien");
                    dataGridView1.Columns.Add("Nom", "Nom");
                    dataGridView1.Columns.Add("Prenom", "Prenom");
                    dataGridView1.Columns.Add("telephone", "Téléphone");


                    dataGridView1.Columns.Add("HiddenId", "HiddenId");
                    dataGridView1.Columns["HiddenId"].Visible = false;


                    foreach (DataRow row in dataTable.Rows)
                    {
                        int hiddenId = Convert.ToInt32(row["Id"]);
                        dataGridView1.Rows.Add(row["typebien"], row["Nom"], row["Prenom"], row["telephone"], hiddenId);
                    }


                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                    buttonColumn.Name = "Annonce Details";
                    buttonColumn.Text = "Details";
                    buttonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(buttonColumn);


                    dataGridView1.CellContentClick += DataGridView1_CellContentClick;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["Annonce Details"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int annonceId = Convert.ToInt32(selectedRow.Cells["HiddenId"].Value);
                Details df = new Details(annonceId);
                df.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int annonceId = Convert.ToInt32(selectedRow.Cells["HiddenId"].Value);
                MessageBox.Show(annonceId.ToString());
                string req = "update ajoutimmo set etat=@etat where Id=@id";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(req, connection);
                command.Parameters.AddWithValue("@etat", "true");
                command.Parameters.AddWithValue("@id", annonceId);
                MessageBox.Show("Annonce validée ");
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("pas d'annonce selectionnée");
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette annonce ?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int annonceId = Convert.ToInt32(selectedRow.Cells["HiddenId"].Value);

                string req = "delete from ajoutimmo where Id=@id";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(req, connection);
                command.Parameters.AddWithValue("@id", annonceId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Annonce supprimée");
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la suppression de l'annonce.");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("pas d'annonce selectionnée");
            }

        }
        private void RefreshDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT a.Id, a.typebien, u.Nom, u.Prenom, u.telephone " +
                                   "FROM ajoutimmo a " +
                                   "JOIN utilisateurs u ON a.userId = u.Id " +
                                   "WHERE u.Id IS NOT NULL";

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    //dataGridView1.Columns.Clear();


                    dataGridView1.Columns.Add("typebien", "Type de Bien");
                    dataGridView1.Columns.Add("Nom", "Nom");
                    dataGridView1.Columns.Add("Prenom", "Prenom");
                    dataGridView1.Columns.Add("telephone", "Téléphone");


                    dataGridView1.Columns.Add("HiddenId", "HiddenId");
                    dataGridView1.Columns["HiddenId"].Visible = false;


                    foreach (DataRow row in dataTable.Rows)
                    {
                        int hiddenId = Convert.ToInt32(row["Id"]);
                        dataGridView1.Rows.Add(row["typebien"], row["Nom"], row["Prenom"], row["telephone"], hiddenId);
                    }


                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                    buttonColumn.Name = "Annonce Details";
                    buttonColumn.Text = "Details";
                    buttonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(buttonColumn);
                    
                    dataGridView1.DataSource = null; 
                    dataGridView1.DataSource = dataTable; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            
        }
    }
}
    


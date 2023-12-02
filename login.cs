using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjetGestionD_AgenceImmobilière
{
    public partial class login : Form
    {
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=gestion;Integrated Security=True;TrustServerCertificate=True";

        public login()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private int userId ;
        
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection1 = new SqlConnection(connectionString);

            connection1.Open();
            string Query1 = "select Id from utilisateurs where email = @userName";
            SqlCommand command1 = new SqlCommand(Query1, connection1);
            command1.Parameters.AddWithValue("@UserName", email.Text);

            SqlDataReader reader1 = command1.ExecuteReader();

            if (reader1.Read())
            {

                userId = Convert.ToInt32(reader1["Id"]);
            }


            string usAdmin = "admin";
            string pwdAdmin = "admin";
            string lg = email.Text;
            string pwd = mdp.Text;
            if (lg.Equals("")||pwd.Equals("") ){
                MessageBox.Show("Missing information!!");
            }
            else { 
            if (lg.Equals(usAdmin) && pwd.Equals(pwdAdmin))
            {
                admin a = new admin();
                a.Show();
                this.Hide();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                
                    // Create a command
                    using (SqlCommand command = new SqlCommand("select email,motdepasse,role from utilisateurs ", connection))
                {
                    // Execute the command and read the data
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                        {

                       
                       

                        string email1 = reader.GetString(0);
                        string motdepasse = reader.GetString(1);
                        string role = reader.GetString(2);


                        if (lg.Equals(email1) && pwd.Equals(motdepasse))
                        {
                            if( role.Equals("client"))  {
                                client c= new client();
                                c.Show();
                                this.Hide();
                            }
                            if (role.Equals("propriétaire"))
                            {

                                propriétaire p = new propriétaire(userId);
                                p.Show();
                                this.Hide();
                                           

                            }
                        }
                                

                                }
                        }
                        else
                        {
                                MessageBox.Show("email don't exist!!");
                        }


                    }

                }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inscrire f = new inscrire();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            mdp.UseSystemPasswordChar = !checkBox1.Checked;



        }

        private void email_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void mdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void mdp_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Coordonnées GPS que vous souhaitez utiliser (remplacez par les coordonnées de votre localisation)
            double latitude = 40.7128; // Exemple: Latitude de New York
            double longitude = -74.0060; // Exemple: Longitude de New York

            // Générer le lien de localisation
            string lienLocalisation = $"https://www.google.com/maps?q={latitude},{longitude}";

            // Ouvrir le lien dans le navigateur par défaut
            Process.Start(new ProcessStartInfo("C:\\Users\\21694\\Desktop\\Google Maps", lienLocalisation));
        }
        
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            {
                // Insérez le lien de profil Facebook ici
                string facebookProfileLink = "https://www.facebook.com/?locale=fr_FR";

                // Ouvrir le lien dans le navigateur par défaut
                Process.Start(new ProcessStartInfo("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", facebookProfileLink));
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Remplacez par votre numéro de téléphone WhatsApp
            string numeroTelephone = "94600587";

            // Générer le lien WhatsApp
            string lienWhatsApp = $"https://wa.me/{numeroTelephone}";

            // Ouvrir le lien dans le navigateur par défaut
            OuvrirDansNavigateurParDefaut(lienWhatsApp);
        }

        private void OuvrirDansNavigateurParDefaut(string lien)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = lien,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Gestion de l'exception en cas d'erreur
                MessageBox.Show($"Erreur lors de l'ouverture du lien : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

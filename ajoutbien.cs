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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetGestionD_AgenceImmobilière
{
    public partial class ajoutbien : Form
    {
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=gestion;Integrated Security=True;TrustServerCertificate=True";

        private int userId;
        public ajoutbien(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void ajoutbien_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private string imagePath;
        private void button1_Click(object sender, EventArgs e)
        {
            // Afficher la boîte de dialogue pour sélectionner une image


                OpenFileDialog openFileDialog = new OpenFileDialog();
            
                openFileDialog.Filter = "Fichiers image (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tous les fichiers (*.*)|*.*";
                

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                 imagePath = openFileDialog.FileName;
                string imageName = Path.GetFileName(imagePath);
                string destinationPath = Path.Combine("C:\\Users\\SBS\\Downloads\\ProjetGestionDAgence.. (1)\\ProjetGestionDAgence.. (1)\\ProjetGestionD'AgenceImmobilière\\ProjetGestionD'AgenceImmobilière\\image\\", imageName);
                
                    File.Copy(imagePath, destinationPath, true);
                    Box.Image = Image.FromFile(destinationPath);
                
                
                
            }
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(typebien.Text) || string.IsNullOrWhiteSpace(terrain.Text) || string.IsNullOrWhiteSpace(etatgeneral.Text)
                     || string.IsNullOrWhiteSpace(etage.Text) 
                     || string.IsNullOrWhiteSpace(chambre.Text)
                     || string.IsNullOrWhiteSpace(anneeconst.Text) || string.IsNullOrWhiteSpace(typeannonce.Text) || (!checkBox1.Checked && !checkBox2.Checked) ||
                        (!checkBox3.Checked && !checkBox4.Checked)|| (!checkBox5.Checked && !checkBox6.Checked)|| (!checkBox7.Checked && !checkBox8.Checked)
                        ||(Box.Image == null))
                {
                    MessageBox.Show("Information manquante");
                }
                else {

                using (SqlConnection con = new SqlConnection(connectionString))
                {


                    con.Open();
                    string query = "INSERT INTO ajoutimmo ([typebien], [terrain], [general], [etage],[chambre],[anneeconst],[typeannonce], [choix], [choix1], [choix2]," +
                        " [choix3],[imageannonce],[etat],[userId]) VALUES ( @val1,@val2, @val3, @val4, @val5, @val6, @val7,@val8,@val9, @val10,@val11,@val12,@val13,@val14)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@val1", typebien.Text);
                    cmd.Parameters.AddWithValue("@val2", terrain.Text);
                    cmd.Parameters.AddWithValue("@val3", etatgeneral.Text);
                    cmd.Parameters.AddWithValue("@val4", etage.Text);
                    cmd.Parameters.AddWithValue("@val5", chambre.Text);
                    cmd.Parameters.AddWithValue("@val6", anneeconst.Text);
                    cmd.Parameters.AddWithValue("@val7", typeannonce.Text);

                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        
                        MessageBox.Show("Error de choisi !!");

                    }else if (checkBox1.Checked)
                    {
                       cmd.Parameters.AddWithValue("@val8", "Oui");
                        

                    }
                    else if (checkBox2.Checked)
                        {
                            cmd.Parameters.AddWithValue("@val8", "Non");
                        }

                        if (checkBox3.Checked && checkBox4.Checked)
                        {

                            MessageBox.Show("Error de choisi !!");

                        }
                        else if (checkBox3.Checked)
                        {
                            cmd.Parameters.AddWithValue("@val9", "Oui");


                        }
                        else if (checkBox4.Checked)
                        {
                            cmd.Parameters.AddWithValue("@val9", "Non");
                        }

                        if (checkBox5.Checked && checkBox6.Checked)
                        {

                            MessageBox.Show("Error de choisi !!");

                        }
                        else if (checkBox5.Checked)
                        {
                            cmd.Parameters.AddWithValue("@val10", "Oui");


                        }
                        else if (checkBox6.Checked)
                        {
                            cmd.Parameters.AddWithValue("@val10", "Non");
                        }

                        if (checkBox7.Checked && checkBox8.Checked)
                        {

                            MessageBox.Show("Error de choisi !!");

                        }
                        else if (checkBox7.Checked)
                        {
                            cmd.Parameters.AddWithValue("@val11", "Oui");


                        }
                        else if (checkBox8.Checked)
                        {
                            cmd.Parameters.AddWithValue("@val11", "Non");
                        }

                        if (Box.Image != null)
                    {

                        //yakhou path ta3 copied imagePath
                        
                          string image = Path.Combine("C:\\Users\\SBS\\Downloads\\ProjetGestionDAgence.. (1)\\ProjetGestionDAgence.. (1)\\ProjetGestionD'AgenceImmobilière\\ProjetGestionD'AgenceImmobilière\\image\\", Path.GetFileName(imagePath));
                            byte[] imageBytes = File.ReadAllBytes(image);
                            cmd.Parameters.Add("@val12", SqlDbType.VarBinary, -1).Value = imageBytes;

                    }
                        cmd.Parameters.AddWithValue("@val13", "false");

                        
                        cmd.Parameters.AddWithValue("@val14", userId);
                    
                    

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enregistrement inséré avec succès !");
                    

                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            propriétaire f = new propriétaire(userId);
            f.Show();
            this.Hide();
        }

        private void chambre_TextChanged(object sender, EventArgs e)
        {
               
                if (!string.IsNullOrEmpty(chambre.Text))
                
                if (int.TryParse(chambre.Text, out int nombreDeChambres))
            {
                
                Console.WriteLine("Nombre de chambres : " + nombreDeChambres);
            }
                else
                {
                
                MessageBox.Show("Veuillez entrer un nombre entier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
        }

        private void etage_TextChanged(object sender, EventArgs e)
        { 
                // Vérifier si le champ de texte n'est pas vide
                if (!string.IsNullOrEmpty(etage.Text))
                    // Vérifier si la saisie est un nombre entier
                    if (int.TryParse(etage.Text, out int nombreetages))
                    {
                        // La saisie est un nombre entier
                        // Vous pouvez utiliser la variable 'nombreDeChambres' comme bon vous semble
                        // Par exemple, vous pouvez l'afficher dans une étiquette ou effectuer d'autres opérations avec cette valeur
                        Console.WriteLine("Nombre d'étages : " + nombreetages);
                    }
                    else
                    {
                        // La saisie n'est pas un nombre entier, vous pouvez afficher un message d'erreur ici
                        MessageBox.Show("Veuillez entrer un nombre entier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
            
        }

        private void anneeconst_TextChanged(object sender, EventArgs e)
        {
            // Assurez-vous que le champ de texte n'est pas vide
            if (!string.IsNullOrEmpty(anneeconst.Text))
            {
                // Vérifiez si la saisie est un nombre entier
                if (int.TryParse(anneeconst.Text, out int Anneedeconstruction))
                {
                    // Limitez la longueur de la saisie à 4 chiffres
                    if (anneeconst.Text.Length <= 4)
                    {
                        // La saisie est un nombre entier et a une longueur maximale de 4 chiffres
                        // Vous pouvez utiliser la variable 'Anneedeconstruction' comme bon vous semble
                        Console.WriteLine("Année de construction : " + Anneedeconstruction);
                    }
                    else
                    {
                        // La saisie a dépassé 4 chiffres, afficher un message d'erreur
                        MessageBox.Show("Veuillez entrer une année de construction valide (4 chiffres).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Réduisez la saisie pour ne contenir que les 4 premiers chiffres
                        anneeconst.Text = anneeconst.Text.Substring(0, 4);
                    }
                }
                else
                {
                    // La saisie n'est pas un nombre entier, afficher un message d'erreur
                    MessageBox.Show("Veuillez entrer un nombre entier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }

}


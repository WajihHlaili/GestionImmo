using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionD_AgenceImmobilière
{
    public partial class Details : Form
    {
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=gestion;Integrated Security=True;TrustServerCertificate=True";

        private int id;
        public Details(int id)
        {
            InitializeComponent();
            this.id = id;
            DisplayDetails();
        }

         private void DisplayDetails()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * from ajoutimmo where Id =@id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                label13.Text = reader.GetString(reader.GetOrdinal("typebien"));
                label14.Text = reader.GetString(reader.GetOrdinal("terrain"));
                label15.Text = reader.GetString(reader.GetOrdinal("general"));
                label16.Text = reader.GetString(reader.GetOrdinal("etage"));
                label17.Text = reader.GetString(reader.GetOrdinal("chambre"));
                label18.Text = reader.GetString(reader.GetOrdinal("anneeconst"));
                label19.Text = reader.GetString(reader.GetOrdinal("typeannonce"));
                label20.Text = reader.GetString(reader.GetOrdinal("choix"));
                label21.Text = reader.GetString(reader.GetOrdinal("choix1"));
                label22.Text = reader.GetString(reader.GetOrdinal("choix2"));
                label23.Text = reader.GetString(reader.GetOrdinal("choix3"));
                byte[] imageData = (byte[])reader["imageannonce"];
                Image image = ByteArrayToImage(imageData);
                Image resizedImage = ResizeImage(image, Box1.Width, Box1.Height); 
                Box1.Image = resizedImage;
            }

        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }

            return resizedImage;
        }
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            Box1 = new PictureBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            ((System.ComponentModel.ISupportInitialize)Box1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(49, 44);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 0;
            label1.Text = "Type Bien :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(46, 102);
            label2.Name = "label2";
            label2.Size = new Size(169, 19);
            label2.TabIndex = 1;
            label2.Text = "Surface de Terrain(m²) :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(46, 152);
            label3.Name = "label3";
            label3.Size = new Size(101, 19);
            label3.TabIndex = 2;
            label3.Text = "Etat de Bien :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(46, 210);
            label4.Name = "label4";
            label4.Size = new Size(127, 19);
            label4.TabIndex = 3;
            label4.Text = "Nombre d'Etage :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(46, 274);
            label5.Name = "label5";
            label5.Size = new Size(157, 19);
            label5.TabIndex = 4;
            label5.Text = "Nombre de Chambre :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(46, 327);
            label6.Name = "label6";
            label6.Size = new Size(166, 19);
            label6.TabIndex = 5;
            label6.Text = "Année de construction :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.OrangeRed;
            label7.Location = new Point(46, 384);
            label7.Name = "label7";
            label7.Size = new Size(122, 19);
            label7.TabIndex = 6;
            label7.Text = "Type d'annonce :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.OrangeRed;
            label8.Location = new Point(443, 44);
            label8.Name = "label8";
            label8.Size = new Size(115, 19);
            label8.TabIndex = 7;
            label8.Text = "Image de Bien :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.OrangeRed;
            label9.Location = new Point(522, 403);
            label9.Name = "label9";
            label9.Size = new Size(102, 19);
            label9.TabIndex = 8;
            label9.Text = "Avec Piscine :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.OrangeRed;
            label10.Location = new Point(523, 448);
            label10.Name = "label10";
            label10.Size = new Size(108, 19);
            label10.TabIndex = 9;
            label10.Text = "Avec Terasse :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.OrangeRed;
            label11.Location = new Point(523, 491);
            label11.Name = "label11";
            label11.Size = new Size(101, 19);
            label11.TabIndex = 10;
            label11.Text = "Avec Balcon :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.OrangeRed;
            label12.Location = new Point(523, 537);
            label12.Name = "label12";
            label12.Size = new Size(105, 19);
            label12.TabIndex = 11;
            label12.Text = "Avec Garage :";
            // 
            // Box1
            // 
            Box1.Location = new Point(443, 75);
            Box1.Name = "Box1";
            Box1.Size = new Size(479, 315);
            Box1.TabIndex = 12;
            Box1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(146, 44);
            label13.Name = "label13";
            label13.Size = new Size(57, 19);
            label13.TabIndex = 13;
            label13.Text = "label13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(221, 102);
            label14.Name = "label14";
            label14.Size = new Size(57, 19);
            label14.TabIndex = 14;
            label14.Text = "label14";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(153, 152);
            label15.Name = "label15";
            label15.Size = new Size(57, 19);
            label15.TabIndex = 15;
            label15.Text = "label15";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(179, 210);
            label16.Name = "label16";
            label16.Size = new Size(57, 19);
            label16.TabIndex = 16;
            label16.Text = "label16";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(209, 274);
            label17.Name = "label17";
            label17.Size = new Size(57, 19);
            label17.TabIndex = 17;
            label17.Text = "label17";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(218, 327);
            label18.Name = "label18";
            label18.Size = new Size(57, 19);
            label18.TabIndex = 18;
            label18.Text = "label18";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(183, 384);
            label19.Name = "label19";
            label19.Size = new Size(57, 19);
            label19.TabIndex = 19;
            label19.Text = "label19";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(630, 403);
            label20.Name = "label20";
            label20.Size = new Size(57, 19);
            label20.TabIndex = 20;
            label20.Text = "label20";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(630, 448);
            label21.Name = "label21";
            label21.Size = new Size(57, 19);
            label21.TabIndex = 21;
            label21.Text = "label21";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(630, 491);
            label22.Name = "label22";
            label22.Size = new Size(57, 19);
            label22.TabIndex = 22;
            label22.Text = "label22";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(634, 537);
            label23.Name = "label23";
            label23.Size = new Size(57, 19);
            label23.TabIndex = 23;
            label23.Text = "label23";
            // 
            // Details
            // 
            ClientSize = new Size(961, 579);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(Box1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Details";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Box1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private PictureBox Box1;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label6;
    }
}

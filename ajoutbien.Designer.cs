namespace ProjetGestionD_AgenceImmobilière
{
    partial class ajoutbien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajoutbien));
            pictureBox2 = new PictureBox();
            Box = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            typebien = new TextBox();
            label4 = new Label();
            terrain = new TextBox();
            label5 = new Label();
            label6 = new Label();
            etage = new TextBox();
            etatgeneral = new ComboBox();
            label7 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label8 = new Label();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label9 = new Label();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            label10 = new Label();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            label11 = new Label();
            chambre = new TextBox();
            label12 = new Label();
            anneeconst = new TextBox();
            label13 = new Label();
            typeannonce = new ComboBox();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(783, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Box
            // 
            Box.Location = new Point(376, 275);
            Box.Name = "Box";
            Box.Size = new Size(205, 154);
            Box.SizeMode = PictureBoxSizeMode.Zoom;
            Box.TabIndex = 56;
            Box.TabStop = false;
            Box.Tag = "";
            Box.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(638, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 57;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(130, 82);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 58;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 84);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 59;
            label2.Text = "Fiche Technique De Bien";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(-1, 124);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 60;
            label3.Text = "Type De Bien :";
            // 
            // typebien
            // 
            typebien.Location = new Point(125, 121);
            typebien.Name = "typebien";
            typebien.Size = new Size(100, 23);
            typebien.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(-1, 162);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 62;
            label4.Text = "Terrain/mètre carré  :";
            // 
            // terrain
            // 
            terrain.Location = new Point(125, 159);
            terrain.Name = "terrain";
            terrain.Size = new Size(100, 23);
            terrain.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(-1, 199);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 64;
            label5.Text = "Etat Général :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(-1, 234);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 66;
            label6.Text = "Etage :";
            // 
            // etage
            // 
            etage.Location = new Point(125, 231);
            etage.Name = "etage";
            etage.Size = new Size(100, 23);
            etage.TabIndex = 67;
            etage.TextChanged += etage_TextChanged;
            // 
            // etatgeneral
            // 
            etatgeneral.Cursor = Cursors.IBeam;
            etatgeneral.ForeColor = SystemColors.WindowText;
            etatgeneral.FormattingEnabled = true;
            etatgeneral.Items.AddRange(new object[] { "Bonne Etat", "Exellente Etat " });
            etatgeneral.Location = new Point(125, 196);
            etatgeneral.Name = "etatgeneral";
            etatgeneral.Size = new Size(100, 23);
            etatgeneral.TabIndex = 68;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(-1, 275);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 69;
            label7.Text = "Piscine :";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(125, 274);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(45, 19);
            checkBox1.TabIndex = 70;
            checkBox1.Text = "Oui";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(224, 274);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(49, 19);
            checkBox2.TabIndex = 71;
            checkBox2.Text = "Non";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(-1, 313);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 72;
            label8.Text = "Terasse :";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(125, 309);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(45, 19);
            checkBox3.TabIndex = 73;
            checkBox3.Text = "Oui";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(224, 309);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(49, 19);
            checkBox4.TabIndex = 74;
            checkBox4.Text = "Non";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label9.Location = new Point(-1, 348);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 75;
            label9.Text = "Balcon :";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(125, 344);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(45, 19);
            checkBox5.TabIndex = 76;
            checkBox5.Text = "Oui";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(224, 344);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(49, 19);
            checkBox6.TabIndex = 77;
            checkBox6.Text = "Non";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label10.Location = new Point(0, 381);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 78;
            label10.Text = "Garage :";
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(125, 380);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(45, 19);
            checkBox7.TabIndex = 79;
            checkBox7.Text = "Oui";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(224, 377);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(49, 19);
            checkBox8.TabIndex = 80;
            checkBox8.Text = "Non";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label11.Location = new Point(0, 414);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 81;
            label11.Text = "Chambre(s) :";
            // 
            // chambre
            // 
            chambre.Location = new Point(125, 411);
            chambre.Name = "chambre";
            chambre.Size = new Size(100, 23);
            chambre.TabIndex = 82;
            chambre.TextChanged += chambre_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label12.Location = new Point(292, 124);
            label12.Name = "label12";
            label12.Size = new Size(82, 15);
            label12.TabIndex = 83;
            label12.Text = "Année const. :";
            // 
            // anneeconst
            // 
            anneeconst.Location = new Point(398, 121);
            anneeconst.Name = "anneeconst";
            anneeconst.Size = new Size(100, 23);
            anneeconst.TabIndex = 84;
            anneeconst.TextChanged += anneeconst_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label13.Location = new Point(292, 167);
            label13.Name = "label13";
            label13.Size = new Size(97, 15);
            label13.TabIndex = 85;
            label13.Text = "Type D'annonce :";
            // 
            // typeannonce
            // 
            typeannonce.Cursor = Cursors.IBeam;
            typeannonce.ForeColor = SystemColors.WindowText;
            typeannonce.FormattingEnabled = true;
            typeannonce.Items.AddRange(new object[] { "Vendre ", "Louer " });
            typeannonce.Location = new Point(398, 164);
            typeannonce.Name = "typeannonce";
            typeannonce.Size = new Size(100, 23);
            typeannonce.TabIndex = 86;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonHighlight;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(783, 428);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(19, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 87;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(398, 234);
            button1.Name = "button1";
            button1.Size = new Size(139, 23);
            button1.TabIndex = 88;
            button1.Text = "Ajouter une image ici";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.Location = new Point(638, 263);
            button2.Name = "button2";
            button2.Size = new Size(88, 27);
            button2.TabIndex = 89;
            button2.Text = "Ajouter";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ajoutbien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(typeannonce);
            Controls.Add(label13);
            Controls.Add(anneeconst);
            Controls.Add(label12);
            Controls.Add(chambre);
            Controls.Add(label11);
            Controls.Add(checkBox8);
            Controls.Add(checkBox7);
            Controls.Add(label10);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(label9);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(label8);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(etatgeneral);
            Controls.Add(etage);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(terrain);
            Controls.Add(label4);
            Controls.Add(typebien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(Box);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ajoutbien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ajoutbien";
            Load += ajoutbien_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Box).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox Box;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private TextBox typebien;
        private Label label4;
        private TextBox terrain;
        private Label label5;
        private Label label6;
        private TextBox etage;
        private ComboBox etatgeneral;
        private Label label7;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label8;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label9;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Label label10;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private Label label11;
        private TextBox chambre;
        private Label label12;
        private TextBox anneeconst;
        private Label label13;
        private ComboBox typeannonce;
        private PictureBox pictureBox4;
        private Button button1;
        private Button button2;
    }
}
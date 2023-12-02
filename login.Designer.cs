namespace ProjetGestionD_AgenceImmobilière
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            mdp = new TextBox();
            button3 = new Button();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            email = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(mdp);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(email);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(366, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 355);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // mdp
            // 
            mdp.Location = new Point(211, 156);
            mdp.Name = "mdp";
            mdp.Size = new Size(129, 23);
            mdp.TabIndex = 11;
            mdp.UseSystemPasswordChar = true;
            mdp.TextChanged += mdp_TextChanged_1;
            // 
            // button3
            // 
            button3.Location = new Point(133, 306);
            button3.Name = "button3";
            button3.Size = new Size(114, 22);
            button3.TabIndex = 10;
            button3.Text = "Quitter";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ActiveCaptionText;
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(211, 204);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(146, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Afficher Les Caractéres";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(211, 261);
            button2.Name = "button2";
            button2.Size = new Size(113, 22);
            button2.TabIndex = 7;
            button2.Text = "Inscription";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(73, 261);
            button1.Name = "button1";
            button1.Size = new Size(114, 22);
            button1.TabIndex = 6;
            button1.Text = "Se Connecter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // email
            // 
            email.Location = new Point(211, 98);
            email.Name = "email";
            email.Size = new Size(129, 23);
            email.TabIndex = 4;
            email.TextChanged += email_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(417, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(56, 159);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 2;
            label4.Text = "Mot De Passe ";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(56, 97);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 1;
            label3.Text = "Adresse E-mail";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(191, 33);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 0;
            label2.Text = "LOGIN";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(23, 89);
            label1.Name = "label1";
            label1.Size = new Size(308, 30);
            label1.TabIndex = 1;
            label1.Text = "Gestion D'Agence Immobilière ";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(19, 23);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 30;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(0, 29);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(19, 19);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 31;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(0, 54);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(19, 17);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 32;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 314);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(16, 16);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 33;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(23, 315);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 34;
            label5.Text = "06.19.19.33.33";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(187, 336);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 35;
            label6.Text = "agenceimmo@gmail";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(163, 336);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 19);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 36;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(23, 336);
            label7.Name = "label7";
            label7.Size = new Size(134, 15);
            label7.TabIndex = 37;
            label7.Text = "www.agenceImmo.com";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 336);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(20, 19);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 38;
            pictureBox6.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 354);
            Controls.Add(pictureBox6);
            Controls.Add(label7);
            Controls.Add(pictureBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox email;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button3;
        private CheckBox checkBox1;
        private TextBox mdp;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox5;
        private Label label7;
        private PictureBox pictureBox6;
    }
}
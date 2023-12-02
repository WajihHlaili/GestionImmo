using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionD_AgenceImmobilière
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            timer1.Start();

        }


        

        private Label label1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SuspendLayout();
           
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(171, 66);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 0;
            label1.Text = "Loading ....";
            
            progressBar1.Location = new Point(79, 133);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(341, 23);
            progressBar1.TabIndex = 1;
           
            timer1.Interval = 100; 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
           
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Subheading", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(426, 133);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 2;
            label2.Text = "label2";
           
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(514, 237);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;
                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {

                timer1.Stop();

                login l = new login();
                l.FormClosed += (s, args) => CloseLoadingForm();
                l.Show();
                this.Hide();
            }

        }
        private void CloseLoadingForm()
        {
            this.Close();
        }
    }
}

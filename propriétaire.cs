using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionD_AgenceImmobilière
{
    public partial class propriétaire : Form
    {
        private int userId;
        public propriétaire(int userId)
        {
            InitializeComponent();
            this.userId= userId;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            ajoutbien f = new ajoutbien(userId);
            f.Show();
            this.Hide();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           notifprop f = new notifprop ();
            f.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class GUI : Form
    {
        private JPEG Imagine;
        public GUI()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Hrajkartu_Click(object sender, EventArgs e)
        {

            testkarta.Location = new Point (655,230);
            
        }
        private void SelectCard()
        {

        }

        private void Tahnikartu_Click(object sender, EventArgs e)
        {
           PictureBox Karta = new PictureBox();
            Karta.Image = Client.Properties.Resources.KartaBack;
          
        }
        
    }
}

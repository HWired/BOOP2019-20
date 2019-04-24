using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Properties;

namespace Client
{
    public partial class GUI : Form
    {
        bool ulozenikarty = false;
        PictureBox predeslaKarta = null;
        PictureBox vybranakarta = null;
        public GUI()
        {
            InitializeComponent();
        }

        private void Hrajkartu_Click(object sender, EventArgs e)
        {
            OdlozenaKarta.Image = vybranakarta.Image;
            vybranakarta.Visible = false;
            vybranakarta.Image = null;

        }
     

        private void Tahnikartu_Click(object sender, EventArgs e)
        {
           
            Bitmap obrazek = new Bitmap(Resources.Kary8);
            Karta1.Image = (Image)obrazek;
          
        }

        private void Nahraj()
        {
            // 0,1,2,3,4,5,6,7,8,9,10,11,12,13
            // 1,2,3,4,5,6,7,8,9,10,J,Q,K,A
            //[0][x] Kary
            //[1][x] Srdce
            //[2][x] Piky
            //[3][x] Krize
            //[4][1-2]  Back,TestKarta  
          
        }

        private void KliknulNaKartu(object sender, EventArgs e)
        {
            if (ulozenikarty)
            {
                predeslaKarta.Location = new Point(predeslaKarta.Location.X, predeslaKarta.Location.Y + 50);

            }
            predeslaKarta = (PictureBox)sender;
            ulozenikarty = true;
            vybranakarta = (PictureBox)sender;
            vybranakarta.Location = new Point(vybranakarta.Location.X, vybranakarta.Location.Y - 50);

        }
    }
}

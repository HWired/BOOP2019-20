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
        bool kartaRozdana = false ;
        bool jmenoDano = false;
        PictureBox predeslaKarta = null;
        PictureBox vybranakarta = null;
        Bitmap[,] hraciKarty = new Bitmap [4,13];
        Bitmap obrazek;

        Networking networking;

        public GUI(Networking networking)
        {
            InitializeComponent();
            this.networking = networking;

            Nahraj();

            prirazeniJmen();
        }

        private void Hrajkartu_Click(object sender, EventArgs e)
        {
            OdlozenaKarta.Image = vybranakarta.Image;
            vybranakarta.Visible = false;
            vybranakarta.Image = null;
            

        }

        private void prirazeniJmen()
        {
            daniJmena(label1,"Test");
        }

        private void Tahnikartu_Click(object sender, EventArgs e)
        {
           
            kartaRozdana = false;
            obrazek = new Bitmap(Nahraj(0,1));
            daniKarty(Karta1);
            daniKarty(Karta2);
            daniKarty(Karta3);
            daniKarty(Karta4);
            daniKarty(Karta5);
            daniKarty(Karta6);
            daniKarty(Karta7);
            daniKarty(Karta8);
            daniKarty(Karta9);
            daniKarty(Karta10);
            daniKarty(pictureBox1);
            daniKarty(pictureBox2);
            daniKarty(pictureBox3);
            daniKarty(pictureBox4);
            daniKarty(pictureBox5);
            daniKarty(pictureBox6);
            daniKarty(pictureBox7);
            daniKarty(pictureBox8);
            
        }

        private void Nahraj()
        {
            //Nacitam do pole kvuli randomizaci
            // 0,1,2,3,4,5,6,7,8,9,10,11,12,13
            // 2,3,4,5,6,7,8,9,10,J,Q,K,A
            //[0][x] Kary
            //[1][x] Srdce
            //[2][x] Piky
            //[3][x] Krize
            //[4][1-2]  Back,TestKarta  

            hraciKarty[0,0] = Resources.Kary2;
            hraciKarty[0,1] = Resources.Kary3;
            hraciKarty[0,2] = Resources.Kary4;
            hraciKarty[0,3] = Resources.Kary5;
            hraciKarty[0,4] = Resources.Kary6;
            hraciKarty[0,5] = Resources.Kary7;
            hraciKarty[0,6] = Resources.Kary8;
            hraciKarty[0,7] = Resources.Kary9;
            hraciKarty[0,8] = Resources.Kary10;
            hraciKarty[0,9] = Resources.KaryJ;
            hraciKarty[0,10] = Resources.KaryQ;
            hraciKarty[0,11] = Resources.KaryK;
            hraciKarty[0,12] = Resources.KaryA;

            hraciKarty[1,0] = Resources.Srdce2;
            hraciKarty[1,1] = Resources.Srdce2;
            hraciKarty[1,2] = Resources.Srdce2;
            hraciKarty[1,3] = Resources.Srdce2;
            hraciKarty[1,4] = Resources.Srdce2;
            hraciKarty[1,5] = Resources.Srdce2;
            hraciKarty[1,6] = Resources.Srdce2;
            hraciKarty[1,7] = Resources.Srdce2;
            hraciKarty[1,8] = Resources.Srdce2;
            hraciKarty[1,9] = Resources.Srdce2;
            hraciKarty[1,10] = Resources.Srdce2;
            hraciKarty[1,11] = Resources.Srdce2;
            hraciKarty[1,12] = Resources.Srdce2;

            hraciKarty[2,0] = Resources.Piki2;
            hraciKarty[2,1] = Resources.Piki2;
            hraciKarty[2,2] = Resources.Piki2;
            hraciKarty[2,3] = Resources.Piki2;
            hraciKarty[2,4] = Resources.Piki2;
            hraciKarty[2,5] = Resources.Piki2;
            hraciKarty[2,6] = Resources.Piki2;
            hraciKarty[2,7] = Resources.Piki2;
            hraciKarty[2,8] = Resources.Piki2;
            hraciKarty[2,9] = Resources.Piki2;
            hraciKarty[2,10] = Resources.Piki2;
            hraciKarty[2,11] = Resources.Piki2;
            hraciKarty[2,12] = Resources.Piki2;

            hraciKarty[3,0] = Resources.Kriz2;
            hraciKarty[3,1] = Resources.Kriz2;
            hraciKarty[3,2] = Resources.Kriz2;
            hraciKarty[3,3] = Resources.Kriz2;
            hraciKarty[3,4] = Resources.Kriz2;
            hraciKarty[3,5] = Resources.Kriz2;
            hraciKarty[3,6] = Resources.Kriz2;
            hraciKarty[3,7] = Resources.Kriz2;
            hraciKarty[3,8] = Resources.Kriz2;
            hraciKarty[3,9] = Resources.Kriz2;
            hraciKarty[3,10] = Resources.Kriz2;
            hraciKarty[3,11] = Resources.Kriz2;
            hraciKarty[3,12] = Resources.Kriz2;

            
            
            

          
        }
        private Bitmap Nahraj(int random1,int random2)
        {
            return hraciKarty[random1,random2];

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

        private void daniKarty(PictureBox karta)
        {
            if(karta.Visible == false && kartaRozdana == false)
            {
                karta.Image = (Image)obrazek;
                karta.Visible = true;
                kartaRozdana = true;
            }
        }

        private void daniJmena(Label jmeno,string Nick)
        {
            if (jmeno.Visible == false && jmenoDano == false)
            {
                jmeno.Text = Nick;
                jmeno.Visible = true;
                jmenoDano = true;
            }
        }
    }
}

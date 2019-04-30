namespace Client
{
    partial class GameGUI
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
            this.Hrajkartu = new System.Windows.Forms.Button();
            this.Tahnikartu = new System.Windows.Forms.Button();
            this.Karta1 = new System.Windows.Forms.PictureBox();
            this.OdlozenaKarta = new System.Windows.Forms.PictureBox();
            this.Karta2 = new System.Windows.Forms.PictureBox();
            this.Karta3 = new System.Windows.Forms.PictureBox();
            this.Karta4 = new System.Windows.Forms.PictureBox();
            this.Karta5 = new System.Windows.Forms.PictureBox();
            this.Karta6 = new System.Windows.Forms.PictureBox();
            this.Karta7 = new System.Windows.Forms.PictureBox();
            this.Karta8 = new System.Windows.Forms.PictureBox();
            this.Karta9 = new System.Windows.Forms.PictureBox();
            this.Karta10 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.PlayerBox = new System.Windows.Forms.GroupBox();
            this.StartGameBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Karta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdlozenaKarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // Hrajkartu
            // 
            this.Hrajkartu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Hrajkartu.Location = new System.Drawing.Point(1233, 625);
            this.Hrajkartu.Name = "Hrajkartu";
            this.Hrajkartu.Size = new System.Drawing.Size(125, 77);
            this.Hrajkartu.TabIndex = 1;
            this.Hrajkartu.Text = "Hraj kartu";
            this.Hrajkartu.UseVisualStyleBackColor = true;
            this.Hrajkartu.Click += new System.EventHandler(this.Hrajkartu_Click);
            // 
            // Tahnikartu
            // 
            this.Tahnikartu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Tahnikartu.Location = new System.Drawing.Point(12, 625);
            this.Tahnikartu.Name = "Tahnikartu";
            this.Tahnikartu.Size = new System.Drawing.Size(128, 77);
            this.Tahnikartu.TabIndex = 2;
            this.Tahnikartu.Text = "Tahni Kartu";
            this.Tahnikartu.UseVisualStyleBackColor = true;
            this.Tahnikartu.Click += new System.EventHandler(this.Tahnikartu_Click);
            // 
            // Karta1
            // 
            this.Karta1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Karta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Karta1.Image = global::Client.Properties.Resources.Kriz9;
            this.Karta1.Location = new System.Drawing.Point(98, 508);
            this.Karta1.Name = "Karta1";
            this.Karta1.Size = new System.Drawing.Size(154, 194);
            this.Karta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Karta1.TabIndex = 3;
            this.Karta1.TabStop = false;
            this.Karta1.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // OdlozenaKarta
            // 
            this.OdlozenaKarta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OdlozenaKarta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OdlozenaKarta.Image = global::Client.Properties.Resources.Kary2;
            this.OdlozenaKarta.Location = new System.Drawing.Point(600, 210);
            this.OdlozenaKarta.Name = "OdlozenaKarta";
            this.OdlozenaKarta.Size = new System.Drawing.Size(154, 194);
            this.OdlozenaKarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OdlozenaKarta.TabIndex = 4;
            this.OdlozenaKarta.TabStop = false;
            // 
            // Karta2
            // 
            this.Karta2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Karta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Karta2.Image = global::Client.Properties.Resources.Kriz9;
            this.Karta2.Location = new System.Drawing.Point(157, 508);
            this.Karta2.Name = "Karta2";
            this.Karta2.Size = new System.Drawing.Size(154, 194);
            this.Karta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Karta2.TabIndex = 5;
            this.Karta2.TabStop = false;
            this.Karta2.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // Karta3
            // 
            this.Karta3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Karta3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Karta3.Image = global::Client.Properties.Resources.Kriz9;
            this.Karta3.Location = new System.Drawing.Point(216, 508);
            this.Karta3.Name = "Karta3";
            this.Karta3.Size = new System.Drawing.Size(154, 194);
            this.Karta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Karta3.TabIndex = 6;
            this.Karta3.TabStop = false;
            this.Karta3.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // Karta4
            // 
            this.Karta4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Karta4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Karta4.Image = global::Client.Properties.Resources.Kriz9;
            this.Karta4.Location = new System.Drawing.Point(275, 508);
            this.Karta4.Name = "Karta4";
            this.Karta4.Size = new System.Drawing.Size(154, 194);
            this.Karta4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Karta4.TabIndex = 7;
            this.Karta4.TabStop = false;
            this.Karta4.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // Karta5
            // 
            this.Karta5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Karta5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Karta5.Image = global::Client.Properties.Resources.Kriz9;
            this.Karta5.Location = new System.Drawing.Point(335, 508);
            this.Karta5.Name = "Karta5";
            this.Karta5.Size = new System.Drawing.Size(154, 194);
            this.Karta5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Karta5.TabIndex = 8;
            this.Karta5.TabStop = false;
            this.Karta5.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // Karta6
            // 
            this.Karta6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Karta6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Karta6.Image = global::Client.Properties.Resources.Kriz9;
            this.Karta6.Location = new System.Drawing.Point(395, 508);
            this.Karta6.Name = "Karta6";
            this.Karta6.Size = new System.Drawing.Size(154, 194);
            this.Karta6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Karta6.TabIndex = 9;
            this.Karta6.TabStop = false;
            this.Karta6.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // Karta7
            // 
            this.Karta7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Karta7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Karta7.Image = global::Client.Properties.Resources.Kriz9;
            this.Karta7.Location = new System.Drawing.Point(454, 508);
            this.Karta7.Name = "Karta7";
            this.Karta7.Size = new System.Drawing.Size(154, 194);
            this.Karta7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Karta7.TabIndex = 10;
            this.Karta7.TabStop = false;
            this.Karta7.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // Karta8
            // 
            this.Karta8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Karta8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Karta8.Image = global::Client.Properties.Resources.Kriz9;
            this.Karta8.Location = new System.Drawing.Point(513, 508);
            this.Karta8.Name = "Karta8";
            this.Karta8.Size = new System.Drawing.Size(154, 194);
            this.Karta8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Karta8.TabIndex = 11;
            this.Karta8.TabStop = false;
            this.Karta8.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // Karta9
            // 
            this.Karta9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Karta9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Karta9.Image = global::Client.Properties.Resources.Kriz9;
            this.Karta9.Location = new System.Drawing.Point(573, 508);
            this.Karta9.Name = "Karta9";
            this.Karta9.Size = new System.Drawing.Size(154, 194);
            this.Karta9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Karta9.TabIndex = 12;
            this.Karta9.TabStop = false;
            this.Karta9.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // Karta10
            // 
            this.Karta10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Karta10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Karta10.Image = global::Client.Properties.Resources.Kriz9;
            this.Karta10.Location = new System.Drawing.Point(632, 508);
            this.Karta10.Name = "Karta10";
            this.Karta10.Size = new System.Drawing.Size(154, 194);
            this.Karta10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Karta10.TabIndex = 13;
            this.Karta10.TabStop = false;
            this.Karta10.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Client.Properties.Resources.Kriz9;
            this.pictureBox1.Location = new System.Drawing.Point(692, 508);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Client.Properties.Resources.Kriz9;
            this.pictureBox2.Location = new System.Drawing.Point(751, 508);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::Client.Properties.Resources.Kriz9;
            this.pictureBox3.Location = new System.Drawing.Point(811, 508);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 194);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::Client.Properties.Resources.Kriz9;
            this.pictureBox4.Location = new System.Drawing.Point(870, 508);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(154, 194);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::Client.Properties.Resources.Kriz9;
            this.pictureBox5.Location = new System.Drawing.Point(930, 508);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(154, 194);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Image = global::Client.Properties.Resources.Kriz9;
            this.pictureBox6.Location = new System.Drawing.Point(989, 508);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(154, 194);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox7.Image = global::Client.Properties.Resources.Kriz9;
            this.pictureBox7.Location = new System.Drawing.Point(1047, 508);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(154, 194);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox8.Image = global::Client.Properties.Resources.Kriz9;
            this.pictureBox8.Location = new System.Drawing.Point(1107, 508);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(154, 194);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.KliknulNaKartu);
            // 
            // PlayerBox
            // 
            this.PlayerBox.Location = new System.Drawing.Point(12, 12);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(194, 163);
            this.PlayerBox.TabIndex = 22;
            this.PlayerBox.TabStop = false;
            this.PlayerBox.Text = "Players";
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.Location = new System.Drawing.Point(216, 13);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(75, 23);
            this.StartGameBtn.TabIndex = 23;
            this.StartGameBtn.Text = "Start Game";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            // 
            // GameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 714);
            this.Controls.Add(this.StartGameBtn);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Karta10);
            this.Controls.Add(this.Karta9);
            this.Controls.Add(this.Karta8);
            this.Controls.Add(this.Karta7);
            this.Controls.Add(this.Karta6);
            this.Controls.Add(this.Karta5);
            this.Controls.Add(this.Karta4);
            this.Controls.Add(this.Karta3);
            this.Controls.Add(this.Karta2);
            this.Controls.Add(this.OdlozenaKarta);
            this.Controls.Add(this.Karta1);
            this.Controls.Add(this.Tahnikartu);
            this.Controls.Add(this.Hrajkartu);
            this.Name = "GameGUI";
            this.Text = "GUI";
            ((System.ComponentModel.ISupportInitialize)(this.Karta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdlozenaKarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Karta10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Hrajkartu;
        private System.Windows.Forms.Button Tahnikartu;
        private System.Windows.Forms.PictureBox Karta1;
        private System.Windows.Forms.PictureBox OdlozenaKarta;
        private System.Windows.Forms.PictureBox Karta2;
        private System.Windows.Forms.PictureBox Karta3;
        private System.Windows.Forms.PictureBox Karta4;
        private System.Windows.Forms.PictureBox Karta5;
        private System.Windows.Forms.PictureBox Karta6;
        private System.Windows.Forms.PictureBox Karta7;
        private System.Windows.Forms.PictureBox Karta8;
        private System.Windows.Forms.PictureBox Karta9;
        private System.Windows.Forms.PictureBox Karta10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.GroupBox PlayerBox;
        private System.Windows.Forms.Button StartGameBtn;
    }
}
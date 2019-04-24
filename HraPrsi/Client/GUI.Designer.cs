namespace Client
{
    partial class GUI
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
            this.testkarta = new System.Windows.Forms.PictureBox();
            this.Hrajkartu = new System.Windows.Forms.Button();
            this.Tahnikartu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.testkarta)).BeginInit();
            this.SuspendLayout();
            // 
            // testkarta
            // 
            this.testkarta.AccessibleDescription = "testkarta";
            this.testkarta.AccessibleName = "testkarta";
            this.testkarta.Image = global::Client.Properties.Resources.TestKarty;
            this.testkarta.Location = new System.Drawing.Point(644, 522);
            this.testkarta.Name = "testkarta";
            this.testkarta.Size = new System.Drawing.Size(160, 180);
            this.testkarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.testkarta.TabIndex = 1;
            this.testkarta.TabStop = false;
            this.testkarta.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Hrajkartu
            // 
            this.Hrajkartu.Location = new System.Drawing.Point(1329, 625);
            this.Hrajkartu.Name = "Hrajkartu";
            this.Hrajkartu.Size = new System.Drawing.Size(125, 77);
            this.Hrajkartu.TabIndex = 2;
            this.Hrajkartu.Text = "Hraj kartu";
            this.Hrajkartu.UseVisualStyleBackColor = true;
            this.Hrajkartu.Click += new System.EventHandler(this.Hrajkartu_Click);
            // 
            // Tahnikartu
            // 
            this.Tahnikartu.Location = new System.Drawing.Point(12, 625);
            this.Tahnikartu.Name = "Tahnikartu";
            this.Tahnikartu.Size = new System.Drawing.Size(128, 77);
            this.Tahnikartu.TabIndex = 3;
            this.Tahnikartu.Text = "Tahni Kartu";
            this.Tahnikartu.UseVisualStyleBackColor = true;
            this.Tahnikartu.Click += new System.EventHandler(this.Tahnikartu_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 714);
            this.Controls.Add(this.Tahnikartu);
            this.Controls.Add(this.Hrajkartu);
            this.Controls.Add(this.testkarta);
            this.Name = "GUI";
            this.Text = "GUI";
            ((System.ComponentModel.ISupportInitialize)(this.testkarta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox testkarta;
        private System.Windows.Forms.Button Hrajkartu;
        private System.Windows.Forms.Button Tahnikartu;
    }
}
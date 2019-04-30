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
            this.PlayCardBtn = new System.Windows.Forms.Button();
            this.SkipTurnBtn = new System.Windows.Forms.Button();
            this.PlayedCard = new System.Windows.Forms.PictureBox();
            this.PlayerBox = new System.Windows.Forms.GroupBox();
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.LeaveRoomBtn = new System.Windows.Forms.Button();
            this.Card18 = new System.Windows.Forms.PictureBox();
            this.Card17 = new System.Windows.Forms.PictureBox();
            this.Card16 = new System.Windows.Forms.PictureBox();
            this.Card15 = new System.Windows.Forms.PictureBox();
            this.Card14 = new System.Windows.Forms.PictureBox();
            this.Card13 = new System.Windows.Forms.PictureBox();
            this.Card12 = new System.Windows.Forms.PictureBox();
            this.Card11 = new System.Windows.Forms.PictureBox();
            this.Card10 = new System.Windows.Forms.PictureBox();
            this.Card9 = new System.Windows.Forms.PictureBox();
            this.Card8 = new System.Windows.Forms.PictureBox();
            this.Card7 = new System.Windows.Forms.PictureBox();
            this.Card6 = new System.Windows.Forms.PictureBox();
            this.Card5 = new System.Windows.Forms.PictureBox();
            this.Card4 = new System.Windows.Forms.PictureBox();
            this.Card3 = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.Card1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayedCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayCardBtn
            // 
            this.PlayCardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayCardBtn.Location = new System.Drawing.Point(1233, 625);
            this.PlayCardBtn.Name = "PlayCardBtn";
            this.PlayCardBtn.Size = new System.Drawing.Size(125, 77);
            this.PlayCardBtn.TabIndex = 1;
            this.PlayCardBtn.Text = "Play Card";
            this.PlayCardBtn.UseVisualStyleBackColor = true;
            this.PlayCardBtn.Click += new System.EventHandler(this.PlayCardBtn_Click);
            // 
            // SkipTurnBtn
            // 
            this.SkipTurnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SkipTurnBtn.Location = new System.Drawing.Point(12, 625);
            this.SkipTurnBtn.Name = "SkipTurnBtn";
            this.SkipTurnBtn.Size = new System.Drawing.Size(128, 77);
            this.SkipTurnBtn.TabIndex = 2;
            this.SkipTurnBtn.Text = "Skip Turn";
            this.SkipTurnBtn.UseVisualStyleBackColor = true;
            this.SkipTurnBtn.Click += new System.EventHandler(this.SkipTurnBtn_Click);
            // 
            // PlayedCard
            // 
            this.PlayedCard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PlayedCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayedCard.Image = global::Client.Properties.Resources.Kary2;
            this.PlayedCard.Location = new System.Drawing.Point(600, 210);
            this.PlayedCard.Name = "PlayedCard";
            this.PlayedCard.Size = new System.Drawing.Size(154, 194);
            this.PlayedCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayedCard.TabIndex = 4;
            this.PlayedCard.TabStop = false;
            this.PlayedCard.Visible = false;
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
            this.StartGameBtn.Location = new System.Drawing.Point(12, 181);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(95, 23);
            this.StartGameBtn.TabIndex = 23;
            this.StartGameBtn.Text = "Start Game";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // LeaveRoomBtn
            // 
            this.LeaveRoomBtn.Location = new System.Drawing.Point(111, 181);
            this.LeaveRoomBtn.Name = "LeaveRoomBtn";
            this.LeaveRoomBtn.Size = new System.Drawing.Size(95, 23);
            this.LeaveRoomBtn.TabIndex = 24;
            this.LeaveRoomBtn.Text = "Leave Room";
            this.LeaveRoomBtn.UseVisualStyleBackColor = true;
            this.LeaveRoomBtn.Click += new System.EventHandler(this.LeaveRoomBtn_Click);
            // 
            // Card18
            // 
            this.Card18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card18.Image = global::Client.Properties.Resources.Kriz9;
            this.Card18.Location = new System.Drawing.Point(1107, 508);
            this.Card18.Name = "Card18";
            this.Card18.Size = new System.Drawing.Size(154, 194);
            this.Card18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card18.TabIndex = 21;
            this.Card18.TabStop = false;
            this.Card18.Visible = false;
            this.Card18.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card17
            // 
            this.Card17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card17.Image = global::Client.Properties.Resources.Kriz9;
            this.Card17.Location = new System.Drawing.Point(1047, 508);
            this.Card17.Name = "Card17";
            this.Card17.Size = new System.Drawing.Size(154, 194);
            this.Card17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card17.TabIndex = 20;
            this.Card17.TabStop = false;
            this.Card17.Visible = false;
            this.Card17.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card16
            // 
            this.Card16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card16.Image = global::Client.Properties.Resources.Kriz9;
            this.Card16.Location = new System.Drawing.Point(989, 508);
            this.Card16.Name = "Card16";
            this.Card16.Size = new System.Drawing.Size(154, 194);
            this.Card16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card16.TabIndex = 19;
            this.Card16.TabStop = false;
            this.Card16.Visible = false;
            this.Card16.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card15
            // 
            this.Card15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card15.Image = global::Client.Properties.Resources.Kriz9;
            this.Card15.Location = new System.Drawing.Point(930, 508);
            this.Card15.Name = "Card15";
            this.Card15.Size = new System.Drawing.Size(154, 194);
            this.Card15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card15.TabIndex = 18;
            this.Card15.TabStop = false;
            this.Card15.Visible = false;
            this.Card15.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card14
            // 
            this.Card14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card14.Image = global::Client.Properties.Resources.Kriz9;
            this.Card14.Location = new System.Drawing.Point(870, 508);
            this.Card14.Name = "Card14";
            this.Card14.Size = new System.Drawing.Size(154, 194);
            this.Card14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card14.TabIndex = 17;
            this.Card14.TabStop = false;
            this.Card14.Visible = false;
            this.Card14.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card13
            // 
            this.Card13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card13.Image = global::Client.Properties.Resources.Kriz9;
            this.Card13.Location = new System.Drawing.Point(811, 508);
            this.Card13.Name = "Card13";
            this.Card13.Size = new System.Drawing.Size(154, 194);
            this.Card13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card13.TabIndex = 16;
            this.Card13.TabStop = false;
            this.Card13.Visible = false;
            this.Card13.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card12
            // 
            this.Card12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card12.Image = global::Client.Properties.Resources.Kriz9;
            this.Card12.Location = new System.Drawing.Point(751, 508);
            this.Card12.Name = "Card12";
            this.Card12.Size = new System.Drawing.Size(154, 194);
            this.Card12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card12.TabIndex = 15;
            this.Card12.TabStop = false;
            this.Card12.Visible = false;
            this.Card12.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card11
            // 
            this.Card11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card11.Image = global::Client.Properties.Resources.Kriz9;
            this.Card11.Location = new System.Drawing.Point(692, 508);
            this.Card11.Name = "Card11";
            this.Card11.Size = new System.Drawing.Size(154, 194);
            this.Card11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card11.TabIndex = 14;
            this.Card11.TabStop = false;
            this.Card11.Visible = false;
            this.Card11.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card10
            // 
            this.Card10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card10.Image = global::Client.Properties.Resources.Kriz9;
            this.Card10.Location = new System.Drawing.Point(632, 508);
            this.Card10.Name = "Card10";
            this.Card10.Size = new System.Drawing.Size(154, 194);
            this.Card10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card10.TabIndex = 13;
            this.Card10.TabStop = false;
            this.Card10.Visible = false;
            this.Card10.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card9
            // 
            this.Card9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card9.Image = global::Client.Properties.Resources.Kriz9;
            this.Card9.Location = new System.Drawing.Point(573, 508);
            this.Card9.Name = "Card9";
            this.Card9.Size = new System.Drawing.Size(154, 194);
            this.Card9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card9.TabIndex = 12;
            this.Card9.TabStop = false;
            this.Card9.Visible = false;
            this.Card9.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card8
            // 
            this.Card8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card8.Image = global::Client.Properties.Resources.Kriz9;
            this.Card8.Location = new System.Drawing.Point(513, 508);
            this.Card8.Name = "Card8";
            this.Card8.Size = new System.Drawing.Size(154, 194);
            this.Card8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card8.TabIndex = 11;
            this.Card8.TabStop = false;
            this.Card8.Visible = false;
            this.Card8.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card7
            // 
            this.Card7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card7.Image = global::Client.Properties.Resources.Kriz9;
            this.Card7.Location = new System.Drawing.Point(454, 508);
            this.Card7.Name = "Card7";
            this.Card7.Size = new System.Drawing.Size(154, 194);
            this.Card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card7.TabIndex = 10;
            this.Card7.TabStop = false;
            this.Card7.Visible = false;
            this.Card7.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card6
            // 
            this.Card6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card6.Image = global::Client.Properties.Resources.Kriz9;
            this.Card6.Location = new System.Drawing.Point(395, 508);
            this.Card6.Name = "Card6";
            this.Card6.Size = new System.Drawing.Size(154, 194);
            this.Card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card6.TabIndex = 9;
            this.Card6.TabStop = false;
            this.Card6.Visible = false;
            this.Card6.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card5
            // 
            this.Card5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card5.Image = global::Client.Properties.Resources.Kriz9;
            this.Card5.Location = new System.Drawing.Point(335, 508);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(154, 194);
            this.Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card5.TabIndex = 8;
            this.Card5.TabStop = false;
            this.Card5.Visible = false;
            this.Card5.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card4
            // 
            this.Card4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card4.Image = global::Client.Properties.Resources.Kriz9;
            this.Card4.Location = new System.Drawing.Point(275, 508);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(154, 194);
            this.Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card4.TabIndex = 7;
            this.Card4.TabStop = false;
            this.Card4.Visible = false;
            this.Card4.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card3
            // 
            this.Card3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card3.Image = global::Client.Properties.Resources.Kriz9;
            this.Card3.Location = new System.Drawing.Point(216, 508);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(154, 194);
            this.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card3.TabIndex = 6;
            this.Card3.TabStop = false;
            this.Card3.Visible = false;
            this.Card3.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card2
            // 
            this.Card2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card2.Image = global::Client.Properties.Resources.Kriz9;
            this.Card2.Location = new System.Drawing.Point(157, 508);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(154, 194);
            this.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card2.TabIndex = 5;
            this.Card2.TabStop = false;
            this.Card2.Visible = false;
            this.Card2.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card1
            // 
            this.Card1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Card1.Image = global::Client.Properties.Resources.Kriz9;
            this.Card1.Location = new System.Drawing.Point(98, 508);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(154, 194);
            this.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card1.TabIndex = 3;
            this.Card1.TabStop = false;
            this.Card1.Visible = false;
            this.Card1.Click += new System.EventHandler(this.Card_Click);
            // 
            // GameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 714);
            this.Controls.Add(this.LeaveRoomBtn);
            this.Controls.Add(this.StartGameBtn);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.Card18);
            this.Controls.Add(this.Card17);
            this.Controls.Add(this.Card16);
            this.Controls.Add(this.Card15);
            this.Controls.Add(this.Card14);
            this.Controls.Add(this.Card13);
            this.Controls.Add(this.Card12);
            this.Controls.Add(this.Card11);
            this.Controls.Add(this.Card10);
            this.Controls.Add(this.Card9);
            this.Controls.Add(this.Card8);
            this.Controls.Add(this.Card7);
            this.Controls.Add(this.Card6);
            this.Controls.Add(this.Card5);
            this.Controls.Add(this.Card4);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.PlayedCard);
            this.Controls.Add(this.Card1);
            this.Controls.Add(this.SkipTurnBtn);
            this.Controls.Add(this.PlayCardBtn);
            this.Name = "GameGUI";
            this.Text = "Hra Prsi";
            ((System.ComponentModel.ISupportInitialize)(this.PlayedCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PlayCardBtn;
        private System.Windows.Forms.Button SkipTurnBtn;
        private System.Windows.Forms.PictureBox PlayedCard;
        private System.Windows.Forms.GroupBox PlayerBox;
        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.Button LeaveRoomBtn;
        private System.Windows.Forms.PictureBox Card18;
        private System.Windows.Forms.PictureBox Card17;
        private System.Windows.Forms.PictureBox Card16;
        private System.Windows.Forms.PictureBox Card15;
        private System.Windows.Forms.PictureBox Card14;
        private System.Windows.Forms.PictureBox Card13;
        private System.Windows.Forms.PictureBox Card12;
        private System.Windows.Forms.PictureBox Card11;
        private System.Windows.Forms.PictureBox Card10;
        private System.Windows.Forms.PictureBox Card9;
        private System.Windows.Forms.PictureBox Card8;
        private System.Windows.Forms.PictureBox Card7;
        private System.Windows.Forms.PictureBox Card6;
        private System.Windows.Forms.PictureBox Card5;
        private System.Windows.Forms.PictureBox Card4;
        private System.Windows.Forms.PictureBox Card3;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.PictureBox Card1;
    }
}
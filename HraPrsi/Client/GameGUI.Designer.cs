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
            this.PlayerBox = new System.Windows.Forms.GroupBox();
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.LeaveRoomBtn = new System.Windows.Forms.Button();
            this.CardBox = new System.Windows.Forms.GroupBox();
            this.CardOnTheTableBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // PlayCardBtn
            // 
            this.PlayCardBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PlayCardBtn.Location = new System.Drawing.Point(525, 544);
            this.PlayCardBtn.Name = "PlayCardBtn";
            this.PlayCardBtn.Size = new System.Drawing.Size(100, 30);
            this.PlayCardBtn.TabIndex = 1;
            this.PlayCardBtn.Text = "Play Card";
            this.PlayCardBtn.UseVisualStyleBackColor = true;
            this.PlayCardBtn.Click += new System.EventHandler(this.PlayCardBtn_Click);
            // 
            // SkipTurnBtn
            // 
            this.SkipTurnBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SkipTurnBtn.Location = new System.Drawing.Point(387, 544);
            this.SkipTurnBtn.Name = "SkipTurnBtn";
            this.SkipTurnBtn.Size = new System.Drawing.Size(100, 30);
            this.SkipTurnBtn.TabIndex = 2;
            this.SkipTurnBtn.Text = "Skip Turn";
            this.SkipTurnBtn.UseVisualStyleBackColor = true;
            this.SkipTurnBtn.Click += new System.EventHandler(this.SkipTurnBtn_Click);
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
            this.StartGameBtn.Enabled = false;
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
            // CardBox
            // 
            this.CardBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CardBox.Location = new System.Drawing.Point(53, 287);
            this.CardBox.Name = "CardBox";
            this.CardBox.Size = new System.Drawing.Size(900, 251);
            this.CardBox.TabIndex = 23;
            this.CardBox.TabStop = false;
            this.CardBox.Text = "Cards";
            // 
            // CardOnTheTableBox
            // 
            this.CardOnTheTableBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CardOnTheTableBox.Location = new System.Drawing.Point(397, 13);
            this.CardOnTheTableBox.Name = "CardOnTheTableBox";
            this.CardOnTheTableBox.Size = new System.Drawing.Size(194, 233);
            this.CardOnTheTableBox.TabIndex = 23;
            this.CardOnTheTableBox.TabStop = false;
            this.CardOnTheTableBox.Text = "Card on the table";
            // 
            // GameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 586);
            this.Controls.Add(this.SkipTurnBtn);
            this.Controls.Add(this.CardOnTheTableBox);
            this.Controls.Add(this.LeaveRoomBtn);
            this.Controls.Add(this.StartGameBtn);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.PlayCardBtn);
            this.Controls.Add(this.CardBox);
            this.Name = "GameGUI";
            this.Text = "Hra Prsi";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PlayCardBtn;
        private System.Windows.Forms.Button SkipTurnBtn;
        private System.Windows.Forms.GroupBox PlayerBox;
        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.Button LeaveRoomBtn;
        private System.Windows.Forms.GroupBox CardBox;
        private System.Windows.Forms.GroupBox CardOnTheTableBox;
    }
}
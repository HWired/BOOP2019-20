namespace Client
{
    partial class Form1
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
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.SessionCodeInput = new System.Windows.Forms.TextBox();
            this.SessionCodeLabel = new System.Windows.Forms.Label();
            this.JoinGameBtn = new System.Windows.Forms.Button();
            this.GetStateBtn = new System.Windows.Forms.Button();
            this.UpdateStateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Location = new System.Drawing.Point(13, 13);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(119, 23);
            this.NewGameBtn.TabIndex = 0;
            this.NewGameBtn.Text = "Create a new game";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // SessionCodeInput
            // 
            this.SessionCodeInput.Location = new System.Drawing.Point(89, 47);
            this.SessionCodeInput.Name = "SessionCodeInput";
            this.SessionCodeInput.Size = new System.Drawing.Size(168, 20);
            this.SessionCodeInput.TabIndex = 1;
            // 
            // SessionCodeLabel
            // 
            this.SessionCodeLabel.AutoSize = true;
            this.SessionCodeLabel.Location = new System.Drawing.Point(12, 50);
            this.SessionCodeLabel.Name = "SessionCodeLabel";
            this.SessionCodeLabel.Size = new System.Drawing.Size(71, 13);
            this.SessionCodeLabel.TabIndex = 2;
            this.SessionCodeLabel.Text = "Session code";
            // 
            // JoinGameBtn
            // 
            this.JoinGameBtn.Location = new System.Drawing.Point(138, 13);
            this.JoinGameBtn.Name = "JoinGameBtn";
            this.JoinGameBtn.Size = new System.Drawing.Size(119, 23);
            this.JoinGameBtn.TabIndex = 3;
            this.JoinGameBtn.Text = "Join existing game";
            this.JoinGameBtn.UseVisualStyleBackColor = true;
            this.JoinGameBtn.Click += new System.EventHandler(this.JoinGameBtn_Click);
            // 
            // GetStateBtn
            // 
            this.GetStateBtn.Location = new System.Drawing.Point(15, 73);
            this.GetStateBtn.Name = "GetStateBtn";
            this.GetStateBtn.Size = new System.Drawing.Size(119, 23);
            this.GetStateBtn.TabIndex = 4;
            this.GetStateBtn.Text = "Get state";
            this.GetStateBtn.UseVisualStyleBackColor = true;
            this.GetStateBtn.Click += new System.EventHandler(this.GetStateBtn_Click);
            // 
            // UpdateStateBtn
            // 
            this.UpdateStateBtn.Location = new System.Drawing.Point(140, 73);
            this.UpdateStateBtn.Name = "UpdateStateBtn";
            this.UpdateStateBtn.Size = new System.Drawing.Size(119, 23);
            this.UpdateStateBtn.TabIndex = 5;
            this.UpdateStateBtn.Text = "Update state";
            this.UpdateStateBtn.UseVisualStyleBackColor = true;
            this.UpdateStateBtn.Click += new System.EventHandler(this.UpdateStateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateStateBtn);
            this.Controls.Add(this.GetStateBtn);
            this.Controls.Add(this.JoinGameBtn);
            this.Controls.Add(this.SessionCodeLabel);
            this.Controls.Add(this.SessionCodeInput);
            this.Controls.Add(this.NewGameBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.TextBox SessionCodeInput;
        private System.Windows.Forms.Label SessionCodeLabel;
        private System.Windows.Forms.Button JoinGameBtn;
        private System.Windows.Forms.Button GetStateBtn;
        private System.Windows.Forms.Button UpdateStateBtn;
    }
}


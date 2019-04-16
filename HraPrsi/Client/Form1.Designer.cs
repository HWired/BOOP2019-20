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
            this.ReadString = new System.Windows.Forms.Button();
            this.AddString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadString
            // 
            this.ReadString.Location = new System.Drawing.Point(377, 198);
            this.ReadString.Name = "ReadString";
            this.ReadString.Size = new System.Drawing.Size(75, 23);
            this.ReadString.TabIndex = 0;
            this.ReadString.Text = "Read String";
            this.ReadString.UseVisualStyleBackColor = true;
            this.ReadString.Click += new System.EventHandler(this.ReadString_Click);
            // 
            // AddString
            // 
            this.AddString.Location = new System.Drawing.Point(377, 228);
            this.AddString.Name = "AddString";
            this.AddString.Size = new System.Drawing.Size(75, 23);
            this.AddString.TabIndex = 1;
            this.AddString.Text = "Add String";
            this.AddString.UseVisualStyleBackColor = true;
            this.AddString.Click += new System.EventHandler(this.AddString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddString);
            this.Controls.Add(this.ReadString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadString;
        private System.Windows.Forms.Button AddString;
    }
}


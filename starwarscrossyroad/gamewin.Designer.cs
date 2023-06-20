namespace starwarscrossyroad
{
    partial class gamewin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gamewin));
            this.win = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.BackColor = System.Drawing.Color.Transparent;
            this.win.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win.Location = new System.Drawing.Point(458, 264);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(406, 26);
            this.win.TabIndex = 0;
            this.win.Text = "YOU WON YOU DO NOT SUCK :)))))";
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(609, 483);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 23);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "To menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // gamewin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.win);
            this.Name = "gamewin";
            this.Size = new System.Drawing.Size(1380, 728);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Button menuButton;
    }
}

namespace starwarscrossyroad
{
    partial class gameobver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameobver));
            this.gameover = new System.Windows.Forms.Label();
            this.retrtbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameover.Font = new System.Drawing.Font("Ravie", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gameover.Location = new System.Drawing.Point(264, 35);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(793, 50);
            this.gameover.TabIndex = 0;
            this.gameover.Text = "GAME OVER!!!!!!!! YOU SUCK>:)))";
            // 
            // retrtbutton
            // 
            this.retrtbutton.Location = new System.Drawing.Point(563, 606);
            this.retrtbutton.Name = "retrtbutton";
            this.retrtbutton.Size = new System.Drawing.Size(75, 23);
            this.retrtbutton.TabIndex = 1;
            this.retrtbutton.Text = "Retry?";
            this.retrtbutton.UseVisualStyleBackColor = true;
            this.retrtbutton.Click += new System.EventHandler(this.retrtbutton_Click);
            // 
            // gameobver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.retrtbutton);
            this.Controls.Add(this.gameover);
            this.Name = "gameobver";
            this.Size = new System.Drawing.Size(1379, 747);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Button retrtbutton;
    }
}

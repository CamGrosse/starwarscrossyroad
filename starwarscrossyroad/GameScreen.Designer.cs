namespace starwarscrossyroad
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.gameticktimer = new System.Windows.Forms.Timer(this.components);
            this.nextLevelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameticktimer
            // 
            this.gameticktimer.Enabled = true;
            this.gameticktimer.Interval = 17;
            this.gameticktimer.Tick += new System.EventHandler(this.gameticktimer_Tick);
            // 
            // nextLevelButton
            // 
            this.nextLevelButton.Location = new System.Drawing.Point(609, 235);
            this.nextLevelButton.Name = "nextLevelButton";
            this.nextLevelButton.Size = new System.Drawing.Size(49, 37);
            this.nextLevelButton.TabIndex = 0;
            this.nextLevelButton.Text = "Next level";
            this.nextLevelButton.UseVisualStyleBackColor = true;
            this.nextLevelButton.Click += new System.EventHandler(this.nextLevelButton_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.nextLevelButton);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1500, 1100);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameticktimer;
        private System.Windows.Forms.Button nextLevelButton;
    }
}

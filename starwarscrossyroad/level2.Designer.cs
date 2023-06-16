namespace starwarscrossyroad
{
    partial class level2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(level2));
            this.gameticker = new System.Windows.Forms.Timer(this.components);
            this.nextLevelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameticker
            // 
            this.gameticker.Enabled = true;
            this.gameticker.Interval = 17;
            this.gameticker.Tick += new System.EventHandler(this.gameticker_Tick_1);
            // 
            // nextLevelButton
            // 
            this.nextLevelButton.Location = new System.Drawing.Point(521, 290);
            this.nextLevelButton.Name = "nextLevelButton";
            this.nextLevelButton.Size = new System.Drawing.Size(75, 23);
            this.nextLevelButton.TabIndex = 0;
            this.nextLevelButton.Text = "Next Level";
            this.nextLevelButton.UseVisualStyleBackColor = true;
            this.nextLevelButton.Click += new System.EventHandler(this.nextLevelButton_Click);
            // 
            // level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.nextLevelButton);
            this.DoubleBuffered = true;
            this.Name = "level2";
            this.Size = new System.Drawing.Size(1500, 1100);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.level2_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.level2_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.level2_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameticker;
        private System.Windows.Forms.Button nextLevelButton;
    }
}

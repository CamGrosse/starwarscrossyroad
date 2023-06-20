using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace starwarscrossyroad
{
    public partial class gamewin : UserControl
    {
        SoundPlayer joy = new SoundPlayer(Properties.Resources.joy);
        public gamewin()
        {
            InitializeComponent();
            happy();
        }
        public void happy()
        {
            joy.Play();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MenuScreen ms = new MenuScreen();
            f.Controls.Add((ms));
        }
    }
}

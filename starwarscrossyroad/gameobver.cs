﻿using System;
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
    public partial class gameobver : UserControl
    {
        SoundPlayer sad = new SoundPlayer(Properties.Resources.sad);
        public gameobver()
        {
            InitializeComponent();
            gamewin();
        }
        public void gamewin()
        {
            sad.Play();
        }
        private void retrtbutton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MenuScreen ms = new MenuScreen();
            f.Controls.Add((ms));
        }
    }
}

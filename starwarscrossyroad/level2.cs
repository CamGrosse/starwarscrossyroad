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
           
    public partial class level2 : UserControl
    {
        SoundPlayer death = new SoundPlayer(Properties.Resources.Dying_Robot_SoundBible_com_1721415199);
        int randValue = 0;
        int car = 75;
        int car2 = 75;
        int lives = 3;
        int playerSpeed = 5;
        List<Rectangle> cars2 = new List<Rectangle>();
        List<Rectangle> cars = new List<Rectangle>();
        List<int> carSpeed = new List<int>();
        List<int> carSpeed2 = new List<int>();
        Rectangle playerRec = new Rectangle(500, 500, 25, 50);
        Rectangle exit = new Rectangle(500, -40, 110, 125);
        Rectangle start = new Rectangle(500, 500, 110, 90);
        Random randGen = new Random();
        bool wDown = false;
        bool sDown = false;
        bool dDown = false;
        bool aDown = false;
        public level2()
        {
            InitializeComponent();
           
            InitalizeGame();
        }
        public void InitalizeGame()
        {
           
            gameticker.Enabled = true;
            AwaitMove();
        }
        private void level2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
            }
        }

        private void level2_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;



            }
        }

        private void level2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.playerIcon, playerRec);
            e.Graphics.DrawImage(Properties.Resources._379287dc2c9c2dc086e77e5fe1ac24a1_removebg_preview, exit);

            e.Graphics.DrawImage(Properties.Resources.R_removebg_preview, start);
            for (int i = 0; i < cars.Count(); i++)
            {

                e.Graphics.DrawImage(Properties.Resources.tiefighter__2_, cars[i]);

            }
            for (int i = 0; i < cars2.Count(); i++)
            {

                e.Graphics.DrawImage(Properties.Resources.tiefighter__2_, cars2[i]);

            }
        }

        

        private void gameticker_Tick_1(object sender, EventArgs e)
        { 
            nextLevelButton.Visible = false;
            if (wDown == true && playerRec.Y > 0)
            {
                playerRec.Y -= playerSpeed;
            }
            if (sDown == true && playerRec.Y < this.Height - playerRec.Height)
            {
                playerRec.Y += playerSpeed;
            }
            if (dDown == true && playerRec.X < 1150)
            {
                playerRec.X += playerSpeed;
            }
            if (aDown == true && playerRec.X > -125)
            { 
                playerRec.X -= playerSpeed;
            }
            if (wDown == true && playerRec.Y > 0)
            {
                playerRec.Y -= playerSpeed;
            }
            if (sDown == true && playerRec.Y < this.Height - playerRec.Height)
            {
                playerRec.Y += playerSpeed;
            }
            if (dDown == true && playerRec.X < 1150)
            {
                playerRec.X += playerSpeed;
            }
            randValue = randGen.Next(0, 250);
            if (randValue < 5)
            {


                cars.Add(new Rectangle(1200, 300, car, car));

                carSpeed.Add(randGen.Next(-10, -2));


            }
            for (int i = 0; i < cars.Count(); i++)
            {

                int x = cars[i].X + carSpeed[i];

              
                cars[i] = new Rectangle(x, cars[i].Y, car, car);
                if (cars[i].Y < 0)
                {
                    cars.RemoveAt(i);
                    carSpeed.RemoveAt(i);
                }
            }
            randValue = randGen.Next(0, 250);
            if (randValue < 5)
            {


                cars2.Add(new Rectangle(0, 85, car, car));
          
                carSpeed2.Add(randGen.Next(2, 10));


            }
            for (int i = 0; i < cars2.Count(); i++)
            {
        
                int x = cars2[i].X + carSpeed2[i];

                
                cars2[i] = new Rectangle(x, cars2[i].Y, car2, car2);
                if (cars2[i].Y < 0)
                {
                    cars2.RemoveAt(i);
                    carSpeed2.RemoveAt(i);
                }
            }
            for (int i = 0; i < cars.Count(); i++)
            {
                if (playerRec.IntersectsWith(cars[i]))
                {
                    death.Play();
                    cars.RemoveAt(i);
                    carSpeed.RemoveAt(i);
                    lives -= 1;
                    playerRec.X = 500;
                    playerRec.Y = 500;
                }
            }
            for (int i = 0; i < cars2.Count(); i++)
            {
                if (playerRec.IntersectsWith(cars2[i]))
                {
                    death.Play();
                    cars2.RemoveAt(i);
                    carSpeed2.RemoveAt(i);
                    lives -= 1;
                    playerRec.X = 500;
                    playerRec.Y = 500;
                }
            }
            
            if (lives < 1)
            {
                gameticker.Stop();
            }
            if (playerRec.IntersectsWith(exit))
            {
                nextLevelButton.Visible = true;
                gameticker.Stop();

            }
            Refresh();
        }

        private void nextLevelButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            level3 l3 = new level3();
            f.Controls.Add((l3));
        }
        private async void AwaitMove()
        {
            
            int speed = playerSpeed;
            playerSpeed = 0;
            await Task.Delay(3000);
            playerSpeed = speed;
        }
    }
}

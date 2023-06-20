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
    public partial class level3 : UserControl
    {
        SoundPlayer death = new SoundPlayer(Properties.Resources.Dying_Robot_SoundBible_com_1721415199);
        int randValue = 0;
        int car = 75;
        int car2 = 75;
        int car3 = 65;
        int lives = 3;
        int playerSpeed = 5;
        List<Rectangle> cars2 = new List<Rectangle>();
        List<Rectangle> cars = new List<Rectangle>();
        List<Rectangle> cars3= new List<Rectangle>();
        List<int> carSpeed = new List<int>();
        List<int> carSpeed2 = new List<int>();
        List<int> carSpeed3 = new List<int>();
        Rectangle playerRec = new Rectangle(500, 650, 25, 50);
        Rectangle exit = new Rectangle(500, -40, 110, 125);
        Rectangle start = new Rectangle(500, 500, 110, 90);
        Rectangle enter = new Rectangle(500, 650, 25, 50);
        Random randGen = new Random();
        bool wDown = false;
        bool sDown = false;
        bool dDown = false;
        bool aDown = false;
        public level3()
        {
            InitializeComponent();
            InitalizeGame();
        }
        public void InitalizeGame()
        {
           
            gameticktimertick.Enabled = true;
            AwaitMove();
        }
        private void level3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void level3_KeyUp(object sender, KeyEventArgs e)
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

        private void level3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.playerIcon, playerRec);
            e.Graphics.DrawImage(Properties.Resources._379287dc2c9c2dc086e77e5fe1ac24a1_removebg_preview, enter);
            e.Graphics.DrawImage(Properties.Resources.Web_capture_20_6_2023_9337_mail_google_com_removebg_preview, exit);


            for (int i = 0; i < cars.Count(); i++)
            {

                e.Graphics.DrawImage(Properties.Resources.tiefighter__2_, cars[i]);

            }
            for (int i = 0; i < cars2.Count(); i++)
            {

                e.Graphics.DrawImage(Properties.Resources.tiefighter__2_, cars2[i]);

            }
            for (int i =0; i< cars3.Count(); i++)
            {
                e.Graphics.DrawImage(Properties.Resources.tiefighter__2_, cars3[i]);
            }
        }

        private void gameticktimertick_Tick(object sender, EventArgs e)
        {

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


                cars.Add(new Rectangle(1200, 350, car, car));

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


                cars2.Add(new Rectangle(0, 125, car, car));

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
            randValue = randGen.Next(0, 250);
            if (randValue < 5)
            {


                cars3.Add(new Rectangle(0, 570, car, car));

                carSpeed3.Add(randGen.Next(2, 10));


            }
            for (int i = 0; i < cars3.Count(); i++)
            {
        
                int x = cars3[i].X + carSpeed3[i];

        
                cars3[i] = new Rectangle(x, cars3[i].Y, car3, car3);
                if (cars3[i].Y < 0)
                {
                    cars3.RemoveAt(i);
                    carSpeed3.RemoveAt(i);
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
                    playerRec.Y = 600;
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
                    playerRec.Y = 600;
                }
            }
            for (int i = 0; i < cars3.Count(); i++)
            {
                if (playerRec.IntersectsWith(cars3[i]))
                {
                    death.Play();
                    cars3.RemoveAt(i);
                    carSpeed3.RemoveAt(i);
                    lives -= 1;
                    playerRec.X = 500;
                    playerRec.Y = 600;
                }
            }


            if (lives < 1)
            {
                gameticktimertick.Stop();
            }
            if (playerRec.IntersectsWith(exit))
            {

                gameticktimertick.Stop();
                Form f = this.FindForm();
                f.Controls.Remove(this);
                gamewin gw= new gamewin();
                f.Controls.Add((gw));

            }
            Refresh();
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

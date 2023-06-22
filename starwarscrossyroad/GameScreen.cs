using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;
namespace starwarscrossyroad
{
    public partial class GameScreen : UserControl
    {
        int randValue = 0;
        int lives = 3;
        int car = 75;
        int playerSpeed = 5;
        SoundPlayer death = new SoundPlayer(Properties.Resources.Dying_Robot_SoundBible_com_1721415199);
        List<int> carSpeed = new List<int>();
        List<Rectangle> cars = new List<Rectangle>();

        Rectangle playerRec = new Rectangle(500, 500, 25, 50);
        Rectangle test = new Rectangle(500, 150, 110, 90);


        Random randGen = new Random();

        bool wDown = false;
        bool sDown = false;
        bool dDown = false;
        bool aDown = false;

        public GameScreen()
        {
            InitializeComponent();
            InitalizeGame();
        }

        public void InitalizeGame()
        {
            gameticktimer.Enabled = true;
            AwaitMove();
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
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

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.R_removebg_preview, test);
            e.Graphics.DrawImage(Properties.Resources.playerIcon, playerRec);

            for (int i = 0; i < cars.Count(); i++)
            {

                e.Graphics.DrawImage(Properties.Resources.tiefighter__2_, cars[i]);

            }
        }

        private void gameticktimer_Tick(object sender, EventArgs e)
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
            randValue = randGen.Next(0, 250);

            if (randValue < 5)
            {


                cars.Add(new Rectangle(1200, 325, car, car));
                carSpeed.Add(randGen.Next(-10, -2));


            }
            for (int i = 0; i < cars.Count(); i++)
            {
                //find the new postion of y based on speed
                int x = cars[i].X + carSpeed[i];

                //replace the rectangle in the list with updated one using new y
                cars[i] = new Rectangle(x, cars[i].Y, car, car);
                if (cars[i].X < 0)
                {
                    cars.RemoveAt(i);
                    carSpeed.RemoveAt(i);
                }
            }
            if (aDown == true && playerRec.X > -125)
            { playerRec.X -= playerSpeed; }

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
            if (lives < 1)
            {
                gameticktimer.Stop();
                Form f = this.FindForm();
                f.Controls.Remove(this);
                gameobver go = new gameobver();
                f.Controls.Add((go));
            }

            if (playerRec.IntersectsWith(test))
            {
              gameticktimer.Enabled = false;
                nextLevelButton.Visible = true;
            }
            Refresh();
        }




       

        private async void AwaitMove()
        {
            //makes the player wait so that the tie fighters can spawn in
            int speed = playerSpeed;
            playerSpeed = 0;
            await Task.Delay(3000);
            playerSpeed = speed;
        }

        private void nextLevelButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            level2 l2 = new level2();
            f.Controls.Add(l2);
           
        }
    }
}

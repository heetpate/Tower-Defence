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
using System.Threading;

namespace Tower_Defence
{
    public partial class Form1 : Form
    {

        Rectangle firstTurn = new Rectangle(675, 185, 30, 30);
        Rectangle secondTurn = new Rectangle(510, 170, 30, 30);
        Rectangle thirdTurn = new Rectangle(525, 85, 30, 30);
        Rectangle fourthTurn = new Rectangle(130, 100, 30, 30);
        Rectangle fifthTurn = new Rectangle(145, 265, 30, 30);
        Rectangle sixthTurn = new Rectangle(240, 250, 30, 30);
        Rectangle seventhTurn = new Rectangle(225, 165, 30, 30);
        Rectangle eighthTurn = new Rectangle(340, 180, 30, 30);
        Rectangle ninethTurn = new Rectangle(325, 310, 30, 30);
        Rectangle tenthTurn = new Rectangle(540, 295, 30, 30);
        Rectangle eleventhTurn = new Rectangle(525, 230, 30, 30);
        Rectangle twelvethTurn = new Rectangle(730, 245, 30, 30);
        Rectangle thirteenthTurn = new Rectangle(715, 395, 30, 30);
        Rectangle fourteenthTurn = new Rectangle(235, 380, 30, 30);
        Rectangle fifteenthTurn = new Rectangle(250, 305, 30, 30);
        Rectangle sixteenthTurn = new Rectangle(130, 320, 30, 30);
        Rectangle end = new Rectangle(100, 475, 100, 20);

        //string[] waves = new string[14];
        //string[1] = "Wave 1"

        List<Rectangle> smallRobots = new List<Rectangle>();
        List<String> sRD = new List<string>();

        int screen = 2;
        int time = 600;
        int loadingBar;

        int smallBots = 10;
        int smallBotSpeedX = 5;
        int smallBotSpeedY = 5;

        int medBots = 0;
        int largeBots = 0;

        int lives;
        int money;

        int counter = 0;

        int collisons = 0;
        bool firstBot = true;

        Pen blackPen = new Pen(Color.Black, 3);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush brownBrush = new SolidBrush(Color.Peru);
        SolidBrush blackBrush = new SolidBrush(Color.Black);

        Random randGen = new Random();

        int randValue = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void menuTimer_Tick(object sender, EventArgs e)
        {


            //Show Menu Screen

            //Check to see if easy button has been pressed

            //Check to see if medium button has been pressed

            //Check to see if hard button has been pressed

            //Check to see if insane button has been pressed

            //Check to see if exit button has been pressed

            Refresh();
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {


            //Check to see if user has grabbed tower

            //Check to see if any towers have been upgraded

            //Check to see if any towers have been sold

            //Check to see if it is time to shoot

            //Check to see if there is a bullet on the screen

            //Check to see if there are any bullets off the screen

            //Check to see if the robots have been shot

            //Check to see if the robots have been killed

            //Check to see if any robots made it to the end of the path

            //Are there any lives left

            //Check to see if the wave is completed

            //Check to see if all the waves have been completed

            Refresh();
        }
        public void towerGrabbed()
        {

        }
        public void towerUpgraded()
        {

        }
        public void towerSold()
        {

        }
        public void shootBullet()
        {

        }
        public void moveBullet()
        {

        }
        public void removeBullet()
        {

        }
        public void bulletHitRobot()
        {

        }
        public void robotKill()
        {

        }
        public void loseLives()
        {

        }
        public void outOfLives()
        {

        }
        public void waveCompleted()
        {

        }
        public void gameCompleted()
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            //Make animation
            if (screen == 0)
            {
                if (time > 0 && loadingBar < 300)
                {
                    this.BackColor = (Color.White);
                    e.Graphics.FillRectangle(redBrush, 200, 300, loadingBar, 50);
                    e.Graphics.DrawRectangle(blackPen, 200, 300, 375, 50);


                    loadingBar++;
                    time--;
                }
                else if (time > 0 && loadingBar < 303)
                {
                    this.BackColor = (Color.White);
                    e.Graphics.FillRectangle(redBrush, 200, 300, loadingBar, 50);
                    e.Graphics.DrawRectangle(blackPen, 200, 300, 375, 50);

                    randValue = randGen.Next(0, 101);

                    if (randValue > 95)
                    {
                        loadingBar++;
                    }
                    time--;
                }
                else if (time > 0 && loadingBar < 375)
                {
                    this.BackColor = (Color.White);
                    e.Graphics.FillRectangle(redBrush, 200, 300, loadingBar, 50);
                    e.Graphics.DrawRectangle(blackPen, 200, 300, 375, 50);


                    loadingBar = loadingBar + 10;
                    time--;
                }
                else
                {

                    Thread.Sleep(500);
                    e.Graphics.Clear(Color.White);
                    screen = 1;
                }
            }
            else if (screen == 1)
            {
                this.BackColor = Color.White;
                easyButton.Visible = true;
                mediumButton.Visible = true;
                hardButton.Visible = true;
                insaneButton.Visible = true;
                exitButton.Visible = true;
                titleLabel.Visible = true;
            }
            else if (screen == 2)
            {
                this.BackColor = Color.White;
                easyButton.Visible = false;
                mediumButton.Visible = false;
                hardButton.Visible = false;
                insaneButton.Visible = false;
                exitButton.Visible = false;
                titleLabel.Visible = false;
                livesLabel.Visible = true;
                moneyLabel.Visible = true;

                livesLabel.Text = $"Lives : {lives}";
                moneyLabel.Text = $"Money : {money}";

                //Draw Path
                e.Graphics.FillRectangle(brownBrush, 675, 0, 30, 170);
                e.Graphics.FillRectangle(brownBrush, 525, 170, 180, 30);
                e.Graphics.FillRectangle(brownBrush, 525, 100, 30, 70);
                e.Graphics.FillRectangle(brownBrush, 145, 100, 410, 30);
                e.Graphics.FillRectangle(brownBrush, 145, 100, 30, 180);
                e.Graphics.FillRectangle(brownBrush, 145, 250, 80, 30);
                e.Graphics.FillRectangle(brownBrush, 225, 180, 30, 100);
                e.Graphics.FillRectangle(brownBrush, 225, 180, 100, 30);
                e.Graphics.FillRectangle(brownBrush, 325, 180, 30, 145);
                e.Graphics.FillRectangle(brownBrush, 355, 295, 200, 30);
                e.Graphics.FillRectangle(brownBrush, 525, 245, 30, 50);
                e.Graphics.FillRectangle(brownBrush, 555, 245, 180, 30);
                e.Graphics.FillRectangle(brownBrush, 715, 245, 30, 135);
                e.Graphics.FillRectangle(brownBrush, 250, 380, 495, 30);
                e.Graphics.FillRectangle(brownBrush, 250, 320, 30, 60);
                e.Graphics.FillRectangle(brownBrush, 145, 320, 105, 30);
                e.Graphics.FillRectangle(brownBrush, 145, 320, 30, 155);

                for (int i = 0; i < smallRobots.Count(); i++)
                {
                    e.Graphics.FillRectangle(blackBrush, smallRobots[i]);
                }

                e.Graphics.DrawRectangle(blackPen, 0, 75, 100, 375);


            }
        }

        private void easyButton_MouseHover(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Lime;
        }

        private void easyButton_MouseLeave(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Black;
        }

        private void mediumButton_MouseHover(object sender, EventArgs e)
        {
            mediumButton.BackColor = Color.Yellow;
        }

        private void mediumButton_MouseLeave(object sender, EventArgs e)
        {
            mediumButton.BackColor = Color.Black;
        }

        private void hardButton_MouseHover(object sender, EventArgs e)
        {
            hardButton.BackColor = Color.Orange;
        }

        private void hardButton_MouseLeave(object sender, EventArgs e)
        {
            hardButton.BackColor = Color.Black;
        }

        private void insaneButton_MouseHover(object sender, EventArgs e)
        {
            insaneButton.BackColor = Color.Red;
        }

        private void insaneButton_MouseLeave(object sender, EventArgs e)
        {
            insaneButton.BackColor = Color.Black;
        }

        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.Red;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.Black;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            lives = 200;
            money = 1200;
            screen = 2;

            gameTimer.Enabled = true;
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            lives = 150;
            money = 1000;
            screen = 2;

            gameTimer.Enabled = true;
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            lives = 100;
            money = 800;
            screen = 2;

            gameTimer.Enabled = true;
        }

        private void insaneButton_Click(object sender, EventArgs e)
        {
            lives = 1;
            money = 600;
            screen = 2;

            gameTimer.Enabled = true;
        }

        private void robotTimer_Tick(object sender, EventArgs e)
        {
            //Move Robots
            for (int i = 0; i < smallRobots.Count(); i++)
            {
                if (firstBot == true)
                {
                    int y = smallRobots[i].Y + smallBotSpeedY;
                    int x = smallRobots[i].X;
                    smallRobots[i] = new Rectangle(x, y, 10, 10);
                    firstBot = false;
                }

                switch (collisons)
                {
                    case 0:
                        sRD.Add("down");
                        break;

                }
                if (firstBot == false)
                {
                    if (sRD[i] == "down")
                    {
                        int x = smallRobots[i].X;
                        int y = smallRobots[i].Y + smallBotSpeedY;
                        smallRobots[i] = new Rectangle(x, y, 10, 10); 
                    }
                    if (sRD[i] == "left")
                    {
                        int y = smallRobots[i].Y;
                        int x = smallRobots[i].X - smallBotSpeedX;
                        smallRobots[i] = new Rectangle(x, y, 10, 10);
                    }
                    if (sRD[i] == "up")
                    {
                        int x = smallRobots[i].X;
                        int y = smallRobots[i].Y - smallBotSpeedY;
                        smallRobots[i] = new Rectangle(x, y, 10, 10);
                    }
                    if (sRD[i] == "right")
                    {
                        int x = smallRobots[i].X + smallBotSpeedX;
                        int y = smallRobots[i].Y;
                        smallRobots[i] = new Rectangle(x, y, 10, 10);
                    }


                    if (smallRobots[i].IntersectsWith(firstTurn))
                    {
                        sRD[i] = "left";
                    }
                    if (smallRobots[i].IntersectsWith(secondTurn))
                    {
                        sRD[i] = "up";
                    }
                    if (smallRobots[i].IntersectsWith(thirdTurn))
                    {
                        sRD[i] = "left";
                    }
                    if (smallRobots[i].IntersectsWith(fourthTurn))
                    {
                        sRD[i] = "down";
                    }
                    if (smallRobots[i].IntersectsWith(fifthTurn))
                    {
                        sRD[i] = "right";
                    }
                    if (smallRobots[i].IntersectsWith(sixthTurn))
                    {
                        sRD[i] = "up";
                    }
                    if (smallRobots[i].IntersectsWith(seventhTurn))
                    {
                        sRD[i] = "right";
                    }
                    if (smallRobots[i].IntersectsWith(eighthTurn))
                    {
                        sRD[i] = "down";
                    }
                    if (smallRobots[i].IntersectsWith(ninethTurn))
                    {
                        sRD[i] = "right";
                    }
                    if (smallRobots[i].IntersectsWith(tenthTurn))
                    {
                        sRD[i] = "up";
                    }
                    if (smallRobots[i].IntersectsWith(eleventhTurn))
                    {
                        sRD[i] = "right";
                    }
                    if (smallRobots[i].IntersectsWith(twelvethTurn))
                    {
                        sRD[i] = "down";
                    }
                    if (smallRobots[i].IntersectsWith(thirteenthTurn))
                    {
                        sRD[i] = "left";
                    }
                    if (smallRobots[i].IntersectsWith(fourteenthTurn))
                    {
                        sRD[i] = "up";
                    }
                    if (smallRobots[i].IntersectsWith(fifteenthTurn))
                    {
                        sRD[i] = "left";
                    }
                    if (smallRobots[i].IntersectsWith(sixteenthTurn))
                    {
                        sRD[i] = "down";
                    }
                    if (smallRobots[i].IntersectsWith(end))
                    {
                        smallRobots.RemoveAt(i);
                        sRD.RemoveAt(i);
                    }

                }
                Refresh();
            }
            //Create Robots

            if (smallBots > 0 && counter > 4)
            {
                Rectangle smallB = new Rectangle(685, 0, 10, 10);
                smallRobots.Add(smallB);
                smallBots--;
                counter = 0;
            }

            counter++;
        }
    }

}

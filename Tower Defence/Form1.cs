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

        List<Rectangle> miniRobots = new List<Rectangle>();
        List<Rectangle> sniperRobots = new List<Rectangle>();
        List<Rectangle> finalSniperRobots = new List<Rectangle>();
        List<Rectangle> bigMeleeRobots = new List<Rectangle>();

        List<String> mRD = new List<string>();
        List<String> sRD = new List<string>();
        List<String> fSRD = new List<string>();
        List<String> bMRD = new List<string>();


        int screen = 2;
        int time = 600;
        int loadingBar;

        int miniBots = 10;
        int miniBotspeedX = 8;
        int miniBotspeedY = 8;

        int sniperBots = 10;
        int sniperBotspeedX = 6;
        int sniperBotspeedY = 6;

        int finalSniperBots = 10;
        int finalSniperBotspeedX = 5;
        int finalSniperBotspeedY = 5;

        int bigMeleeBots = 10;
        int bigMeleeBotspeedX = 5;
        int bigMeleeBotspeedY = 5;

        int lives;
        int money;

        int counter = 0;


        Pen blackPen = new Pen(Color.Black, 3);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush brownBrush = new SolidBrush(Color.Peru);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush purpleBrush = new SolidBrush(Color.Purple);
        SolidBrush greenBrush = new SolidBrush(Color.Green);

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

                for (int i = 0; i < miniRobots.Count(); i++)
                {
                    e.Graphics.FillRectangle(blackBrush, miniRobots[i]);
                }
                for (int i = 0; i < sniperRobots.Count(); i++)
                {
                    e.Graphics.FillRectangle(blueBrush, sniperRobots[i]);
                }
                for (int i = 0; i < finalSniperRobots.Count(); i++)
                {
                    e.Graphics.FillRectangle(greenBrush, finalSniperRobots[i]);
                }
                for (int i = 0; i < bigMeleeRobots.Count(); i++)
                {
                    e.Graphics.FillRectangle(purpleBrush, bigMeleeRobots[i]);
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
            if (screen == 2)
            {
                //Move Mini Robots
                for (int i = 0; i < miniRobots.Count(); i++)
                {
                        if (mRD[i] == "down")
                        {
                            int x = miniRobots[i].X;
                            int y = miniRobots[i].Y + miniBotspeedY;
                            miniRobots[i] = new Rectangle(x, y, 10, 10);
                        }
                        if (mRD[i] == "left")
                        {
                            int y = miniRobots[i].Y;
                            int x = miniRobots[i].X - miniBotspeedX;
                            miniRobots[i] = new Rectangle(x, y, 10, 10);
                        }
                        if (mRD[i] == "up")
                        {
                            int x = miniRobots[i].X;
                            int y = miniRobots[i].Y - miniBotspeedY;
                            miniRobots[i] = new Rectangle(x, y, 10, 10);
                        }
                        if (mRD[i] == "right")
                        {
                            int x = miniRobots[i].X + miniBotspeedX;
                            int y = miniRobots[i].Y;
                            miniRobots[i] = new Rectangle(x, y, 10, 10);
                        }


                        if (miniRobots[i].IntersectsWith(firstTurn))
                        {
                            mRD[i] = "left";
                        }
                        if (miniRobots[i].IntersectsWith(secondTurn))
                        {
                            mRD[i] = "up";
                        }
                        if (miniRobots[i].IntersectsWith(thirdTurn))
                        {
                            mRD[i] = "left";
                        }
                        if (miniRobots[i].IntersectsWith(fourthTurn))
                        {
                            mRD[i] = "down";
                        }
                        if (miniRobots[i].IntersectsWith(fifthTurn))
                        {
                            mRD[i] = "right";
                        }
                        if (miniRobots[i].IntersectsWith(sixthTurn))
                        {
                            mRD[i] = "up";
                        }
                        if (miniRobots[i].IntersectsWith(seventhTurn))
                        {
                            mRD[i] = "right";
                        }
                        if (miniRobots[i].IntersectsWith(eighthTurn))
                        {
                            mRD[i] = "down";
                        }
                        if (miniRobots[i].IntersectsWith(ninethTurn))
                        {
                            mRD[i] = "right";
                        }
                        if (miniRobots[i].IntersectsWith(tenthTurn))
                        {
                            mRD[i] = "up";
                        }
                        if (miniRobots[i].IntersectsWith(eleventhTurn))
                        {
                            mRD[i] = "right";
                        }
                        if (miniRobots[i].IntersectsWith(twelvethTurn))
                        {
                            mRD[i] = "down";
                        }
                        if (miniRobots[i].IntersectsWith(thirteenthTurn))
                        {
                            mRD[i] = "left";
                        }
                        if (miniRobots[i].IntersectsWith(fourteenthTurn))
                        {
                            mRD[i] = "up";
                        }
                        if (miniRobots[i].IntersectsWith(fifteenthTurn))
                        {
                            mRD[i] = "left";
                        }
                        if (miniRobots[i].IntersectsWith(sixteenthTurn))
                        {
                            mRD[i] = "down";
                        }
                        if (miniRobots[i].IntersectsWith(end))
                        {
                            lives = lives - 2;
                            livesLabel.Text = $"{lives}";
                            miniRobots.RemoveAt(i);
                            mRD.RemoveAt(i);
                        }
                }
                //Move sniper Robots
                for (int i = 0; i < sniperRobots.Count(); i++)
                { 
                    if (sRD[i] == "down")
                    {
                        int x = sniperRobots[i].X;
                        int y = sniperRobots[i].Y + sniperBotspeedY;
                        sniperRobots[i] = new Rectangle(x, y, 10, 10);
                    }
                    if (sRD[i] == "left")
                    {
                        int y = sniperRobots[i].Y;
                        int x = sniperRobots[i].X - sniperBotspeedX;
                        sniperRobots[i] = new Rectangle(x, y, 10, 10);
                    }
                    if (sRD[i] == "up")
                    {
                        int x = sniperRobots[i].X;
                        int y = sniperRobots[i].Y - sniperBotspeedY;
                        sniperRobots[i] = new Rectangle(x, y, 10, 10);
                    }
                    if (sRD[i] == "right")
                    {
                        int x = sniperRobots[i].X + sniperBotspeedX;
                        int y = sniperRobots[i].Y;
                        sniperRobots[i] = new Rectangle(x, y, 10, 10);
                    }


                    if (sniperRobots[i].IntersectsWith(firstTurn))
                    {
                        sRD[i] = "left";
                    }
                    if (sniperRobots[i].IntersectsWith(secondTurn))
                    {
                        sRD[i] = "up";
                    }
                    if (sniperRobots[i].IntersectsWith(thirdTurn))
                    {
                        sRD[i] = "left";
                    }
                    if (sniperRobots[i].IntersectsWith(fourthTurn))
                    {
                        sRD[i] = "down";
                    }
                    if (sniperRobots[i].IntersectsWith(fifthTurn))
                    {
                        sRD[i] = "right";
                    }
                    if (sniperRobots[i].IntersectsWith(sixthTurn))
                    {
                        sRD[i] = "up";
                    }
                    if (sniperRobots[i].IntersectsWith(seventhTurn))
                    {
                        sRD[i] = "right";
                    }
                    if (sniperRobots[i].IntersectsWith(eighthTurn))
                    {
                        sRD[i] = "down";
                    }
                    if (sniperRobots[i].IntersectsWith(ninethTurn))
                    {
                        sRD[i] = "right";
                    }
                    if (sniperRobots[i].IntersectsWith(tenthTurn))
                    {
                        sRD[i] = "up";
                    }
                    if (sniperRobots[i].IntersectsWith(eleventhTurn))
                    {
                        sRD[i] = "right";
                    }
                    if (sniperRobots[i].IntersectsWith(twelvethTurn))
                    {
                        sRD[i] = "down";
                    }
                    if (sniperRobots[i].IntersectsWith(thirteenthTurn))
                    {
                        sRD[i] = "left";
                    }
                    if (sniperRobots[i].IntersectsWith(fourteenthTurn))
                    {
                        sRD[i] = "up";
                    }
                    if (sniperRobots[i].IntersectsWith(fifteenthTurn))
                    {
                        sRD[i] = "left";
                    }
                    if (sniperRobots[i].IntersectsWith(sixteenthTurn))
                    {
                        sRD[i] = "down";
                    }
                    if (sniperRobots[i].IntersectsWith(end))
                    {
                        lives = lives - 3;
                        livesLabel.Text = $"{lives}";
                        sniperRobots.RemoveAt(i);
                        sRD.RemoveAt(i);
                    }

                }
                //Move Final Sniper Robots
                for (int i = 0; i < finalSniperRobots.Count(); i++)
                {

                    if (fSRD[i] == "down")
                    {
                        int x = finalSniperRobots[i].X;
                        int y = finalSniperRobots[i].Y + finalSniperBotspeedY;
                        finalSniperRobots[i] = new Rectangle(x, y, 10, 10);
                    }
                    if (fSRD[i] == "left")
                    {
                        int y = finalSniperRobots[i].Y;
                        int x = finalSniperRobots[i].X - finalSniperBotspeedX;
                        finalSniperRobots[i] = new Rectangle(x, y, 10, 10);
                    }
                    if (fSRD[i] == "up")
                    {
                        int x = finalSniperRobots[i].X;
                        int y = finalSniperRobots[i].Y - finalSniperBotspeedY;
                        finalSniperRobots[i] = new Rectangle(x, y, 10, 10);
                    }
                    if (fSRD[i] == "right")
                    {
                        int x = finalSniperRobots[i].X + finalSniperBotspeedX;
                        int y = finalSniperRobots[i].Y;
                        finalSniperRobots[i] = new Rectangle(x, y, 10, 10);
                    }


                    if (finalSniperRobots[i].IntersectsWith(firstTurn))
                    {
                        fSRD[i] = "left";
                    }
                    if (finalSniperRobots[i].IntersectsWith(secondTurn))
                    {
                        fSRD[i] = "up";
                    }
                    if (finalSniperRobots[i].IntersectsWith(thirdTurn))
                    {
                        fSRD[i] = "left";
                    }
                    if (finalSniperRobots[i].IntersectsWith(fourthTurn))
                    {
                        fSRD[i] = "down";
                    }
                    if (finalSniperRobots[i].IntersectsWith(fifthTurn))
                    {
                        fSRD[i] = "right";
                    }
                    if (finalSniperRobots[i].IntersectsWith(sixthTurn))
                    {
                        fSRD[i] = "up";
                    }
                    if (finalSniperRobots[i].IntersectsWith(seventhTurn))
                    {
                        fSRD[i] = "right";
                    }
                    if (finalSniperRobots[i].IntersectsWith(eighthTurn))
                    {
                        fSRD[i] = "down";
                    }
                    if (finalSniperRobots[i].IntersectsWith(ninethTurn))
                    {
                        fSRD[i] = "right";
                    }
                    if (finalSniperRobots[i].IntersectsWith(tenthTurn))
                    {
                        fSRD[i] = "up";
                    }
                    if (finalSniperRobots[i].IntersectsWith(eleventhTurn))
                    {
                        fSRD[i] = "right";
                    }
                    if (finalSniperRobots[i].IntersectsWith(twelvethTurn))
                    {
                        fSRD[i] = "down";
                    }
                    if (finalSniperRobots[i].IntersectsWith(thirteenthTurn))
                    {
                        fSRD[i] = "left";
                    }
                    if (finalSniperRobots[i].IntersectsWith(fourteenthTurn))
                    {
                        fSRD[i] = "up";
                    }
                    if (finalSniperRobots[i].IntersectsWith(fifteenthTurn))
                    {
                        fSRD[i] = "left";
                    }
                    if (finalSniperRobots[i].IntersectsWith(sixteenthTurn))
                    {
                        fSRD[i] = "down";
                    }
                    if (finalSniperRobots[i].IntersectsWith(end))
                    {
                        lives = lives - 5;
                        livesLabel.Text = $"{lives}";
                        finalSniperRobots.RemoveAt(i);
                        fSRD.RemoveAt(i);
                    }

                }
                //Move big Melee Robots
                for (int i = 0; i < bigMeleeRobots.Count(); i++)
                {
                    if (bMRD[i] == "down")
                    {
                        int x = bigMeleeRobots[i].X;
                        int y = bigMeleeRobots[i].Y + bigMeleeBotspeedY;
                        bigMeleeRobots[i] = new Rectangle(x, y, 10, 10);
                    }
                    if (bMRD[i] == "left")
                    {
                        int y = bigMeleeRobots[i].Y;
                        int x = bigMeleeRobots[i].X - bigMeleeBotspeedX;
                        bigMeleeRobots[i] = new Rectangle(x, y, 10, 10);
                    }
                    if (bMRD[i] == "up")
                    {
                        int x = bigMeleeRobots[i].X;
                        int y = bigMeleeRobots[i].Y - bigMeleeBotspeedY;
                        bigMeleeRobots[i] = new Rectangle(x, y, 10, 10);
                    }
                    if (bMRD[i] == "right")
                    {
                        int x = bigMeleeRobots[i].X + bigMeleeBotspeedX;
                        int y = bigMeleeRobots[i].Y;
                        bigMeleeRobots[i] = new Rectangle(x, y, 10, 10);
                    }


                    if (bigMeleeRobots[i].IntersectsWith(firstTurn))
                    {
                        bMRD[i] = "left";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(secondTurn))
                    {
                        bMRD[i] = "up";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(thirdTurn))
                    {
                        bMRD[i] = "left";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(fourthTurn))
                    {
                        bMRD[i] = "down";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(fifthTurn))
                    {
                        bMRD[i] = "right";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(sixthTurn))
                    {
                        bMRD[i] = "up";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(seventhTurn))
                    {
                        bMRD[i] = "right";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(eighthTurn))
                    {
                        bMRD[i] = "down";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(ninethTurn))
                    {
                        bMRD[i] = "right";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(tenthTurn))
                    {
                        bMRD[i] = "up";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(eleventhTurn))
                    {
                        bMRD[i] = "right";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(twelvethTurn))
                    {
                        bMRD[i] = "down";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(thirteenthTurn))
                    {
                        bMRD[i] = "left";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(fourteenthTurn))
                    {
                        bMRD[i] = "up";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(fifteenthTurn))
                    {
                        bMRD[i] = "left";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(sixteenthTurn))
                    {
                        bMRD[i] = "down";
                    }
                    if (bigMeleeRobots[i].IntersectsWith(end))
                    {
                        lives = lives - 8;
                        livesLabel.Text = $"{lives}";
                        bigMeleeRobots.RemoveAt(i);
                        bMRD.RemoveAt(i);
                    }
                }
                //Create Robots

                if (miniBots > 0 && counter > 4)
                {
                    Rectangle miniB = new Rectangle(685, 0, 10, 10);
                    miniRobots.Add(miniB);
                    mRD.Add("down");
                    miniBots--;
                    counter = 0;
                }
                if (sniperBots > 0 && miniBots == 0 && counter > 6)
                {
                    Rectangle sniperB = new Rectangle(685, 0, 10, 10);
                    sniperRobots.Add(sniperB);
                    sRD.Add("down");
                    sniperBots--;
                    counter = 0;
                }
                if (finalSniperBots > 0 && miniBots == 0 && sniperBots == 0 && counter > 9)
                {
                    Rectangle finalSniperB = new Rectangle(685, 0, 10, 10);
                    finalSniperRobots.Add(finalSniperB);
                    fSRD.Add("down");
                    finalSniperBots--;
                    counter = 0;
                }
                if (bigMeleeBots > 0 && finalSniperBots == 0 && miniBots == 0 && sniperBots == 0 && counter > 10)
                {
                    Rectangle bigMeleeB = new Rectangle(685, 0, 10, 10);
                    bigMeleeRobots.Add(bigMeleeB);
                    bMRD.Add("down");
                    bigMeleeBots--;
                    counter = 0;
                }
                counter++;
                Refresh();
            }
        }

    }

}

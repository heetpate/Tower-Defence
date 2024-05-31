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
        int screen = 0;
        int time = 600;
        int loadingBar;

        int lives;
        int money;

        Pen blackPen = new Pen(Color.Black, 3);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush lightGrayBrush = new SolidBrush(Color.LightGray);

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
                e.Graphics.FillRectangle(lightGrayBrush, 675, 80, 40, 90);
                livesLabel.Visible = true;
                moneyLabel.Visible = true;

                livesLabel.Text = $"Lives : {lives}";
                moneyLabel.Text = $"Money : {money}";

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
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            lives = 150;
            money = 1000;
            screen = 2;
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            lives = 100;
            money = 800;
            screen = 2;
        }

        private void insaneButton_Click(object sender, EventArgs e)
        {
            lives = 1;
            money = 600;
            screen = 2;
        }

        
    }
}

namespace Tower_Defence
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.insaneButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.moneyLabel = new System.Windows.Forms.Label();
            this.livesLabel = new System.Windows.Forms.Label();
            this.robotTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(0, 275);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(800, 60);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Star Brawl TD";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Visible = false;
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.Black;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.ForeColor = System.Drawing.Color.White;
            this.easyButton.Location = new System.Drawing.Point(12, 360);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(175, 50);
            this.easyButton.TabIndex = 1;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Visible = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            this.easyButton.MouseLeave += new System.EventHandler(this.easyButton_MouseLeave);
            this.easyButton.MouseHover += new System.EventHandler(this.easyButton_MouseHover);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.Color.Black;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mediumButton.Location = new System.Drawing.Point(211, 360);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(175, 50);
            this.mediumButton.TabIndex = 2;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Visible = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            this.mediumButton.MouseLeave += new System.EventHandler(this.mediumButton_MouseLeave);
            this.mediumButton.MouseHover += new System.EventHandler(this.mediumButton_MouseHover);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.Color.Black;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.ForeColor = System.Drawing.Color.White;
            this.hardButton.Location = new System.Drawing.Point(413, 360);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(175, 50);
            this.hardButton.TabIndex = 3;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Visible = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            this.hardButton.MouseLeave += new System.EventHandler(this.hardButton_MouseLeave);
            this.hardButton.MouseHover += new System.EventHandler(this.hardButton_MouseHover);
            // 
            // insaneButton
            // 
            this.insaneButton.BackColor = System.Drawing.Color.Black;
            this.insaneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insaneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insaneButton.ForeColor = System.Drawing.Color.White;
            this.insaneButton.Location = new System.Drawing.Point(613, 360);
            this.insaneButton.Name = "insaneButton";
            this.insaneButton.Size = new System.Drawing.Size(175, 50);
            this.insaneButton.TabIndex = 4;
            this.insaneButton.Text = "Insane";
            this.insaneButton.UseVisualStyleBackColor = false;
            this.insaneButton.Visible = false;
            this.insaneButton.Click += new System.EventHandler(this.insaneButton_Click);
            this.insaneButton.MouseLeave += new System.EventHandler(this.insaneButton_MouseLeave);
            this.insaneButton.MouseHover += new System.EventHandler(this.insaneButton_MouseHover);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(691, 10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 42);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            this.exitButton.MouseHover += new System.EventHandler(this.exitButton_MouseHover);
            // 
            // menuTimer
            // 
            this.menuTimer.Enabled = true;
            this.menuTimer.Interval = 10;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // moneyLabel
            // 
            this.moneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.ForeColor = System.Drawing.Color.Black;
            this.moneyLabel.Location = new System.Drawing.Point(172, 5);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(304, 47);
            this.moneyLabel.TabIndex = 6;
            this.moneyLabel.Text = "Money : ";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moneyLabel.Visible = false;
            // 
            // livesLabel
            // 
            this.livesLabel.BackColor = System.Drawing.Color.Transparent;
            this.livesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.ForeColor = System.Drawing.Color.Black;
            this.livesLabel.Location = new System.Drawing.Point(7, 5);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(165, 47);
            this.livesLabel.TabIndex = 7;
            this.livesLabel.Text = "Lives : ";
            this.livesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.livesLabel.Visible = false;
            // 
            // robotTimer
            // 
            this.robotTimer.Enabled = true;
            this.robotTimer.Interval = 400;
            this.robotTimer.Tick += new System.EventHandler(this.robotTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.insaneButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Tower Defence";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button insaneButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Timer robotTimer;
    }
}


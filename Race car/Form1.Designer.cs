namespace Race_car
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
            this.playerCar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enemyCar = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.startbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.You = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.finishLine = new System.Windows.Forms.Label();
            this.enemy = new System.Windows.Forms.Label();
            this.playerScoreL = new System.Windows.Forms.Label();
            this.enemyScoreL = new System.Windows.Forms.Label();
            this.winL = new System.Windows.Forms.Label();
            this.gameoverL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerCar
            // 
            this.playerCar.AutoSize = true;
            this.playerCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCar.ForeColor = System.Drawing.Color.Salmon;
            this.playerCar.Location = new System.Drawing.Point(781, 87);
            this.playerCar.Name = "playerCar";
            this.playerCar.Size = new System.Drawing.Size(103, 73);
            this.playerCar.TabIndex = 0;
            this.playerCar.Text = "🏎";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enemyCar
            // 
            this.enemyCar.AutoSize = true;
            this.enemyCar.BackColor = System.Drawing.Color.Transparent;
            this.enemyCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyCar.ForeColor = System.Drawing.Color.MediumPurple;
            this.enemyCar.Location = new System.Drawing.Point(781, 209);
            this.enemyCar.Name = "enemyCar";
            this.enemyCar.Size = new System.Drawing.Size(103, 73);
            this.enemyCar.TabIndex = 1;
            this.enemyCar.Text = "🏎";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedLabel.ForeColor = System.Drawing.Color.White;
            this.SpeedLabel.Location = new System.Drawing.Point(708, 327);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(39, 42);
            this.SpeedLabel.TabIndex = 2;
            this.SpeedLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pick";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // startbutton
            // 
            this.startbutton.Enabled = false;
            this.startbutton.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(409, 355);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(122, 40);
            this.startbutton.TabIndex = 4;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(771, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Km/h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-90, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1020, 73);
            this.label4.TabIndex = 6;
            this.label4.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - ";
            // 
            // You
            // 
            this.You.AutoSize = true;
            this.You.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.You.ForeColor = System.Drawing.Color.Crimson;
            this.You.Location = new System.Drawing.Point(791, 87);
            this.You.Name = "You";
            this.You.Size = new System.Drawing.Size(33, 13);
            this.You.TabIndex = 7;
            this.You.Text = "You ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, -78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 731);
            this.label5.TabIndex = 8;
            this.label5.Text = "■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■";
            // 
            // finishLine
            // 
            this.finishLine.AutoSize = true;
            this.finishLine.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishLine.ForeColor = System.Drawing.Color.White;
            this.finishLine.Location = new System.Drawing.Point(-12, -185);
            this.finishLine.Name = "finishLine";
            this.finishLine.Size = new System.Drawing.Size(41, 731);
            this.finishLine.TabIndex = 9;
            this.finishLine.Text = "■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■\r\n■";
            this.finishLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // enemy
            // 
            this.enemy.AutoSize = true;
            this.enemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemy.ForeColor = System.Drawing.Color.RoyalBlue;
            this.enemy.Location = new System.Drawing.Point(791, 220);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(44, 13);
            this.enemy.TabIndex = 10;
            this.enemy.Text = "Enemy";
            // 
            // playerScoreL
            // 
            this.playerScoreL.AutoSize = true;
            this.playerScoreL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreL.ForeColor = System.Drawing.Color.Crimson;
            this.playerScoreL.Location = new System.Drawing.Point(409, 9);
            this.playerScoreL.Name = "playerScoreL";
            this.playerScoreL.Size = new System.Drawing.Size(21, 24);
            this.playerScoreL.TabIndex = 12;
            this.playerScoreL.Text = "0";
            // 
            // enemyScoreL
            // 
            this.enemyScoreL.AutoSize = true;
            this.enemyScoreL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyScoreL.ForeColor = System.Drawing.Color.RoyalBlue;
            this.enemyScoreL.Location = new System.Drawing.Point(469, 9);
            this.enemyScoreL.Name = "enemyScoreL";
            this.enemyScoreL.Size = new System.Drawing.Size(21, 24);
            this.enemyScoreL.TabIndex = 14;
            this.enemyScoreL.Text = "0";
            // 
            // winL
            // 
            this.winL.AutoSize = true;
            this.winL.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winL.ForeColor = System.Drawing.Color.LimeGreen;
            this.winL.Location = new System.Drawing.Point(341, 172);
            this.winL.Name = "winL";
            this.winL.Size = new System.Drawing.Size(274, 73);
            this.winL.TabIndex = 15;
            this.winL.Text = "You Win";
            this.winL.Visible = false;
            // 
            // gameoverL
            // 
            this.gameoverL.AutoSize = true;
            this.gameoverL.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverL.ForeColor = System.Drawing.Color.Brown;
            this.gameoverL.Location = new System.Drawing.Point(285, 172);
            this.gameoverL.Name = "gameoverL";
            this.gameoverL.Size = new System.Drawing.Size(363, 73);
            this.gameoverL.TabIndex = 16;
            this.gameoverL.Text = "Game Over";
            this.gameoverL.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(785, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "Made By SELAM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(887, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameoverL);
            this.Controls.Add(this.winL);
            this.Controls.Add(this.enemyScoreL);
            this.Controls.Add(this.playerScoreL);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.finishLine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.You);
            this.Controls.Add(this.enemyCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.playerCar);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label playerCar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label enemyCar;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label You;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label finishLine;
        private System.Windows.Forms.Label enemy;
        private System.Windows.Forms.Label playerScoreL;
        private System.Windows.Forms.Label enemyScore;
        private System.Windows.Forms.Label enemyScoreL;
        private System.Windows.Forms.Label winL;
        private System.Windows.Forms.Label gameoverL;
        private System.Windows.Forms.Label label1;
    }
}


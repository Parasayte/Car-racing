using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_car
{
    public partial class Form1 : Form
    {
        int time;
        int enemyCarSpeed;
        int PlayerCarSpeed;
        int yourScore, enemyscore;
        bool playerwin;
        Random random;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (enemyCarSpeed == PlayerCarSpeed)
            {
                PlayerCarSpeed--;
            }
            time++;
            enemy.Left-= enemyCarSpeed * time / 20;
            You.Left -= PlayerCarSpeed * time / 20;
            playerCar.Left-=PlayerCarSpeed*time/20;
            enemyCar.Left-=enemyCarSpeed * time / 20;
            if (enemyCar.Bounds.IntersectsWith(finishLine.Bounds))
            {
               
                playerwin=false;
                enemyscore++;
                enemyScoreL.Text=enemyscore.ToString();     
                finishgame();
            }
            else if (playerCar.Bounds.IntersectsWith(finishLine.Bounds))
            {
             
                playerwin = true;
                yourScore++;
                playerScoreL.Text = yourScore.ToString();
               finishgame();

            }
            
        }
   
        private void Wining()
        {
            if (yourScore == 5)
            {
                winL.Visible = true;
           //     MessageBox.Show("WINNER", "CONGRAT", MessageBoxButtons.OK,MessageBoxIcon.Information);
              
                yourScore = 0;
                enemyscore = 0;
                playerScoreL.Text = yourScore.ToString();
                enemyScoreL.Text = enemyscore.ToString();
            }
           else if (enemyscore == 5)
            {
                gameoverL.Visible = true;
                yourScore = 0;
                enemyscore = 0;
                playerScoreL.Text = yourScore.ToString();
                enemyScoreL.Text = enemyscore.ToString();
            }
           
            playerScoreL.Text=yourScore.ToString();
            enemyScoreL.Text=enemyscore.ToString();
            button1.Enabled = false;
            timer2.Start();
            time = 0;
            You.Location = new Point(791, 87);
            enemy.Location = new Point(791, 220);
            playerCar.Location = new Point(781, 87);
            enemyCar.Location = new Point(781, 209);
            restatrGame();
        }
        private void finishgame()
        { 
            timer1.Stop();
 
       
            button1.Enabled = false;    
            timer2.Start();
            time = 0;
            You.Location = new Point(791, 87);
            enemy.Location=new Point(791, 220);
            playerCar.Location = new Point(781, 87);
            enemyCar.Location = new Point(781, 209);
            restatrGame();
            Wining();
        }
        private void restatrGame()
        {
            startbutton.Enabled = false;
            button1.Enabled = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            winL.Visible = false;
            gameoverL.Visible = false;
          
            enemyCarSpeed = random.Next(3, 20);
            enemy.Text = $"Enemy {enemyCarSpeed} Km/h";
            PlayerCarSpeed =int.Parse(SpeedLabel.Text);
            SpeedLabel.Text =PlayerCarSpeed.ToString();
            You.Text = $"You {PlayerCarSpeed} Km/h";
            enemy.Text = $"Enemy {enemyCarSpeed} Km/h";
            timer2.Stop();
            startbutton.Enabled=true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            random = new Random();
            SpeedLabel.Text = random.Next(6, 20).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer1.Stop();
        }

      
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           timer1.Start();
        }

      
    }
}

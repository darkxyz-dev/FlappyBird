using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipespeed = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipetop.Left -= pipespeed;
            pipebot.Left -= pipespeed;
            scoreLable.Text = $"score: {score}";

            if(pipetop.Left < - 100)
            {
                pipetop.Left = 500;
                score++;
            }
            
            if(pipebot.Left < -100)
            {
                pipebot.Left = 600;
                score++;
            }

            if(bird.Top < -25)
            {
                gameOver();
            }

            if(bird.Bounds.IntersectsWith(pipetop.Bounds) || bird.Bounds.IntersectsWith(pipebot.Bounds) || bird.Bounds.IntersectsWith(grounds.Bounds))
            {
                gameOver();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void bird_Click(object sender, EventArgs e)
        {

        }

        private void gameOver()
        {
            timer.Stop();
            scoreLable.Text = $"score: {score}";
            replay.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void replay_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Dispose(false);
        }
    }
}

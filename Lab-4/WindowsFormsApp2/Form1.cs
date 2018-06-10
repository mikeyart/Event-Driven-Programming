using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int speed_slider = 2;
        public int speed_ball2l = 5;
        public int speed_ball2t = 5;
        public int speed_ball3l = -6;
        public int speed_ball3t = 6;
        public int speed_ball4l = -7;
        public int speed_ball4t = 7;

        public int balls = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer3.Enabled = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            slider.Top = panel1.Bottom - (panel1.Bottom / 10);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            ball.Left += speed_left;
            ball.Top += speed_top;
            if (ball.Bottom > slider.Top && ball.Bottom < slider.Bottom && ball.Left > slider.Left && ball.Right < slider.Right)
            {
                speed_left += 1;
                speed_top = -speed_top;
                Random r = new Random();
                panel1.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
                Random r2 = new Random();
                slider.BackColor = Color.FromArgb(r2.Next(0, 50), r2.Next(0, 50), r2.Next(0, 50));
                
            }
            
            if (ball.Left <= panel1.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= panel1.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= panel1.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= panel1.Bottom)
            {
                speed_top = -speed_top;
            }
        }

  

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            balls++;
            if (balls == 1)
            {
                ball2.Visible = true;
                timer2.Enabled = true;
            }
            else if(balls == 2)
            {
                ball3.Visible = true;
                timer4.Enabled = true;
            }
            else if (balls == 3)
            {
                ball4.Visible = true;
                timer5.Enabled = true;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ball2.Left+= speed_ball2l;
            ball2.Top += speed_ball2t;
            if (ball2.Left <= panel1.Left)
            {
                speed_ball2l = -speed_ball2l;
            }
            if (ball2.Right >= panel1.Right)
            {
                speed_ball2l = -speed_ball2l;
            }
            if (ball2.Top <= panel1.Top)
            {
                speed_ball2t = -speed_ball2t;
            }
            if (ball2.Bottom >= panel1.Bottom)
            {
                speed_ball2t = -speed_ball2t;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            slider.Left += speed_slider;
            if (slider.Left <= panel1.Left)
            {
                speed_slider = -speed_slider;
            }
            if (slider.Right >= panel1.Right)
            {
                speed_slider = -speed_slider;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            ball3.Left += speed_ball3l;
            ball3.Top += speed_ball3t;
            if (ball3.Left <= panel1.Left)
            {
                speed_ball3l = -speed_ball3l;
            }
            if (ball3.Right >= panel1.Right)
            {
                speed_ball3l = -speed_ball3l;
            }
            if (ball3.Top <= panel1.Top)
            {
                speed_ball3t = -speed_ball3t;
            }
            if (ball3.Bottom >= panel1.Bottom)
            {
                speed_ball3t = -speed_ball3t;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            ball4.Left += speed_ball4l;
            ball4.Top += speed_ball4t;
            if (ball4.Left <= panel1.Left)
            {
                speed_ball4l = -speed_ball4l;
            }
            if (ball4.Right >= panel1.Right)
            {
                speed_ball4l = -speed_ball4l;
            }
            if (ball4.Top <= panel1.Top)
            {
                speed_ball4t = -speed_ball4t;
            }
            if (ball4.Bottom >= panel1.Bottom)
            {
                speed_ball4t = -speed_ball4t;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ball4_Click(object sender, EventArgs e)
        {

        }

        private void ball3_Click(object sender, EventArgs e)
        {

        }

        private void ball2_Click(object sender, EventArgs e)
        {

        }
    }
    }

       
    

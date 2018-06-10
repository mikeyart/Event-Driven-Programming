using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;

namespace Laboratory
{
    public partial class Form1 : Form
    {
        Color paintcolor;
        bool choose = false;
        bool draw = false;
        int x, y, lx, ly = 0;
        Item currItem;
        public Form1()
        {
            InitializeComponent();
        }
        public enum Item
        {
            Rectangle, Ellipse, Line, Brush, Pencil, Eraser
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            x = e.X;
            y = e.Y;

        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            lx = e.X;
            ly = e.Y;
            if (currItem == Item.Line)
            {
                Graphics g = pictureBox3.CreateGraphics();
                g.DrawLine(new Pen(new SolidBrush(paintcolor),Convert.ToInt32(toolStripComboBox1.Text)), new Point(x, y), new Point(lx, ly));
                g.Dispose();
            }
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics g = pictureBox3.CreateGraphics();
                switch(currItem)
                {
                    
                    case Item.Rectangle:
                        g.FillRectangle(new SolidBrush(paintcolor), x, y, e.X - x, e.Y - y);
                        break;
                    case Item.Ellipse:
                        g.FillEllipse(new SolidBrush(paintcolor), x, y, e.X - x, e.Y - y);
                        break;
                    case Item.Pencil:
                        g.FillEllipse(new SolidBrush(paintcolor), e.X, e.Y, 2, 2);
                        break;
                    case Item.Brush:
                        g.FillEllipse (new SolidBrush(paintcolor), e.X, e.Y,Convert.ToInt32(toolStripComboBox1.Text),Convert.ToInt32(toolStripComboBox1.Text));
                        break;
                    case Item.Eraser:
                        g.FillEllipse(new SolidBrush(pictureBox3.BackColor), e.X, e.Y, Convert.ToInt32(toolStripComboBox1.Text), Convert.ToInt32(toolStripComboBox1.Text));
                        break;


                }
            }
        }

        

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            currItem = Item.Line;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            currItem = Item.Rectangle;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            currItem = Item.Ellipse;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            currItem = Item.Pencil;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            currItem = Item.Brush;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Text = "1";
            toolStripComboBox1.Items.Add(1);
            toolStripComboBox1.Items.Add(2);
            toolStripComboBox1.Items.Add(3);
            toolStripComboBox1.Items.Add(4);
            toolStripComboBox1.Items.Add(5);
            toolStripComboBox1.Items.Add(10);
            toolStripComboBox1.Items.Add(15);
            toolStripComboBox1.Items.Add(20);
            toolStripComboBox1.Items.Add(25);
            toolStripComboBox1.Items.Add(50);
            toolStripComboBox1.Items.Add(100);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (choose)
            {
                Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
                paintcolor = bmp.GetPixel(e.X, e.Y);
                pictureBox2.BackColor = paintcolor;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen pen;
            Graphics vector;
            vector = CreateGraphics();
            pen = new Pen(Color.Red,4);
            pen.Color = Color.Red;
            vector.DrawEllipse(pen, 700, 200, 50, 50);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics vector;
            vector = CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Blue);
            vector.FillRectangle(brush, 645, 280, 80, 60);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Bezier = new Form2();
            Bezier.Show();

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            currItem = Item.Eraser;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            choose = true;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            choose = false;
        }

      

        
    }
}

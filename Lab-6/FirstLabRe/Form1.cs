using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstLabRe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Left = (panel1.Width / 2) - (label1.Width / 2);
            label1.Top = (panel1.Height / 2) - (label1.Height / 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            panel1.BackColor= Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.Top = r.Next(50, 100);
            this.Left = r.Next(50, 100);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Monotype Corsiva",label1.Font.Size);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.Width = r.Next(500, 900);
            this.Height = r.Next(400, 600);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

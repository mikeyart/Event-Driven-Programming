using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class NewhighscoreForm : Form
    {
        public NewhighscoreForm()
        {
            InitializeComponent();
        }

        private void NewhighscoreForm_Load(object sender, EventArgs e)
        {

        }
        public string GetName()
        {
            return textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Count() == 0)
            {
                MessageBox.Show("Please enter your name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}

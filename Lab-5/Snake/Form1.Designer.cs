namespace Snake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.endGamelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Label();
            this.A7 = new System.Windows.Forms.Label();
            this.A8 = new System.Windows.Forms.Label();
            this.A9 = new System.Windows.Forms.Label();
            this.A10 = new System.Windows.Forms.Label();
            this.A2 = new System.Windows.Forms.Label();
            this.A3 = new System.Windows.Forms.Label();
            this.A4 = new System.Windows.Forms.Label();
            this.A5 = new System.Windows.Forms.Label();
            this.A6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.endGamelabel);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(72, 151);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 746);
            this.panel1.TabIndex = 3;
            // 
            // endGamelabel
            // 
            this.endGamelabel.AutoSize = true;
            this.endGamelabel.BackColor = System.Drawing.Color.Black;
            this.endGamelabel.Font = new System.Drawing.Font("Broadway", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGamelabel.ForeColor = System.Drawing.Color.Red;
            this.endGamelabel.Location = new System.Drawing.Point(254, 340);
            this.endGamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endGamelabel.Name = "endGamelabel";
            this.endGamelabel.Size = new System.Drawing.Size(0, 22);
            this.endGamelabel.TabIndex = 2;
            this.endGamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endGamelabel.Visible = false;
            this.endGamelabel.Click += new System.EventHandler(this.endGamelabel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(74, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Amount of food:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Broadway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(530, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Snake Length: ";
            this.label2.Click += new System.EventHandler(this.snakeLengthlabel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Broadway", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(277, 958);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(311, 26);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Individual box borders";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Broadway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(771, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 20;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(574, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 57);
            this.label4.TabIndex = 31;
            this.label4.Text = "Restart";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.Paint += new System.Windows.Forms.PaintEventHandler(this.label4_Paint);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.Transparent;
            this.A1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A1.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.Color.Red;
            this.A1.Location = new System.Drawing.Point(74, 66);
            this.A1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(39, 35);
            this.A1.TabIndex = 18;
            this.A1.Text = "1";
            this.A1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A1.Click += new System.EventHandler(this.A1_Click);
            // 
            // A7
            // 
            this.A7.BackColor = System.Drawing.Color.Transparent;
            this.A7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A7.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A7.ForeColor = System.Drawing.Color.Maroon;
            this.A7.Location = new System.Drawing.Point(114, 103);
            this.A7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(39, 35);
            this.A7.TabIndex = 24;
            this.A7.Text = "7";
            this.A7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A7.Click += new System.EventHandler(this.A7_Click);
            // 
            // A8
            // 
            this.A8.BackColor = System.Drawing.Color.Transparent;
            this.A8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A8.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A8.ForeColor = System.Drawing.Color.Maroon;
            this.A8.Location = new System.Drawing.Point(154, 103);
            this.A8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A8.Name = "A8";
            this.A8.Size = new System.Drawing.Size(39, 35);
            this.A8.TabIndex = 25;
            this.A8.Text = "8";
            this.A8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A8.Click += new System.EventHandler(this.A8_Click);
            // 
            // A9
            // 
            this.A9.BackColor = System.Drawing.Color.Transparent;
            this.A9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A9.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A9.ForeColor = System.Drawing.Color.Maroon;
            this.A9.Location = new System.Drawing.Point(195, 103);
            this.A9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A9.Name = "A9";
            this.A9.Size = new System.Drawing.Size(39, 35);
            this.A9.TabIndex = 26;
            this.A9.Text = "9";
            this.A9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A9.Click += new System.EventHandler(this.A9_Click);
            // 
            // A10
            // 
            this.A10.BackColor = System.Drawing.Color.Transparent;
            this.A10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A10.Font = new System.Drawing.Font("Broadway", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A10.ForeColor = System.Drawing.Color.Maroon;
            this.A10.Location = new System.Drawing.Point(236, 103);
            this.A10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(53, 35);
            this.A10.TabIndex = 27;
            this.A10.Text = "10";
            this.A10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A10.Click += new System.EventHandler(this.A10_Click);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.Transparent;
            this.A2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A2.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.Color.Maroon;
            this.A2.Location = new System.Drawing.Point(114, 66);
            this.A2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(39, 35);
            this.A2.TabIndex = 19;
            this.A2.Text = "2";
            this.A2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A2.Click += new System.EventHandler(this.A2_Click);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.Transparent;
            this.A3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A3.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.Color.Maroon;
            this.A3.Location = new System.Drawing.Point(154, 66);
            this.A3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(39, 35);
            this.A3.TabIndex = 20;
            this.A3.Text = "3";
            this.A3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A3.Click += new System.EventHandler(this.A3_Click);
            // 
            // A4
            // 
            this.A4.BackColor = System.Drawing.Color.Transparent;
            this.A4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A4.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A4.ForeColor = System.Drawing.Color.Maroon;
            this.A4.Location = new System.Drawing.Point(195, 66);
            this.A4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(39, 35);
            this.A4.TabIndex = 21;
            this.A4.Text = "4";
            this.A4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A4.Click += new System.EventHandler(this.A4_Click);
            // 
            // A5
            // 
            this.A5.BackColor = System.Drawing.Color.Transparent;
            this.A5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A5.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A5.ForeColor = System.Drawing.Color.Maroon;
            this.A5.Location = new System.Drawing.Point(236, 66);
            this.A5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(39, 35);
            this.A5.TabIndex = 22;
            this.A5.Text = "5";
            this.A5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A5.Click += new System.EventHandler(this.A5_Click);
            // 
            // A6
            // 
            this.A6.BackColor = System.Drawing.Color.Transparent;
            this.A6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A6.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A6.ForeColor = System.Drawing.Color.Maroon;
            this.A6.Location = new System.Drawing.Point(74, 103);
            this.A6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(39, 35);
            this.A6.TabIndex = 23;
            this.A6.Text = "6";
            this.A6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A6.Click += new System.EventHandler(this.A6_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Broadway", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(324, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 45);
            this.label5.TabIndex = 32;
            this.label5.Text = "Highscores";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.Paint += new System.Windows.Forms.PaintEventHandler(this.label5_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(874, 960);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.A6);
            this.Controls.Add(this.A5);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A9);
            this.Controls.Add(this.A8);
            this.Controls.Add(this.A7);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.A10_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label endGamelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label A1;
        private System.Windows.Forms.Label A7;
        private System.Windows.Forms.Label A8;
        private System.Windows.Forms.Label A9;
        private System.Windows.Forms.Label A10;
        private System.Windows.Forms.Label A2;
        private System.Windows.Forms.Label A3;
        private System.Windows.Forms.Label A4;
        private System.Windows.Forms.Label A5;
        private System.Windows.Forms.Label A6;
        private System.Windows.Forms.Label label5;
    }
}


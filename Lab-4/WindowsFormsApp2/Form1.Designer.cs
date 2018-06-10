namespace WindowsFormsApp2
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
            this.ball4 = new System.Windows.Forms.PictureBox();
            this.ball3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ball2 = new System.Windows.Forms.PictureBox();
            this.slider = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ball4);
            this.panel1.Controls.Add(this.ball3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ball2);
            this.panel1.Controls.Add(this.slider);
            this.panel1.Controls.Add(this.ball);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 508);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // ball4
            // 
            this.ball4.BackColor = System.Drawing.Color.Transparent;
            this.ball4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball4.BackgroundImage")));
            this.ball4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ball4.Location = new System.Drawing.Point(763, 13);
            this.ball4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ball4.Name = "ball4";
            this.ball4.Size = new System.Drawing.Size(133, 62);
            this.ball4.TabIndex = 4;
            this.ball4.TabStop = false;
            this.ball4.Visible = false;
            this.ball4.Click += new System.EventHandler(this.ball4_Click);
            // 
            // ball3
            // 
            this.ball3.BackColor = System.Drawing.Color.Transparent;
            this.ball3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball3.BackgroundImage")));
            this.ball3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ball3.Location = new System.Drawing.Point(92, 367);
            this.ball3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ball3.Name = "ball3";
            this.ball3.Size = new System.Drawing.Size(76, 62);
            this.ball3.TabIndex = 3;
            this.ball3.TabStop = false;
            this.ball3.Visible = false;
            this.ball3.Click += new System.EventHandler(this.ball3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(923, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESC - Exit\r\nLeft MouseClick - Add a ball\r\n";
            // 
            // ball2
            // 
            this.ball2.BackColor = System.Drawing.Color.Transparent;
            this.ball2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball2.BackgroundImage")));
            this.ball2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ball2.Location = new System.Drawing.Point(967, 170);
            this.ball2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ball2.Name = "ball2";
            this.ball2.Size = new System.Drawing.Size(65, 61);
            this.ball2.TabIndex = 2;
            this.ball2.TabStop = false;
            this.ball2.Visible = false;
            this.ball2.Click += new System.EventHandler(this.ball2_Click);
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.Red;
            this.slider.Location = new System.Drawing.Point(315, 380);
            this.slider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(245, 18);
            this.slider.TabIndex = 1;
            this.slider.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ball.Location = new System.Drawing.Point(56, 27);
            this.ball.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(68, 62);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 90;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 80;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 70;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1252, 508);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Timer_Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ball4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox slider;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ball2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ball3;
        private System.Windows.Forms.PictureBox ball4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
    }
}


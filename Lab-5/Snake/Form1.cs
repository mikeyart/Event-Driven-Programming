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
    public partial class Form1 : Form
    {
        

        PictureBox[,] Box;                            // Stores all of the pictureboxes on board
        int snakexPos;                        // X position of snake's head
        int snakeyPos;                        // Y posiiton of snake's head
        string changeTodirection = "left";
        string direction = "left";
        int snakeLength = 1;
        int[] snakexPositions;                        // Stores all the X positions of each piece of the snake
        int[] snakeyPositions;                        // Stores all the Y positions of each piece of the snake
        Random R = new Random();
        int[] foodxPos;
        int[] foodyPos;
        int amountofFood = 1;                         // Amount of food on screen at a time
        bool replaceFood = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
            endGamelabel.Cursor = Cursors.Hand;
            foodxPos = new int[10];
            foodyPos = new int[10];
            snakexPositions = new int[100];
            snakeyPositions = new int[100];
            Box = new PictureBox[30, 30];

            for (int y = 0; y < 30; y++)                // Creates 30x30 board of picturebox
            {
                for (int x = 0; x < 30; x++)
                {
                    Box[x, y] = new PictureBox();
                    Box[x, y].Left = 50 + x * 16;
                    Box[x, y].Top = 100 + y * 16;
                    Box[x, y].Width = 17;
                    Box[x, y].Height = 17;
                    Box[x, y].BackColor = Color.Black;

                    if (checkBox1.Checked == true)
                    {
                        Box[x, y].BorderStyle = BorderStyle.FixedSingle;
                    }
                    else
                    {
                        Box[x, y].BorderStyle = BorderStyle.None;
                    }

                    Controls.Add(Box[x, y]);
                }
            }

            Box[15, 15].BackColor = Color.Red;
            snakexPos = 15;
            snakeyPos = 15;
            snakexPositions[1] = 15;
            snakeyPositions[1] = 15;
            newFood();                      //Places food
            panel1.SendToBack();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)      //Get arrow key input to move snake
        {
            switch (keyData)
            {
                case Keys.Left:
                    changeTodirection = "left";
                    break;
                case Keys.Right:
                    changeTodirection = "right";
                    break;
                case Keys.Up:
                    changeTodirection = "up";
                    break;
                case Keys.Down:
                    changeTodirection = "down";
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        bool foundBox = false;
        int foodNum = 1;

        private void newFood()                              //Places food
        {
            foodNum = 0;

            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 30; x++)
                {
                    if (Box[x, y].BackColor == Color.Blue)
                    {
                        foodxPos[foodNum] = x;
                        foodyPos[foodNum] = y;
                        foodNum++;
                        Box[x, y].BackColor = Color.Black;
                    }
                }
            }

            if (replaceFood == false)                   // is true when game starts or the amount of food is changed
            {
                for (int i = 0; i <= amountofFood - 1; i++)
                {
                    Box[foodxPos[i], foodyPos[i]].BackColor = Color.Blue;
                }

                foundBox = false;
                while (foundBox == false)                   // places food in random empty place
                {
                    foodxPos[amountofFood - 1] = R.Next(0, 30);
                    foodyPos[amountofFood - 1] = R.Next(0, 30);

                    if (Box[foodxPos[amountofFood - 1], foodyPos[amountofFood - 1]].BackColor == Color.Black)
                    {
                        Box[foodxPos[amountofFood - 1], foodyPos[amountofFood - 1]].BackColor = Color.Blue;
                        foundBox = true;
                    }
                    else
                    {
                        foodxPos[amountofFood - 1] = R.Next(0, 30);
                        foodyPos[amountofFood - 1] = R.Next(0, 30);
                    }
                }
            }
            else
            {
                replaceFood = false;
                for (int i = 0; i <= amountofFood - 1; i++)             //places the amount of food we indicate
                {
                    foundBox = false;

                    while (foundBox == false)
                    {
                        foundBox = false;

                        foodxPos[i] = R.Next(0, 30);
                        foodyPos[i] = R.Next(0, 30);

                        if (Box[foodxPos[i], foodyPos[i]].BackColor == Color.Black)
                        {
                            Box[foodxPos[i], foodyPos[i]].BackColor = Color.Blue;
                            foundBox = true;
                        }
                        else
                        {
                            foodxPos[i] = R.Next(0, 30);
                            foodyPos[i] = R.Next(0, 30);
                        }
                    }
                }
            }
        }

        private void checkifOffBoard()
        {
            if (snakexPos < 0 || snakexPos > 29 || snakeyPos < 0 || snakeyPos > 29)
            {
                endGamelabel.Text = "You Lost!" + Environment.NewLine + Environment.NewLine + "The snake went off the board" + Environment.NewLine + Environment.NewLine + "Click to play again";
                endGame();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = snakeLength.ToString();

            switch (changeTodirection)                      // Checks if snake can move in the direction of the pressed arrow
            {
                case "left":
                    if (direction != "right")
                    {
                        direction = "left";
                    }
                    break;
                case "right":
                    if (direction != "left")
                    {
                        direction = "right";
                    }
                    break;
                case "up":
                    if (direction != "down")
                    {
                        direction = "up";
                    }
                    break;
                case "down":
                    if (direction != "up")
                    {
                        direction = "down";
                    }
                    break;
            }

            switch (direction)                                      // Changes snake's direction
            {
                case "left":
                    snakexPos -= 1;
                    checkifOffBoard();
                    Box[snakexPos, snakeyPos].BackColor = Color.Red;
                    break;
                case "right":
                    snakexPos += 1;
                    checkifOffBoard();
                    Box[snakexPos, snakeyPos].BackColor = Color.Red;
                    break;
                case "up":
                    snakeyPos -= 1;
                    checkifOffBoard();
                    Box[snakexPos, snakeyPos].BackColor = Color.Red;
                    break;
                case "down":
                    snakeyPos += 1;
                    checkifOffBoard();
                    Box[snakexPos, snakeyPos].BackColor = Color.Red;
                    break;
            }

            for (int i = 0; i <= 9; i++)                // Checks if the snake has eaten a food
            {
                if (snakexPos == foodxPos[i] && snakeyPos == foodyPos[i])
                {
                    snakeLength++;
                    label3.Text = snakeLength.ToString();
                    newFood();
                }
            }

            for (int i = 1; i < 100; i++)                   // Checks if the snake has collided with itself
            {
                if (snakexPos == snakexPositions[i] && snakeyPos == snakeyPositions[i])
                {
                    endGamelabel.Text = "You Lost!" + Environment.NewLine + Environment.NewLine + "The snake collided with itself" + Environment.NewLine + Environment.NewLine + "Click to play again";
                    endGame();
                }
            }

            if (snakeLength < 20)                   // Increases the snakes movement depending on its length
            {
                timer1.Interval = 500 - snakeLength * 25;
            }
            for (int i = 99; i >= 1; i--)           // Makes the snake's body follow the path the head took
            {
                if (i < snakeLength)
                {
                    snakexPositions[i + 1] = snakexPositions[i];
                    snakeyPositions[i + 1] = snakeyPositions[i];
                }
                else if (i > snakeLength)
                {
                    snakexPositions[i] = -1;
                    snakeyPositions[i] = 0;
                }
            }

            snakexPositions[1] = snakexPos;
            snakeyPositions[1] = snakeyPos;

            for (int y = 0; y < 30; y++)            // Updates snake's position
            {
                for (int x = 0; x < 30; x++)
                {
                    if (Box[x, y].BackColor != Color.Blue)
                    {
                        Box[x, y].BackColor = Color.Black;
                    }

                    if (checkBox1.Checked == true)
                    {
                        Box[x, y].BorderStyle = BorderStyle.FixedSingle;
                    }
                    else
                    {
                        Box[x, y].BorderStyle = BorderStyle.None;
                    }
                }
            }

            for (int i = 1; i < 100; i++)
            {
                if (snakexPositions[i] != -1)
                {
                    Box[snakexPositions[i], snakeyPositions[i]].BackColor = Color.Red;
                }
            }
        }

        private void endGame()
        {
            timer1.Stop();
            int score = snakeLength * 10;
            var highscoreForm = new HighscoreForm();
            snakexPos = 15;
            snakeyPos = 15;
            endGamelabel.Visible = true;
            highscoreForm.tryHighscore(score);
            highscoreForm.ShowDialog();
           
        }

        private void endGamelabel_Click(object sender, EventArgs e)
        {
            endGamelabel.Visible = false;
            resetGame();
        }

        private void resetGame()
        {
            timer1.Interval = 500;
            timer1.Start();
            replaceFood = true;

            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 30; x++)
                {
                    Box[x, y].BackColor = Color.Black;
                }
            }

            for (int i = 1; i < 100; i++)
            {
                snakexPositions[i] = -1;
                snakeyPositions[i] = -1;
            }

            snakeLength = 1;

            Box[15, 15].BackColor = Color.Red;
            snakexPos = 15;
            snakeyPos = 15;
            direction = "left";
            changeTodirection = "left";
            snakexPositions[1] = 15;
            snakeyPositions[1] = 15;
            newFood();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void snakeLengthlabel_Click(object sender, EventArgs e)
        {

        }

        private void A1_Click(object sender, EventArgs e)   // v The Amount of food UI, (top left of form)
        {
            A1.ForeColor = Color.Red;
            A1.Font = new Font(A1.Font, FontStyle.Bold);
            A2.ForeColor = Color.Maroon;
            A3.ForeColor = Color.Maroon;
            A4.ForeColor = Color.Maroon;
            A5.ForeColor = Color.Maroon;
            A6.ForeColor = Color.Maroon;
            A7.ForeColor = Color.Maroon;
            A8.ForeColor = Color.Maroon;
            A9.ForeColor = Color.Maroon;
            A10.ForeColor = Color.Maroon;
            amountofFood = 1;
            replaceFood = true;
            newFood();
        }

        private void A2_Click(object sender, EventArgs e)
        {
            A2.ForeColor = Color.Red;
            A2.Font = new Font(A2.Font, FontStyle.Bold);
            A1.ForeColor = Color.Maroon;
            A3.ForeColor = Color.Maroon;
            A4.ForeColor = Color.Maroon;
            A5.ForeColor = Color.Maroon;
            A6.ForeColor = Color.Maroon;
            A7.ForeColor = Color.Maroon;
            A8.ForeColor = Color.Maroon;
            A9.ForeColor = Color.Maroon;
            A10.ForeColor = Color.Maroon;
            amountofFood = 2;
            replaceFood = true;
            newFood();
        }

        private void A3_Click(object sender, EventArgs e)
        {
            A3.ForeColor = Color.Red;
            A3.Font = new Font(A3.Font, FontStyle.Bold);
            A1.ForeColor = Color.Maroon;
            A2.ForeColor = Color.Maroon;
            A4.ForeColor = Color.Maroon;
            A5.ForeColor = Color.Maroon;
            A6.ForeColor = Color.Maroon;
            A7.ForeColor = Color.Maroon;
            A8.ForeColor = Color.Maroon;
            A9.ForeColor = Color.Maroon;
            A10.ForeColor = Color.Maroon;
            amountofFood = 3;
            replaceFood = true;
            newFood();
        }

        private void A4_Click(object sender, EventArgs e)
        {
            A4.ForeColor = Color.Red;
            A4.Font = new Font(A4.Font, FontStyle.Bold);
            A1.ForeColor = Color.Maroon;
            A2.ForeColor = Color.Maroon;
            A3.ForeColor = Color.Maroon;
            A5.ForeColor = Color.Maroon;
            A6.ForeColor = Color.Maroon;
            A7.ForeColor = Color.Maroon;
            A8.ForeColor = Color.Maroon;
            A9.ForeColor = Color.Maroon;
            A10.ForeColor = Color.Maroon;
            amountofFood = 4;
            replaceFood = true;
            newFood();
        }

        private void A5_Click(object sender, EventArgs e)
        {
            A5.ForeColor = Color.Red;
            A5.Font = new Font(A5.Font, FontStyle.Bold);
            A1.ForeColor = Color.Maroon;
            A2.ForeColor = Color.Maroon;
            A3.ForeColor = Color.Maroon;
            A4.ForeColor = Color.Maroon;
            A6.ForeColor = Color.Maroon;
            A7.ForeColor = Color.Maroon;
            A8.ForeColor = Color.Maroon;
            A9.ForeColor = Color.Maroon;
            A10.ForeColor = Color.Maroon;
            amountofFood = 5;
            replaceFood = true;
            newFood();
        }

        private void A6_Click(object sender, EventArgs e)
        {
            A6.ForeColor = Color.Red;
            A6.Font = new Font(A6.Font, FontStyle.Bold);
            A1.ForeColor = Color.Maroon;
            A2.ForeColor = Color.Maroon;
            A3.ForeColor = Color.Maroon;
            A4.ForeColor = Color.Maroon;
            A5.ForeColor = Color.Maroon;
            A7.ForeColor = Color.Maroon;
            A8.ForeColor = Color.Maroon;
            A9.ForeColor = Color.Maroon;
            A10.ForeColor = Color.Maroon;
            amountofFood = 6;
            replaceFood = true;
            newFood();
        }

        private void A7_Click(object sender, EventArgs e)
        {
            A7.ForeColor = Color.Red;
            A7.Font = new Font(A7.Font, FontStyle.Bold);
            A1.ForeColor = Color.Maroon;
            A2.ForeColor = Color.Maroon;
            A3.ForeColor = Color.Maroon;
            A4.ForeColor = Color.Maroon;
            A5.ForeColor = Color.Maroon;
            A6.ForeColor = Color.Maroon;
            A8.ForeColor = Color.Maroon;
            A9.ForeColor = Color.Maroon;
            A10.ForeColor = Color.Maroon;
            amountofFood = 7;
            replaceFood = true;
            newFood();
        }

        private void A8_Click(object sender, EventArgs e)
        {
            A8.ForeColor = Color.Red;
            A8.Font = new Font(A8.Font, FontStyle.Bold);
            A1.ForeColor = Color.Maroon;
            A2.ForeColor = Color.Maroon;
            A3.ForeColor = Color.Maroon;
            A4.ForeColor = Color.Maroon;
            A5.ForeColor = Color.Maroon;
            A6.ForeColor = Color.Maroon;
            A7.ForeColor = Color.Maroon;
            A9.ForeColor = Color.Maroon;
            A10.ForeColor = Color.Maroon;
            amountofFood = 8;
            replaceFood = true;
            newFood();
        }

        private void A9_Click(object sender, EventArgs e)
        {
            A9.ForeColor = Color.Red;
            A9.Font = new Font(A9.Font, FontStyle.Bold);
            A1.ForeColor = Color.Maroon;
            A2.ForeColor = Color.Maroon;
            A3.ForeColor = Color.Maroon;
            A4.ForeColor = Color.Maroon;
            A5.ForeColor = Color.Maroon;
            A6.ForeColor = Color.Maroon;
            A7.ForeColor = Color.Maroon;
            A8.ForeColor = Color.Maroon;
            A10.ForeColor = Color.Maroon;
            amountofFood = 9;
            replaceFood = true;
            newFood();
        }

        private void A10_Click(object sender, EventArgs e)
        {
            A10.ForeColor = Color.Red;
            A10.Font = new Font(A10.Font, FontStyle.Bold);
            A1.ForeColor = Color.Maroon;
            A2.ForeColor = Color.Maroon;
            A3.ForeColor = Color.Maroon;
            A4.ForeColor = Color.Maroon;
            A5.ForeColor = Color.Maroon;
            A6.ForeColor = Color.Maroon;
            A7.ForeColor = Color.Maroon;
            A8.ForeColor = Color.Maroon;
            A9.ForeColor = Color.Maroon;
            amountofFood = 10;
            replaceFood = true;
            newFood();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void label4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, label4.DisplayRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, label5.DisplayRectangle, Color.Red, ButtonBorderStyle.Solid);
        }
    }
}

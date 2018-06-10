using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class HighscoreForm : Form
    {
        private const int maxrecords = 10;
        List<Highscore> highscores;
        public HighscoreForm()
        {
            InitializeComponent();
            this.highscores = new List<Highscore>(this.LoadHighscore());
        }

        private void HighscoreForm_Load(object sender, EventArgs e)
        {

        }

        private class Highscore
        {
            public int score { get; set; }
            public string name { get; set; }
        }

        private List<Highscore> LoadHighscore()
        {
            List<Highscore> highscores = new List<Highscore>();
            if (Properties.Settings.Default.Highscores != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.Highscores)))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        highscores = (List<Highscore>)bf.Deserialize(ms);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

            return highscores;
        }

        private void Savehighscore()
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ms, this.highscores);
                    ms.Position = 0;
                    byte[] buffer = new byte[(int)ms.Length];
                    ms.Read(buffer, 0, buffer.Length);
                    Properties.Settings.Default.Highscores = Convert.ToBase64String(buffer);
                    Properties.Settings.Default.Save();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void tryHighscore(int score)
        {

            var newhighscoreForm = new NewhighscoreForm();
            if (newhighscoreForm.ShowDialog() == DialogResult.OK)
            {
                var name = newhighscoreForm.GetName();
                var newScore = new Highscore()
                {
                    score = score,
                    name = name
                };

                for (int i = 0; i < this.highscores.Count; i++)
                {
                    if (score > highscores[i].score)
                    {
                        this.highscores.Insert(i, newScore);

                        if (this.highscores.Count > maxrecords)
                        {
                            this.highscores.Remove(this.highscores.Last());
                        }
                        this.Savehighscore();
                        break;
                    }

                }
            }
        }
    }
}

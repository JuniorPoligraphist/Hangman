using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class HangmanForm : Form
    {
        public HangmanForm()
        {
            InitializeComponent();
        }

        int health = 12;
        int words = 220;
        string word = "";
        char[] now = new char[10];
        Random random = new Random();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 4);
            healthCount.Text = health.ToString();


            if (health <= 11)
            {
                g.DrawLine(pen, 20, 240, 20, 220);
                healthCount.Text = health.ToString();
            }
            if (health <= 10)
            {
                g.DrawLine(pen, 20, 220, 140, 220);
                healthCount.Text = health.ToString();
            }
            if (health <= 9)
            {
                g.DrawLine(pen, 140, 220, 140, 240);
                healthCount.Text = health.ToString();
            }
            if (health <= 8)
            {
                g.DrawLine(pen, 60, 40, 60, 220);
                healthCount.Text = health.ToString();
            }
            if (health <= 7)
            {
                g.DrawLine(pen, 60, 40, 120, 40);
                healthCount.Text = health.ToString();
            }
            if (health <= 6)
            {
                g.DrawLine(pen, 120, 40, 120, 60);
                healthCount.Text = health.ToString();
            }
            if (health <= 5)
            {
                g.DrawEllipse(pen, 100, 60, 40, 40);
                healthCount.Text = health.ToString();
            }
            if (health <= 4)
            {
                g.DrawLine(pen, 120, 100, 120, 160);
                healthCount.Text = health.ToString();
            }
            if (health <= 3)
            {
                g.DrawLine(pen, 120, 100, 140, 140);
                healthCount.Text = health.ToString();
            }
            if (health <= 2)
            {
                g.DrawLine(pen, 120, 100, 100, 140);
                healthCount.Text = health.ToString();
            }
            if (health <= 1)
            {
                g.DrawLine(pen, 120, 158, 130, 210);
                healthCount.Text = health.ToString();
            }
            if (health <= 0)
            {
                g.DrawLine(pen, 119, 158, 110, 210);
                healthCount.Text = health.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Invalidate();
            StreamReader streamReader = new StreamReader("List.txt");
            int choice = random.Next(0, words);
            while (choice >= 0)
            {
                word = streamReader.ReadLine();
                choice--;
            }
            labelOne.Text = "";
            labelTwo.Text = "";
            for (int i = 0; i < word.Length; i++)
            {
                now[i] = '*';
            }
            for (int i = 0; i < word.Length; i++)
            {
                labelOne.Text += now[i];
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char p = e.KeyChar;
            bool b = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (p == word[i] && now[i] == '*')
                {
                    now[i] = p;
                    b = false;
                }
            }
            if (b) health--;
            labelOne.Text = "";
            labelTwo.Text += p;
            for (int i = 0; i < word.Length; i++)
            {
                labelOne.Text += now[i];
            }

            this.Invalidate();
            if (health <= 0)
            {
                MessageBox.Show("Game over! It was " + word.ToString());
                Application.Exit();
            }
            if (labelOne.Text == word)
            {
                MessageBox.Show("You win! Good job!");
                Application.Exit();
            }
        }

        private void LabelOne_MouseHover(object sender, EventArgs e)
        {
            labelHint.Text = "Just press a keys and guess a hided word!";
            
            labelHint.Visible = true;
        }

        private void LabelOne_MouseLeave(object sender, EventArgs e)
        {
            labelHint.Visible = false;
        }
    }
}
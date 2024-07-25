using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Dice_Game
{
    public partial class Form1 : Form
    {
        int mouseclick = 0;
        int[] playerscores = {0, 0};

        public Form1()
        {
            InitializeComponent();            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mouseclick++;
            if (mouseclick <= 5)
            {
                generator();
            }
            else {
                this.Hide();
                String winner = "";
                if (playerscores[0] > playerscores[1]) { winner = "Player 1"; } else { winner = "Player 2"; }
                DialogResult dialogResult = MessageBox.Show("The Winner is " + winner + " !!!!", "" ,MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK) { 
                    this.Close();
                }
            }
        }
        public void generator()
        {
            Random generator = new Random();
            int random;
            PictureBox[] dices = { P1D1, P1D2, P2D1, P2D2 };
            TextBox[] display = { textBox1, textBox2 };
            int[] dicescores = new int[4];
            for (int pass = 0; pass < 4; pass++) {
                random = generator.Next(1,7);
                dicescores[pass] = random;
                changeimage(random, dices[pass]);
            }

            int total = 0;
            for (int player = 0; player < 2; player++) {
                if (player == 0)
                {
                    total = dicescores[0] + dicescores[1];
                    System.Console.WriteLine(total);
                }
                else { 
                    total = dicescores[2] + dicescores[3];
                    System.Console.WriteLine(total);
                }

                if (total % 2 == 0)
                {
                    playerscores[player] += 10;
                    display[player].Text = Convert.ToString(playerscores[player]);
                }
                else
                {
                    playerscores[player] -= 5;
                    display[player].Text = Convert.ToString(playerscores[player]);
                }

            }
        }
             
        private void changeimage(int num, PictureBox dice)
        {
            switch(num) 
            {
                case 1:
                    dice.Image = Properties.Resources.SIde_1;
                    break;

                case 2:
                    dice.Image = Properties.Resources.Side_2;
                    break;

                case 3:
                    dice.Image = Properties.Resources.Side_3;
                    break;
               
                case 4:
                    dice.Image = Properties.Resources.Side_4;
                    break;
                
                case 5:
                    dice.Image = Properties.Resources.Side_5;
                    break;
                
                case 6:
                    dice.Image = Properties.Resources.Side_6;
                    break;
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        { }
        private void pictureBox12_Click(object sender, EventArgs e)
        {}
        private void textBox1_TextChanged(object sender, EventArgs e)
        {}
        private void pictureBox1_Click(object sender, EventArgs e)
        {}
        private void pictureBox2_Click(object sender, EventArgs e)
        {}
        private void textBox2_TextChanged(object sender, EventArgs e)
        {}
        private void label2_Click(object sender, EventArgs e)
        {}
        private void Form1_Load(object sender, EventArgs e)
        {}
    }
}

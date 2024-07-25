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
        int i;       
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generator();
        }

        public void generator()
        {
            for (int turn = 0; turn <= 5; turn++)
            {
                Random generator = new Random();
                int random = generator.Next(1, 7);
                int random2 = generator.Next(1, 7);
                int random3 = generator.Next(1, 7);
                int random4 = generator.Next(1, 7);
                for (i = 0; i < random; i++)
                {
                    changeimage(i);
                }

                for (i = 0; i < random2; i++)
                {
                    changeimage2(i);
                }

                for (i = 0; i < random3; i++)
                {
                    changeimage3(i);
                }

                for (i = 0; i < random4; i++)
                {
                    changeimage4(i);
                }

                int dice1 = random - 1;
                int dice2 = random2 - 1;
                int score = 0;                
                int total = dice1 + dice2;
                
                 if (total % 2 == 0)
                 {
                    for (int z = 0; z < 100; z++)
                    {
                        int sum = score + 10;
                        textBox1.Text = Convert.ToString(sum);
                    }                   
                    
                }
            

                 else
                 {
                    for (int z = 0; z < 100; z++)
                    {
                        int sum = score - 5;
                        textBox1.Text = Convert.ToString(sum);
                    }
                }
            }
        }
             

        private void changeimage(int num)
        {
            switch(num) 
            {
                case 1:
                    pictureBox6.Image = Properties.Resources.SIde_1;
                    break;

                case 2:
                    pictureBox6.Image = Properties.Resources.Side_2;
                    break;

                case 3:
                    pictureBox6.Image = Properties.Resources.Side_3;
                    break;
               
                case 4:
                    pictureBox6.Image = Properties.Resources.Side_4;
                    break;
                
                case 5:
                    pictureBox6.Image = Properties.Resources.Side_5;
                    break;
                
                case 6:
                    pictureBox6.Image = Properties.Resources.Side_6;
                    break;
            }
            
        }

        private void changeimage3(int num)
        {
            switch (num)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.SIde_1;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.Side_2;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.Side_3;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.Side_4;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.Side_5;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.Side_6;
                    break;
            }

        }

        private void changeimage4(int num)
        {
            switch (num)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.SIde_1;
                    break;

                case 2:
                    pictureBox2.Image = Properties.Resources.Side_2;
                    break;

                case 3:
                    pictureBox2.Image = Properties.Resources.Side_3;
                    break;

                case 4:
                    pictureBox2.Image = Properties.Resources.Side_4;
                    break;

                case 5:
                    pictureBox2.Image = Properties.Resources.Side_5;
                    break;

                case 6:
                    pictureBox2.Image = Properties.Resources.Side_6;
                    break;
            }

        }

        private void changeimage2(int num)
        {
            switch (num)
            {
                case 1:
                    pictureBox12.Image = Properties.Resources.SIde_1;
                    break;

                case 2:
                    pictureBox12.Image = Properties.Resources.Side_2;
                    break;

                case 3:
                    pictureBox12.Image = Properties.Resources.Side_3;
                    break;

                case 4:
                    pictureBox12.Image = Properties.Resources.Side_4;
                    break;

                case 5:
                    pictureBox12.Image = Properties.Resources.Side_5;
                    break;

                case 6:
                    pictureBox12.Image = Properties.Resources.Side_6;
                    break;
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
        }
       
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
        }
             

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

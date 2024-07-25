using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Game
{
    public partial class Form2 : Form
    {
        double pass, user, password,username;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {           
            pass = Convert.ToDouble(textBox1.Text);
            if (password == pass)
            {
                MessageBox.Show(" Thank you, you have succesfully signed in ");
            }
            else
            {
                MessageBox.Show(" Please try again ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            game.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            user = Convert.ToDouble(textBox1.Text);
            if (username == user)
            {
                MessageBox.Show(" Thank you, you have succesfully signed in ");
            }

            else
            {
                MessageBox.Show(" Please try again ");
            }
        }
    }
}

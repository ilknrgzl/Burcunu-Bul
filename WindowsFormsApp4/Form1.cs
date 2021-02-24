using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gun;
        int ay;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ay = Convert.ToInt16(dateTimePicker1.Value.Month);
            gun = Convert.ToInt16(dateTimePicker1.Value.Day);

            if ((ay == 12 && gun >= 22) || (ay == 1 && gun <= 21))
            {
                textBox1.Text = "oglak";
            }

            if ((ay == 1 && gun >= 22) || (ay == 2 && gun <= 19))
            {
                textBox1.Text = "kova";
            }

            if ((ay == 2 && gun >= 20) || (ay == 3 && gun <= 20))
            {
                textBox1.Text = "balık";
            }
            if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 20))
            {
                textBox1.Text = "koç";
            }
            if ((ay == 5 && gun >= 22) || (ay == 6 && gun <= 22))
            {
                textBox1.Text = "ikizler";
            }
            if ((ay == 6 && gun >= 23) || (ay == 7 && gun <= 22))
            {
                textBox1.Text = "yengeç";
            }
            if ((ay == 7 && gun >= 23) || (ay == 8 && gun <= 22))
            {
                textBox1.Text = "aslan";
            }
            if ((ay == 8 && gun >= 23) || (ay == 9 && gun <= 22))
            {
                textBox1.Text = "başak";
            }
            if ((ay == 9 && gun >= 23) || (ay == 10 && gun <= 22))
            {
                textBox1.Text = "terazi";
            }
            if ((ay == 10 && gun >= 23) || (ay == 11 && gun <= 21))
            {
                textBox1.Text = "akrep";
            }
            if ((ay == 11 && gun >= 22) || (ay == 12 && gun <= 21))
            {
                textBox1.Text = "yay";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

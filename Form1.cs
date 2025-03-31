using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text.Text = " ";
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            {
                text.Text = "";
            }
            text.Text = text.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            {
                text.Text = "";
            }
            text.Text = text.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            {
                text.Text = "";
            }
            text.Text = text.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            {
                text.Text = "";
            }
            text.Text = text.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            {
                text.Text = "";
            }
            text.Text = text.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            {
                text.Text = "";
            }
            text.Text = text.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            {
                text.Text = "";
            }
            text.Text = text.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            {
                text.Text = "";
            }
            text.Text = text.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            {
                text.Text = "";
            }
            text.Text = text.Text + "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            {
                text.Text = "";
            }
            text.Text = text.Text + "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + ".";
        }
    }
}

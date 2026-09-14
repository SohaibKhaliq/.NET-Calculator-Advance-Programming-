using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool addition=false;
        bool subtraction = false;
        bool multiplication = false;
        bool division = false;

        double result = 0;
        double firstnumber;
        double secondnumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void zero_button_Click(object sender, EventArgs e)
        {
            screen.Text += "0";
        }

        private void one_button_Click(object sender, EventArgs e)
        {
            screen.Text += "1";
        }

        private void two_button_Click(object sender, EventArgs e)
        {
            screen.Text += "2";
        }

        private void three_button_Click(object sender, EventArgs e)
        {
            screen.Text += "3";
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            screen.Text += "4";
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            screen.Text += "5";
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            screen.Text += "6";
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            screen.Text += "7";
        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            screen.Text += "8";
        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            screen.Text += "9";
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(screen.Text);
            addition = true;
            screen.Clear();
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(screen.Text);
            subtraction = true;
            screen.Clear();
        }

        private void multiply_button_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(screen.Text);
            multiplication = true;
            screen.Clear();
        }

        private void divide_button_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(screen.Text);
            division = true;
            screen.Clear();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            firstnumber = 0;
            secondnumber = 0;
            addition = false;
            subtraction = false;
            multiplication = false;
            division = false;
            screen.Clear();
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            string check = screen.Text;
            if(check=="")
            {
                MessageBox.Show("Please enter a number before pressing equal.");
            }
            secondnumber = Convert.ToDouble(check);

            if(addition==true)
            {
                result = firstnumber + secondnumber;
                screen.Clear();
                screen.Text = Convert.ToString(result);
            }
            if(subtraction==true)
            {
                result = firstnumber - secondnumber;
                screen.Clear();
                screen.Text = Convert.ToString(result);
            }
            if(multiplication==true)
            {
                result = firstnumber * secondnumber;
                screen.Clear();
                screen.Text = Convert.ToString(result);
            }
            if(division==true)
            {
                if(secondnumber == 0)
                {
                    MessageBox.Show("Error: Division by zero is not allowed.");
                }
                else
                {
                    result = firstnumber / secondnumber;
                    screen.Clear();
                    screen.Text = Convert.ToString(result);
                }
            }

        }
    }
}

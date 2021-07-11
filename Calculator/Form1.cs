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
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstNumber, secondNumber, result;
            firstNumber = Convert.ToInt32(textBox1.Text);
            secondNumber = Convert.ToInt32(textBox2.Text);
            result = firstNumber + secondNumber;
   
            textBox3.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int firstNumber, secondNumber, result;
            firstNumber = Convert.ToInt32(textBox1.Text);
            secondNumber = Convert.ToInt32(textBox2.Text);
            result = firstNumber * secondNumber;

            textBox3.Text = Convert.ToString(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            double firstNumber, secondNumber, result;
            firstNumber = Convert.ToInt32(textBox1.Text);
            secondNumber = Convert.ToInt32(textBox2.Text);
            result = firstNumber - secondNumber;

            textBox3.Text = Convert.ToString(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double firstNumber, secondNumber, result;
            firstNumber = Convert.ToInt32(textBox1.Text);
            secondNumber = Convert.ToInt32(textBox2.Text);
            result = firstNumber / secondNumber;

            textBox3.Text = Convert.ToString(result);
        }
    }
}

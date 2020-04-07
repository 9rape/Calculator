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

        public double num1, num2;
        bool end;
        ICalc Calc;

        private void Form1_Load(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            end = false;
            Calc = null;
            textBox.Text = "0";
        }

        private void AddToTextBox(string a)
        {
            if (end)
            {
                textBox.Text = a;
                end = false;
            }
            else if (textBox.Text == "∞" || textBox.Text == "-∞" || textBox.Text == "не число")
                textBox.Text = a;
            else if (textBox.Text == "0")
                textBox.Text = a;
            else
                textBox.Text += a;
        }

        private void MultiAdd()
        {
            end = false;
            if (Calc != null)
            {
                num1 = Calc.DoMath(num1, Convert.ToDouble(textBox.Text));
            }
            else
            {
                num1 = Convert.ToDouble(textBox.Text);
            }
            textBox.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToTextBox("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddToTextBox("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddToTextBox("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddToTextBox("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddToTextBox("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddToTextBox("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddToTextBox("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddToTextBox("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddToTextBox("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddToTextBox("0");
        }

        private void sum_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                MultiAdd();
                Calc = new Operation.Sum();
            }
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                MultiAdd();
                Calc = new Operation.Subtract();
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                MultiAdd();
                Calc = new Operation.Multiply();
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                MultiAdd();
                Calc = new Operation.Divide();
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && Calc != null)
            {
                num2 = Convert.ToDouble(textBox.Text);
                textBox.Text = Calc.DoMath(num1, num2) + "";
                Calc = null;
                end = true;
            }
        }

        private void switch_Click(object sender, EventArgs e)
        {
            if (textBox.Text=="0") { }
            else if (Convert.ToDouble(textBox.Text) > 0)
            { textBox.Text = "-" + textBox.Text; }
            else if (Convert.ToDouble(textBox.Text) < 0)
            { textBox.Text = textBox.Text.Substring(textBox.Text.Length-1, 1); }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Contains(",")) { }
            else textBox.Text += ",";
        }

        private void correct_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculator : Form
    {
        double value = 0;
        string operation = "";
        bool operationPressed = false;

        public Calculator()
        {
            InitializeComponent();
        }


        private void button_click(object sender, EventArgs e)
        {
            if (result.Text == "0" || operationPressed)
            {
                result.Clear();
            }
            
            operationPressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if(!result.Text.Contains("."))
                { result.Text = result.Text + b.Text; }
            }
            else
            {
                result.Text = result.Text + b.Text;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(result.Text))
            {
                result.Text = result.Text.Substring(0, result.Text.Length - 1);
            }

        }

        private void operatior_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                equall.PerformClick();
                operationPressed = true;
                operation = b.Text;
                result2.Text = value + " " + operation;

            }
            else
            {
                operation = b.Text;
                value = double.Parse(result.Text);
                operationPressed = true;
                result2.Text = value + " " + operation;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                result2.Clear();

                switch (operation)
                {
                    case "+":
                        result.Text = (value + double.Parse(result.Text)).ToString();
                        break;
                    case "-":
                        result.Text = (value - double.Parse(result.Text)).ToString();
                        break;
                    case "*":
                        result.Text = (value * double.Parse(result.Text)).ToString();
                        break;
                    case "/":
                        result.Text = (value / double.Parse(result.Text)).ToString();
                        break;
                    default:
                        break;
                }
                operation = "";
                value = double.Parse(result.Text);
            }
            catch(Exception er)
            {
                MessageBox.Show("Error Occur");
                result.Text = "";
                result2.Text = "";
                operation = "";
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
            result2.Clear();
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "0":
                    zero.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "*":
                    mul.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                //case "Enter":
                //    equall.PerformClick();
                //    break;

                default:
                    return;
                    

            }
        }
    }
}

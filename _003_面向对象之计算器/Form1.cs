using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_面向对象之计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cobCaoZuoFu.SelectedIndex = 0;
        }

        private void btnJiSuan_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.Num1 = Convert.ToDouble(txtNum1.Text.Trim());
            calc.Num2 = Convert.ToDouble(txtNum2.Text.Trim());

            switch (cobCaoZuoFu.Text.Trim())
            {
                case "+":
                    lblResult.Text = calc.Add().ToString();
                    break;
                case "-":
                    lblResult.Text = calc.Subtraction().ToString();
                    break;
                case "*":
                    lblResult.Text = calc.Multiplier().ToString();
                    break;
                case "/":
                    lblResult.Text = calc.Division().ToString();
                    break;
                default:
                    break;
            }
        }
    }
}

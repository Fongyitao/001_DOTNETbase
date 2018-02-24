using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCaoZuFu.SelectedIndex = 0;
        }

        private void btnJiSuan_MouseClick(object sender, MouseEventArgs e)
        {
            double num1, num2;
            double.TryParse(txtNum1.Text.Trim(),out num1);
            num2 = Convert.ToDouble(txtNum2.Text.Trim());//重载更多

            //整理代码格式:ctrl + k,ctrl + F
            switch (cboCaoZuFu.Text.Trim())
            {
                case "+":
                    lblResult.Text = Math.Round((num1 + num2), 4).ToString();
                    break;
                case "-":
                    lblResult.Text = Math.Round((num1 - num2), 4).ToString();
                    break;
                case "/":
                    lblResult.Text = Math.Round((num1 / num2), 4).ToString();
                    break;
                case "*":
                    lblResult.Text = Math.Round((num1 * num2), 4).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}

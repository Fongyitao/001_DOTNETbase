using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_面向对象之计算器
{
    class Calculator
    {
        private double _num1, _num2;

        public double Num1 { get => _num1; set => _num1 = value; }
        public double Num2 { get => _num2; set => _num2 = value; }

        public Calculator()
        {
        }

        public Calculator(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
            
        }

        public double Add()
        {
            return Math.Round(Num1 + Num2, 4);
        }
        public double Subtraction()
        {
            return Math.Round(Num1 - Num2, 4);
        }
        public double Multiplier()
        {
            return Math.Round(Num1 * Num2, 4);
        }
        public double Division()
        {
            return Math.Round(Num1 / Num2, 4);
        }
    }
}

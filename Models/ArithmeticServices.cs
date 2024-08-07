using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrekshyaMaui.Models
{
    public class ArithmeticServices
    {

        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("You can't divide by zero");
            return (double)a / b;
        }
    }
}

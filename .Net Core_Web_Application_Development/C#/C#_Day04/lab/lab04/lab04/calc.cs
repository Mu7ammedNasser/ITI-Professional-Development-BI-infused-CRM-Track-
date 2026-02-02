using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class calc
    {
        public int num_1 { get; set; }
        public int num_2 { get; set; }

        public calc(int num1, int num2)
        {
            this.num_1 = num1;
            this.num_2 = num2;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            if (a > b)
                return b - a;

            else return a - b;
        }

        public static int multiply(int a, int b) { return a * b; }

        public static int divide(int a, int b)
        {
            if (a == 0 && b == 0)
                return 0;
            else if (b == 0)
                return 0;
            else
            {
                return (int)(a / b);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class Calculator
    {
        public int sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int rest(int num1, int num2)
        {
            return num1 - num2;
        }

        public int factorial(int num)
        {
            if (num == 0)
                return 1;
            return num * factorial(num - 1);
        }
    }
}


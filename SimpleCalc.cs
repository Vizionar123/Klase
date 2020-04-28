using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci
{
    class SimpleCalc
     {
        public static double Calc(string operation, double num1, double num2)
        {
            switch(operation)
            {
                case "+":
                    return Add(num1, num2);
                case "-":
                    return Subtract(num1, num2);
                case "*":
                    return Multiply(num1, num2);
                case "/":
                    return Divide(num1, num2);
                default:
                    return 0;
            }
        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {
            if (num2 > num1) {
                return num2 - num1;
            } else
            {
                return num1 - num2;
            }
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            if (num2 > num1)
            {
                return num2 / num1;
            }
            else
            {
                return num1 / num2;
            }
        }
        public static void Swap(ref double a, ref double b)
        {
            double pom;
            pom = a;
            a = b;
            b = pom;
        }

    }
}

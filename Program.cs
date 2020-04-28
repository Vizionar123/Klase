using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation;
            double number1, number2;

            Console.Write("Unesite operaciju (+, -, *, /) > ");
            operation = Console.ReadLine();
            Console.Write("Unesite prvi broj > ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Unesite drugi broj > ");
            number2 = Convert.ToDouble(Console.ReadLine());
            if (number2 > number1) { SimpleCalc.Swap(ref number1, ref number2); }
            double result = SimpleCalc.Calc(operation, number1, number2);
            Console.WriteLine("Rezultat operacije {0} {1} {2} = {3}", number1, operation, number2, result);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Lesson1
{
    delegate double calculate(double x, double y);
    public class thirdapp
    {
        static double add(double a, double b) => a + b;
        static double sub(double a, double b) => a - b;
        static double div(double a, double b) => b > 0 ?a / b : double.NaN;
        static double mult(double a, double b) => a * b;

        static void Main(string[] args)
        {
            calculate calc = add;
            Console.WriteLine(calc(10, 20));
            calc = sub;
            Console.WriteLine(calc(10, 20));
            calc = div;
            Console.WriteLine(calc(10, 20));
            calc = mult;
            Console.WriteLine(calc(10, 20));
        }
    }
}

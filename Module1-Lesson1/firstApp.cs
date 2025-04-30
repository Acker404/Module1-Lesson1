using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void MyDelegate(string message);

namespace Module1_Lesson1
{
    public class firstApp
    {
        public static void Main(string[] args)
        {
            MyDelegate delegateInstance = Console.WriteLine;
            delegateInstance("Hello, delagates");
        }
    }
}


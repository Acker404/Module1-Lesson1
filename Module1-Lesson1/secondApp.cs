using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Lesson1
{
    public class secondApp
    {
        public static void Main(string[] args)
        {
            Button b1 = new Button();
            b1.Click += Button_Click;
            b1.DunnyClick();
        }
        static void Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked!");
        }
    }
    public class  Button
    {
        public event EventHandler Click;
        public void DunnyClick()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
}

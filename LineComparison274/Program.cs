using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison274
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to linecomparison program");
            Console.WriteLine("enter the X1 and Y1 coordinate");
            double X1 = Convert.ToDouble(Console.ReadLine());
            double Y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the X2 and Y2 coordinate");
            double X2 = Convert.ToDouble(Console.ReadLine());
            double Y2 = Convert.ToDouble(Console.ReadLine());

            double Length = Math.Sqrt((Math.Pow((X2 - X1), 2)) + (Math.Pow((Y2 - Y1), 2)));
            Console.WriteLine("the lenght of two line " + Length);

            Console.ReadLine();
        }
    }
}

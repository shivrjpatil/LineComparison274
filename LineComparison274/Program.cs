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
            Console.WriteLine("Welcome to the Line Comparison problem statement");

            Console.WriteLine("enter the X1 and Y1 coordinate");
            double X1 = Convert.ToDouble(Console.ReadLine());
            double Y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the X2 and Y2 coordinate");
            double X2 = Convert.ToDouble(Console.ReadLine());
            double Y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the X3 and Y3 coordinate");
            double X3 = Convert.ToDouble(Console.ReadLine());
            double Y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the X4 and Y4 coordinate");
            double X4 = Convert.ToDouble(Console.ReadLine());
            double Y4 = Convert.ToDouble(Console.ReadLine());


            double LengthFirstLine = Math.Sqrt((Math.Pow((X2 - X1), 2)) + (Math.Pow((Y2 - Y1), 2)));
            Console.WriteLine("the lenght of First line: " + LengthFirstLine);

            double LengthSecondLine = Math.Sqrt((Math.Pow((X4 - X3), 2)) + (Math.Pow((Y4 - Y3), 2)));
            Console.WriteLine("the lenght of Second line: " + LengthSecondLine);

            int status = (LengthFirstLine.CompareTo(LengthSecondLine));
            if (status > 0)
                Console.WriteLine(" Length of first line :{0} is greater then Length of second line : {1}", LengthFirstLine, LengthSecondLine);
            else if (status < 0)
                Console.WriteLine(" Length of first line : {0} is less then Length of second line : {1}", LengthFirstLine, LengthSecondLine);
            else
                Console.WriteLine(" Length of first line : {0} is equal to Length of second line : {1}", LengthFirstLine, LengthSecondLine);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class MethodSet
    {
        public static void DisplayCurrentTime()
        {
            Console.WriteLine("Current Time: " + DateTime.Now.ToShortTimeString());
        }

        public static void DisplayCurrentDate()
        {
            Console.WriteLine("Current Date: " + DateTime.Now.ToShortDateString());
        }

        public static void DisplayCurrentDayOfWeek()
        {
            Console.WriteLine("Current Day of the Week: " + DateTime.Now.DayOfWeek);
        }

        public static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }
    }
}

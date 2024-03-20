namespace Delegates
{
    internal class Program
    {
        static void Main()
        {
            Action displayTime = MethodSet.DisplayCurrentTime;
            Action displayDate = MethodSet.DisplayCurrentDate;
            Action displayDayOfWeek = MethodSet.DisplayCurrentDayOfWeek;

            Func<double, double, double> calculateTriangleArea = MethodSet.CalculateTriangleArea;
            Func<double, double, double> calculateRectangleArea = MethodSet.CalculateRectangleArea;

            displayTime();
            displayDate();
            displayDayOfWeek();

            double triangleArea = calculateTriangleArea(5, 8);
            double rectangleArea = calculateRectangleArea(4, 12);

            Console.WriteLine("Area of Triangle: " + triangleArea);
            Console.WriteLine("Area of Rectangle: " + rectangleArea);
        }
    }
}

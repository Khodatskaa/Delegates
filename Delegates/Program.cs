namespace Delegates
{
    internal class Program
    {
        public static void Main()
        {
            Func<double, double, double> addDelegate = ArithmeticOperations.Add;
            Func<double, double, double> subtractDelegate = ArithmeticOperations.Subtract;
            Func<double, double, double> multiplyDelegate = ArithmeticOperations.Multiply;

            double operand1 = 10;
            double operand2 = 5;

            double additionResult = addDelegate.Invoke(operand1, operand2);
            Console.WriteLine($"Addition: {operand1} + {operand2} = {additionResult}");

            double subtractionResult = subtractDelegate.Invoke(operand1, operand2);
            Console.WriteLine($"Subtraction: {operand1} - {operand2} = {subtractionResult}");

            double multiplicationResult = multiplyDelegate.Invoke(operand1, operand2);
            Console.WriteLine($"Multiplication: {operand1} * {operand2} = {multiplicationResult}");
        }
    }
}

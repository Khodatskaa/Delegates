namespace Delegates
{
    internal class Program
    {
        static void Main()
        {
            ArithmeticOperation addDelegate = new ArithmeticOperation(ArithmeticOperations.Add);
            ArithmeticOperation subtractDelegate = new ArithmeticOperation(ArithmeticOperations.Subtract);
            ArithmeticOperation multiplyDelegate = new ArithmeticOperation(ArithmeticOperations.Multiply);

            double operand1 = 10;
            double operand2 = 5;

            Console.WriteLine($"Addition: {operand1} + {operand2} = {addDelegate(operand1, operand2)}");
            Console.WriteLine($"Subtraction: {operand1} - {operand2} = {subtractDelegate(operand1, operand2)}");
            Console.WriteLine($"Multiplication: {operand1} * {operand2} = {multiplyDelegate(operand1, operand2)}");
        }
    }
}

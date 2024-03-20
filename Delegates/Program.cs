namespace Delegates
{
    internal class Program
    {
        static void Main()
        {
            int number1 = 10;
            int number2 = 13;
            int number3 = 17;
            int number4 = 21;

            Predicate<int> evenPredicate = new Predicate<int>(ArithmeticOperations.IsEven);
            Predicate<int> oddPredicate = new Predicate<int>(ArithmeticOperations.IsOdd);
            Predicate<int> primePredicate = new Predicate<int>(ArithmeticOperations.IsPrime);
            Predicate<int> fibonacciPredicate = new Predicate<int>(ArithmeticOperations.IsFibonacci);

            Console.WriteLine($"Number {number1} is even: {evenPredicate(number1)}");
            Console.WriteLine($"Number {number2} is odd: {oddPredicate(number2)}");
            Console.WriteLine($"Number {number3} is prime: {primePredicate(number3)}");
            Console.WriteLine($"Number {number4} is a Fibonacci number: {fibonacciPredicate(number4)}");
        }
    }
}

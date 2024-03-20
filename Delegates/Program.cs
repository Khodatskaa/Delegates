namespace Delegates
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Even Numbers:");
            List<int> evenNumbers = ArrayHelper.FilterArray(numbers, ArrayHelper.IsEven);
            foreach (int num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nOdd Numbers:");
            List<int> oddNumbers = ArrayHelper.FilterArray(numbers, ArrayHelper.IsOdd);
            foreach (int num in oddNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nPrime Numbers:");
            List<int> primeNumbers = ArrayHelper.FilterArray(numbers, ArrayHelper.IsPrime);
            foreach (int num in primeNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nFibonacci Numbers:");
            List<int> fibonacciNumbers = ArrayHelper.GetFibonacciNumbers(10); 
            foreach (int num in fibonacciNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}

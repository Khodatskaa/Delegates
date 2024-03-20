using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class ArithmeticOperations
    {
        // check if a number is even
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Predicate to check if a number is odd
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        // check if a number is prime
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        // check if a number is a Fibonacci number
        public static bool IsFibonacci(int number)
        {
            int a = 0, b = 1;
            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b == number;
        }
    }
}

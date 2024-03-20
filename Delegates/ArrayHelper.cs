using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate bool FilterDelegate(int num);

    public class ArrayHelper
    {
        public static List<int> FilterArray(int[] arr, FilterDelegate filter)
        {
            List<int> result = new List<int>();
            foreach (int num in arr)
            {
                if (filter(num))
                {
                    result.Add(num);
                }
            }
            return result;
        }

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        public static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;
            if (num == 2)
                return true;
            if (num % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public static List<int> GetFibonacciNumbers(int count)
        {
            List<int> fibNumbers = new List<int>();
            int a = 0, b = 1;
            fibNumbers.Add(a);
            fibNumbers.Add(b);
            for (int i = 2; i < count; i++)
            {
                int c = a + b;
                fibNumbers.Add(c);
                a = b;
                b = c;
            }
            return fibNumbers;
        }
    }
}

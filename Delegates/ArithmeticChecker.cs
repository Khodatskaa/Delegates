using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class ArithmeticChecker
    {
        private Predicate<int> checkPredicate;

        public ArithmeticChecker(ArithmeticOperation operation)
        {
            switch (operation)
            {
                case ArithmeticOperation.Even:
                    checkPredicate = ArithmeticOperations.IsEven;
                    break;
                case ArithmeticOperation.Odd:
                    checkPredicate = ArithmeticOperations.IsOdd;
                    break;
                case ArithmeticOperation.Prime:
                    checkPredicate = ArithmeticOperations.IsPrime;
                    break;
                case ArithmeticOperation.Fibonacci:
                    checkPredicate = ArithmeticOperations.IsFibonacci;
                    break;
                default:
                    throw new ArgumentException("Invalid arithmetic operation.");
            }
        }

        public bool Check(int number)
        {
            return checkPredicate(number);
        }
    }
}

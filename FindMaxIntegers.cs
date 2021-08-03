using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumGenerics
{
    class Maximum
    {
        public static void GetMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
                Console.WriteLine(firstNumber + ", Is the max value.");
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
                Console.WriteLine(secondNumber + ", Is the max value.");
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
                Console.WriteLine(thirdNumber + ", Is the max value.");
        }
    }
}
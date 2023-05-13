using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evensSum = numbers.Where(e => e % 2 == 0).Sum();
            var oddSum = numbers.Where(o => o % 2 != 0).Sum();
            return evensSum - oddSum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var stringList = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return stringList.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numList = new List<int> { number1, number2, number3, number4 };
            return numList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 > sideLength3 &&
               sideLength2 + sideLength3 > sideLength1 &&
               sideLength3 + sideLength1 > sideLength2)
            { return true; }
            return false;
        }   

        public bool IsStringANumber(string input)
        {
            var number = double.TryParse(input, out double num);
            return number;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var majority = (objs.Count() / 2) + 1;
            var nullCount = 0;
            foreach (var o in objs)
            {
                if (o == null) { nullCount++; }
            }
            if (nullCount >= majority) { return true; }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0) { return 0; }
            var evens = numbers.Where(e => e % 2 == 0);
            if(evens.Count() == 0) { return 0; }
            return evens.Average();
        }

        public int Factorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}

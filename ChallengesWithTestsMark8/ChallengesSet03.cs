using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }
            if (vals.Contains(false))
            {
                return true;
            }
            return false;
        }
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            var odds = new List<int>();
            foreach(int num in numbers)
            {
                if(num % 2 != 0)
                {
                    odds.Add(num);
                }
            }
            var oddSum = odds.Sum();
            if(oddSum % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isUpper = false;
            var isLower = false;
            var isNumber = false;

            foreach(char letter in password)
            {
                if (char.IsUpper(letter))
                {
                    isUpper = true;
                }

                if (char.IsLower(letter))
                {
                    isLower = true;
                }
                if (char.IsNumber(letter))
                {
                    isNumber = true;
                }
            }
            if(isUpper && isLower && isNumber == true)
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var oddList = new List<int>();

            for(int n = 0; n < 100; n++)
            {
                if(n % 2 != 0)
                {
                    oddList.Add(n);
                }
            } 
            return oddList.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}

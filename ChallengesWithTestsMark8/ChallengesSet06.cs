using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if(words == null || string.IsNullOrEmpty(word))
            {
                return false;
            }

            StringComparison comparison = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;

            foreach (string item in words)
            {
                if(string.Equals(item, word, comparison))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if(num <= 1) { return false; }

            if(num == 2) { return true; }

            if(num % 2 == 0) { return false; }

            for(int i = 3; i * i <= num; i += 2)
            {
                if(num % i == 0) { return false; }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            for(int i = str.Length - 1; i >= 0; i--)
            {
                char currentChar = str[i];
                if(charFrequency.ContainsKey(currentChar))
                {
                    charFrequency[currentChar]++;
                }
                else
                {
                    charFrequency[currentChar] = 1;
                }
            }

            for(int i = str.Length - 1; i >= 0; i--)
            {
                char currentChar = str[i];
                if (charFrequency[currentChar] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int maxCount = 1;
            int currentCount = 1;
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if(currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if(elements == null || elements.Count == 0 || n <= 0)
            {
                return new double[0];
            }

            List<double> result = new List<double>();
            for(int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}

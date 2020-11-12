using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //throw new NotImplementedException();
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //throw new NotImplementedException();
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
           // throw new NotImplementedException();
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            //throw new NotImplementedException();
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
           // throw new NotImplementedException();
           if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            double minValue = 10000.00;
            double maxValue = 0;
            foreach (double dub in numbers.ToList())
            {
                if (dub < minValue)
                {
                    minValue = dub;
                }
                if (dub > maxValue)
                {
                    maxValue = dub;
                }
            }
            return minValue + maxValue;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //throw new NotImplementedException();;

            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null)
            {
                return 0;
            }

            int sum = numbers.Sum();
            return sum;
            
        }

        public int SumEvens(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null)
            {
                return 0;
            }
            int sumOfEvens = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sumOfEvens += i;
                }
            }
                return sumOfEvens;            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            // throw new NotImplementedException();
            if (numbers == null)
            {
                return false;
            }

            int sum = Sum(numbers.ToArray());
            if (sum % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            // throw new NotImplementedException();
            int oddsCounter = 0;
            for (int i=0; i<number; i++)
            {
                if (i % 2 !=0)
                {
                    oddsCounter++;
                }
            }
            return oddsCounter;
        }
    }
}

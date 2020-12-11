using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            //throw new NotImplementedException();
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            //throw new NotImplementedException();
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue <= 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null || numbers.Length == 0) return false;
            int previousNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < previousNumber)
                {
                    return false;
                }
                previousNumber = numbers[i];
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}

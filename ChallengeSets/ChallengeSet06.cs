using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public bool IsPrimeNumber(int num)
        {
            //throw new NotImplementedException();
             if (num == 2)
             {
                return true;

             }

            else if (num % 2 == 0 || num <= 1)
            {
                return false;
            }
          
            else
            {
                return true;
            }
                
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}

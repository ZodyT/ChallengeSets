using System;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //throw new NotImplementedException();
            int result = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    result += i;
                }

                else
                {
                    result -= i;
                }
            }
            return result;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //throw new NotImplementedException();
            string[] myArray = {str1, str2, str3, str4};
            //int Size=0;

            //foreach (string word in myArray)
            //{
            //    Size = word.Length;

            //    if (Size < word.Length)
            //    {
            //        Size = word.Length;
            //    }
            //}
            //return Size;

            int minvalue = 99999999;
            foreach (string word in myArray)
            {
                if (word.Length < minvalue)
                {
                    minvalue = word.Length;
                }
            }
            return minvalue;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //throw new NotImplementedException();
            int[] numbers = {number1, number2, number3, number4};
         
            return numbers.Min();   
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}

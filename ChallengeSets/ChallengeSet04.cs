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
            //throw new NotImplementedException();
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //throw new NotImplementedException();

            if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1)
                return false;
            else
                return true;


        }

        public bool IsStringANumber(string input)
        {
            //throw new NotImplementedException();

            if (double.TryParse(input, out double value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //throw new NotImplementedException();
            int itemCount = objs.Length;
            int nullCount = 0;
            foreach (object obj in objs)
            {
                if (obj == null) nullCount++;
            }
            if (nullCount > itemCount / 2)
            {
                return true;
            }
            return false;

        }

        public double AverageEvens(int[] numbers)
        {
            //throw new NotImplementedException();
            //int[] evens;

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        evens.Add();
            //    }
            //}

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int evenSum = 0;
            int evenCount = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                    evenCount++;
                }
            }
            if (evenCount == 0)
            {
                return 0;
            }
            return (double)evenSum / evenCount;

        }

        public int Factorial(int number)
        {
            //throw new NotImplementedException();
            if (number < 0) throw new ArgumentOutOfRangeException();

            if (number == 0)
            {
                return 1;
            }

            int result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}

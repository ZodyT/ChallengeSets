﻿using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();
           // for (int i = 0; i < password.Length; i++)
           // {
           //     if (password.Any(string.IsDigit) && password.IsUpper() && password.IsLower())
            //    {
            //        return true;
             //   }
             //   else
             //   {
             //       return false;
             //   }
           // }
        }

        public char GetFirstLetterOfString(string val)
        {
            //throw new NotImplementedException();
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {

            //throw new NotImplementedException();
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            // throw new NotImplementedException();
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }
        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}

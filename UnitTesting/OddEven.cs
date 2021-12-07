using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
   public static class OddEven
   {
        public static int[] GenerateNumbers(int start, int end, int length)
        {
            int[] result = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = rnd.Next(start, end);           
            }
            return result;
        }

        public static bool IsEven(int number)
        {
            bool result = number % 2 == 0 ? true : false;
            return result;
        }

        public static bool IsOdd(int number)
        {
            bool result = number % 2 != 0 && number % number != 0 ? true : false;
            return result;
        }

        public static bool IsPrime(int number)
        {
            bool result = IsEven(number) && IsOdd(number) ? false : true;
            return result;
        }

    }

}

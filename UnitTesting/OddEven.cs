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
    }

}

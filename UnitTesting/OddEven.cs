using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
   public static class OddEven
    {
        public static int[] GenerateHundredNumbers(int start, int end)
        {
            int[] result = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = rnd.Next(start, end);           
            }
            return result;
        }
    }
}

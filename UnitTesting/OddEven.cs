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
            bool result = number % 2 == 0  && number !=0 ? true : false;
            return result;
        }

        public static bool IsOdd(int number)
        {
            bool result = number % 2 != 0 && !IsPrime(number) ? true : false;
            return result;
        }

        public static bool IsPrime(int number)
        {
            bool result = true;
            if (number == 0 || number == 1)
            {
                result = false;
            }
            else
            {
                for (int i = 2; i <= number / 2; ++i)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }

        public static string  GetNumberType(int number)
        { 
           return _ = IsPrime(number) ? "Prime" : IsOdd(number) ? "Odd" : "Even";  
        }

        public static void PrintNumbers( int[]numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{ numbers[i]} - {GetNumberType(numbers[i])}");
            }
        }

    }

}

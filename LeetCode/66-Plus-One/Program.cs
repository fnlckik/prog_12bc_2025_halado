using System;
using System.Collections.Generic;

namespace _66_Plus_One
{
    internal class Program
    {
        static int[] PlusOne(int[] digits)
        {
            List<int> result = new List<int>();
            bool inc = true;
            for (int i = digits.Length-1; i >= 0; i--)
            {
                if (inc && digits[i] == 9)
                {
                    result.Add(0);
                }
                else if (inc && digits[i] != 9)
                {
                    result.Add(digits[i] + 1);
                    inc = false;
                }
                else
                {
                    result.Add(digits[i]);
                }
            }
            if (inc) result.Add(1);
            result.Reverse();
            return result.ToArray();
        }

        static void Main(string[] args)
        {
            int[] result = PlusOne(new int[] { 7, 2, 9, 9 });
            // 7 2 9 9
            WriteArray(result); // 7300
        }

        private static void WriteArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}

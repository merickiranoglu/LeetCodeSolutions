using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class FindNumbersWithEvenNumberOfDigits
    {
        public static int FindNumbers(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var num = (float)nums[i] / 10;
                int oddEvenCounter = 0;
                while (num > 1)
                {
                    num /= 10;
                    oddEvenCounter++;
                }
                if (oddEvenCounter % 2 == 1)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}

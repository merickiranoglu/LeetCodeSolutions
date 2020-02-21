using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class TwoSumSolution
    {

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var remainingValue = target - nums[i];

                if (nums.Contains(remainingValue))
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] == remainingValue) { return new[] { i, j }; }
                    }
                }
            }
            return null;
        }
    }

  

   

}

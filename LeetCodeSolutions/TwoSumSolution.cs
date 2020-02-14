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
            int[] solution = { 0, 0 };

            for (int i = 0; i < nums.Length; i++)
            {
                solution[0] = nums[i];

                if (solution[0] > 9) { continue; }

                var remainingValue = target - solution[0];
                if (nums.Contains(remainingValue))
                {
                    //solution[1] = remainingValue;
                    var j = Array.IndexOf(nums, remainingValue);
                    int[] indices = { i, j };
                    return indices;
                }
                else { continue; }
            }
            return solution;
        }
    }

}

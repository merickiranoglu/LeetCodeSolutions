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

                for (int j = 0; j < nums.Length; j++)
                {
                    solution[1] = nums[j];

                    if (solution[0] == solution[1]) { continue; }

                    if (solution[0] + solution[1] == 9)
                    {
                        int[] indices = { i, j };
                        return indices;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return solution;
        }
    }

}

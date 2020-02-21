using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class NumberOfStepsToReduceANumberToZero
    {
        public static int GetNumberOfSteps(int num)
        {
            int calculationCounter = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num--;
                }
                calculationCounter++;
            }
            return calculationCounter;
        }
    }
}

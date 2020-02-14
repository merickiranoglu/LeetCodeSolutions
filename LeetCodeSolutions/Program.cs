using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class Program
    {
        enum eSolutions
        {
            TwoSum = 0
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This environment is created to check LeetCode solutions.");

            Console.WriteLine("Select Solution to Test:");

            for (int i = 0; i < Enum.GetNames(typeof(eSolutions)).Length; i++)
            {
                Console.WriteLine(i.ToString() + " : " + (eSolutions)i);
            }

            int selection = Convert.ToInt32(Console.ReadLine());
            var solution = (eSolutions) selection;


            switch (solution)
            {
                case eSolutions.TwoSum:
                    TestTwoSum();
                    break;
                default:
                    break;
            }


        }

        private static void TestTwoSum()
        {
            Console.WriteLine("Test of Two Sum Solution is started.");
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            string testArray = "Test Array: {";
            for (int i = 0; i < nums.Length-1 ; i++)
            {
                testArray += nums[i] + ",";
            }
            testArray += nums[nums.Length - 1] + "}";

            Console.WriteLine(testArray);
            Console.WriteLine("Target value: " + target.ToString());

            var result = TwoSumSolution.TwoSum(nums, target);
            Console.WriteLine("Result: Indices of the values are; {" + result[0].ToString() + "," + result[1].ToString() + "}");
            Console.ReadLine();
        }
    }
}



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
            TwoSum = 0,
            NumberOfStepsToReduceANumberToZero = 1,
            FindNumbersWithEvenNumberOfDigits = 2

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
                case eSolutions.NumberOfStepsToReduceANumberToZero:
                    TestNumberOfStepsToReduceANumberToZero();
                    break;
                case eSolutions.FindNumbersWithEvenNumberOfDigits:
                    TestFindNumbersWithEvenNumbersOfDigits();
                    break;
                default:
                    break;
            }


        }

        private static void TestTwoSum()
        {
            Console.WriteLine("Test of 'Two Sum' Solution is started.");
            int[] nums = { 3, 3 };
            int target = 6;

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

        private static void TestNumberOfStepsToReduceANumberToZero()
        {
            Console.WriteLine("Test of 'Number Of Steps To Reduce A Number To Zero' started.");
            int num = 19;
            Console.WriteLine("Num: " + num.ToString());

            var result = NumberOfStepsToReduceANumberToZero.GetNumberOfSteps(num);
            Console.WriteLine("Result: " + result.ToString());
            Console.ReadLine();
        }

        private static void TestFindNumbersWithEvenNumbersOfDigits()
        {
            Console.WriteLine("Test of 'Find Numbers With Even Numbers Of Digits' Solution is started.");
            int[] nums = { 315, 13, 888, 4444, 22, 1111, 4446 };

            string testArray = "Test Array: {";
            for (int i = 0; i < nums.Length - 1; i++)
            {
                testArray += nums[i] + ",";
            }
            testArray += nums[nums.Length - 1] + "}";

            Console.WriteLine(testArray);

            var result = FindNumbersWithEvenNumberOfDigits.FindNumbers(nums);
            Console.WriteLine("Result: " + result.ToString());
            Console.ReadLine();
        }
    }
}



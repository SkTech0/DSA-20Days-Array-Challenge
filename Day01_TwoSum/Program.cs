
using System;
using System.Collections.Generic;

namespace DSA.ArrayChallenges
{
    class Day01_TwoSum
    {
        /*
         Problem: Two Sum
        Description:
           Given an array of integers nums and an integer target,
           return indices of the two numbers such that they add up to target.

         Constraints:
            - Each input would have exactly one solution.
            - You may not use the same element twice.

         Approach:
            - Use a Dictionary to store previously seen numbers.

         Time Complexity: O(n)
         Space Complexity: O(n)

         Input: nums = [2, 7, 11, 15], target = 9
         Output: [0, 1]
        */

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                if (!map.ContainsKey(nums[i]))
                    map[nums[i]] = i;
            }
            return new int[] { };
        }

        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            var result = TwoSum(nums, target);
            Console.WriteLine($"Output: [{string.Join(", ", result)}]");
        }
    }
}

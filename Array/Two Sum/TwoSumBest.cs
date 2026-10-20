
using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> mp = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];

            if (mp.ContainsKey(diff))
            {
                return new int[] { mp[diff], i };
            }

            mp.TryAdd(nums[i], i);
        }

        return new int[] { };
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Test Case 1
        int[] nums1 = { 2, 7, 11, 15 };
        int target1 = 9;
        PrintResult("Test Case 1", solution.TwoSum(nums1, target1));

        // Test Case 2
        int[] nums2 = { 3, 2, 4 };
        int target2 = 6;
        PrintResult("Test Case 2", solution.TwoSum(nums2, target2));

        // Test Case 3: Duplicate numbers
        int[] nums3 = { 3, 3 };
        int target3 = 6;
        PrintResult("Test Case 3", solution.TwoSum(nums3, target3));

        // Test Case 4: Zeroes
        int[] nums4 = { 0, 4, 3, 0 };
        int target4 = 0;
        PrintResult("Test Case 4", solution.TwoSum(nums4, target4));
    }

    public static void PrintResult(string testName, int[] result)
    {
        Console.WriteLine($"{testName}: [{string.Join(", ", result)}]");
    }
}

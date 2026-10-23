
using System;
using System.Collections.Generic;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, int> mp = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (mp.ContainsKey(nums[i]))
            {
                return true;
            }

            mp.Add(nums[i], i);
        }

        return false;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Test case 1: Contains duplicates
        int[] nums1 = { 1, 2, 3, 1 };
        Console.WriteLine($"Test 1: {solution.ContainsDuplicate(nums1)}");

        // Test case 2: No duplicates
        int[] nums2 = { 1, 2, 3, 4 };
        Console.WriteLine($"Test 2: {solution.ContainsDuplicate(nums2)}");

        // Test case 3: Multiple duplicates
        int[] nums3 = { 1, 1, 2, 2, 3 };
        Console.WriteLine($"Test 3: {solution.ContainsDuplicate(nums3)}");

        // Test case 4: Empty array
        int[] nums4 = { };
        Console.WriteLine($"Test 4: {solution.ContainsDuplicate(nums4)}");

        // Test case 5: Single element
        int[] nums5 = { 5 };
        Console.WriteLine($"Test 5: {solution.ContainsDuplicate(nums5)}");
    }
}

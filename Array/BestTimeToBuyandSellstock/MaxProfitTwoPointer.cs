
using System;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int left = 0;
        int right = 1;
        int maxProfit = 0;

        while (right < prices.Length)
        {
            if (prices[left] < prices[right])
            {
                int profit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit, profit);
            }
            else
            {
                left = right;
            }

            right = right + 1;
        }

        return maxProfit;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Test Case 1
        int[] prices1 = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine(
            $"Test Case 1: {solution.MaxProfit(prices1)}");

        // Test Case 2
        int[] prices2 = { 7, 6, 4, 3, 1 };
        Console.WriteLine(
            $"Test Case 2: {solution.MaxProfit(prices2)}");

        // Test Case 3
        int[] prices3 = { 1, 2 };
        Console.WriteLine(
            $"Test Case 3: {solution.MaxProfit(prices3)}");

        // Test Case 4
        int[] prices4 = { 2, 4, 1 };
        Console.WriteLine(
            $"Test Case 4: {solution.MaxProfit(prices4)}");

        // Test Case 5
        int[] prices5 = { 3 };
        Console.WriteLine(
            $"Test Case 5: {solution.MaxProfit(prices5)}");
    }
}

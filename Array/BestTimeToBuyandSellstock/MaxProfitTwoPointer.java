
import java.util.Arrays;

class Solution {
    public int maxProfit(int[] prices) {
        int left = 0;
        int right = 1;
        int maxProfit = 0;

        while (right < prices.length) {
            if (prices[left] < prices[right]) {
                int profit = prices[right] - prices[left];
                maxProfit = Math.max(maxProfit, profit);
            } else {
                left = right;
            }

            right = right + 1;
        }

        return maxProfit;
    }
}

public class MaxProfit {
    public static void main(String[] args) {
        Solution solution = new Solution();

        // Test Case 1
        int[] prices1 = {7, 1, 5, 3, 6, 4};
        System.out.println("Test Case 1: "
                + solution.maxProfit(prices1));

        // Test Case 2
        int[] prices2 = {7, 6, 4, 3, 1};
        System.out.println("Test Case 2: "
                + solution.maxProfit(prices2));

        // Test Case 3
        int[] prices3 = {1, 2};
        System.out.println("Test Case 3: "
                + solution.maxProfit(prices3));

        // Test Case 4
        int[] prices4 = {2, 4, 1};
        System.out.println("Test Case 4: "
                + solution.maxProfit(prices4));

        // Test Case 5
        int[] prices5 = {3};
        System.out.println("Test Case 5: "
                + solution.maxProfit(prices5));
    }
}

import java.util.Map;
import java.util.HashMap;

class Solution {
    public boolean containsDuplicate(int[] nums) {
        Map<Integer, Integer> mp = new HashMap<>();

        for (int i = 0; i < nums.length; i++) {
            if (mp.containsKey(nums[i])) {
                return true;
            }
            mp.put(nums[i], i);
        }

        return false;
    }
}

public class ContainsDuplicate {
    public static void main(String[] args) {
        Solution solution = new Solution();

        // Test case 1: Contains duplicates
        int[] nums1 = {1, 2, 3, 1};
        System.out.println("Test 1: " + solution.containsDuplicate(nums1));

        // Test case 2: No duplicates
        int[] nums2 = {1, 2, 3, 4};
        System.out.println("Test 2: " + solution.containsDuplicate(nums2));

        // Test case 3: Multiple duplicates
        int[] nums3 = {1, 1, 2, 2, 3};
        System.out.println("Test 3: " + solution.containsDuplicate(nums3));

        // Test case 4: Empty array
        int[] nums4 = {};
        System.out.println("Test 4: " + solution.containsDuplicate(nums4));

        // Test case 5: Single element
        int[] nums5 = {5};
        System.out.println("Test 5: " + solution.containsDuplicate(nums5));
    }
}
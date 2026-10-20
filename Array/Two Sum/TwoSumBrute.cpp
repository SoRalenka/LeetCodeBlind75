
#include <iostream>
#include <vector>
using namespace std;

class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        int n = nums.size();

        for (int i = 0; i < n; i++) {
            int diff = target - nums[i];

            for (int j = i + 1; j < n; j++) {
                if (nums[j] == diff) {
                    return {i, j};
                }
            }
        }

        return {};
    }
};

int main() {
    Solution solution;

    // Test Case 1
    vector<int> nums1 = {2, 7, 11, 15};
    int target1 = 9;

    vector<int> result1 = solution.twoSum(nums1, target1);

    cout << "Test Case 1: ";
    if (!result1.empty()) {
        cout << "[" << result1[0] << ", " << result1[1] << "]\n";
    } else {
        cout << "No solution found\n";
    }

    // Test Case 2
    vector<int> nums2 = {3, 2, 4};
    int target2 = 6;

    vector<int> result2 = solution.twoSum(nums2, target2);

    cout << "Test Case 2: ";
    if (!result2.empty()) {
        cout << "[" << result2[0] << ", " << result2[1] << "]\n";
    } else {
        cout << "No solution found\n";
    }


    return 0;
}

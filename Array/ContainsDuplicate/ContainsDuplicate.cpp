#include <iostream>
#include <vector>
#include <unordered_map>
using namespace std;

class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
        unordered_map<int, int> mp;

        for (auto i : nums) {
            if (mp.find(i) != mp.end()) {
                return true;
            }
            mp[i]++;
        }

        return false;
    }
};

int main() {
    Solution solution;

    // Test case 1: Contains duplicates
    vector<int> nums1 = {1, 2, 3, 1};
    cout << boolalpha;
    cout << "Test 1: "
         << solution.containsDuplicate(nums1) << endl;

    // Test case 2: No duplicates
    vector<int> nums2 = {1, 2, 3, 4};
    cout << "Test 2: "
         << solution.containsDuplicate(nums2) << endl;

    // Test case 3: Multiple duplicates
    vector<int> nums3 = {1, 1, 2, 2, 3};
    cout << "Test 3: "
         << solution.containsDuplicate(nums3) << endl;

    // Test case 4: Empty array
    vector<int> nums4 = {};
    cout << "Test 4: "
         << solution.containsDuplicate(nums4) << endl;

    return 0;
}
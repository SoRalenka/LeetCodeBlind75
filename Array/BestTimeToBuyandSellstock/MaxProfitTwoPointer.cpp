
#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int left = 0;
        int right = 1;
        int maxProfit = 0;

        while (right < prices.size()) {
            if (prices[left] < prices[right]) {
                int profit = prices[right] - prices[left];
                maxProfit = max(maxProfit, profit);
            }
            else {
                left = right;
            }

            right = right + 1;
        }

        return maxProfit;
    }
};

int main() {
    Solution solution;

    // Test Case 1
    vector<int> prices1 = {7, 1, 5, 3, 6, 4};
    cout << "Test Case 1: "
         << solution.maxProfit(prices1) << endl;

    // Test Case 2
    vector<int> prices2 = {7, 6, 4, 3, 1};
    cout << "Test Case 2: "
         << solution.maxProfit(prices2) << endl;

    // Test Case 3
    vector<int> prices3 = {1, 2};
    cout << "Test Case 3: "
         << solution.maxProfit(prices3) << endl;

    // Test Case 4
    vector<int> prices4 = {2, 4, 1};
    cout << "Test Case 4: "
         << solution.maxProfit(prices4) << endl;

    // Test Case 5
    vector<int> prices5 = {3};
    cout << "Test Case 5: "
         << solution.maxProfit(prices5) << endl;

    return 0;
}

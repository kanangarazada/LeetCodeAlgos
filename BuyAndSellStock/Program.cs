//LeetCode 121
//You are given an array prices where prices[i] is the price of a given stock on the ith day.
//You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
static int MaxProfit(int[] prices)
{
    //left buy, right sell
    int left = 0;
    int right = 1;
    int maxProfit = 0;

    while(right < prices.Length)
    {
        int profit = 0;
        if (prices[left] < prices[right])
        {
            profit = prices[right] - prices[left];
            maxProfit = Math.Max(maxProfit, profit);
        }
        else
        {
            //if it is not profitable, 
            left = right;
        }
        right++;
    }

    return maxProfit;
}
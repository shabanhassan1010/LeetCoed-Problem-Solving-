public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int maxProfit = 0 ; // Initialize maxProfit to 0, as initially, no transactions have been made
        int minPrice = prices[0];  // Set minPrice to the price of the stock on the first day.
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else
            {
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }
        }
        return maxProfit;
    }
}
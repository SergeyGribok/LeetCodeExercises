namespace LeetCodeExercises;
/*
You are given an array prices where prices[i] is the price of a given stock on the ith day.
You want to maximize your profit by choosing a single day to buy one stock 
and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. 
If you cannot achieve any profit, return 0.

Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
 */
internal class _121_Best_Time__to_Buy_and_Sell_Stock
{
    public static int MaxProfit(int[] prices)
    {
        if (prices.Length == 0) return 0;

        int minPrice = prices[0];
        int currentProfit;
        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else
            {
                currentProfit = prices[i] - minPrice;
                if (currentProfit > maxProfit)
                    maxProfit = currentProfit;
            }
        }
        return maxProfit;
    }
    public static int MaxProfit_FirstTry_NotWorkingCOrrectly(int[] prices)
    {
        if (prices.Length == 0) return 0;

        int minPriceBuy = prices[0];
        int minPriceBuyIndex = 0;
        int maxPriceSell = 0;
        int maxPriceSellIndex = 0;
        int profit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPriceBuy)
            {
                minPriceBuy = prices[i];
                minPriceBuyIndex = i;
            }
            if (prices[i] > minPriceBuy && i > minPriceBuyIndex)
            {
                maxPriceSell = prices[i];
                maxPriceSellIndex = i;
            }

            if (maxPriceSell - minPriceBuy > profit)
                profit = maxPriceSell - minPriceBuy;
        }
        return profit;
    }
    public static void RunSolution(int[] prices)
    {
        Console.WriteLine("=======_121_Best_Time__to_Buy_and_Sell_Stock=========");
        prices.PrintArray("Prices:");
        var result = MaxProfit(prices);
        Console.WriteLine("Profit = " + result);
        Console.WriteLine(new string('=', 60));
    }
}

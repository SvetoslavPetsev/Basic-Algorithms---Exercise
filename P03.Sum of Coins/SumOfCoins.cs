using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {
        var availableCoins = new int[] { 1, 2, 5, 10, 20, 50 };
        var targetSum = 923;

        var selectedCoins = ChooseCoins(availableCoins, targetSum);

        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        var collection = new Dictionary<int, int>();
        coins = coins.OrderByDescending(x => x).ToList();
        foreach (var coin in coins)
        {
            int coinsToCollect = targetSum / coin;
            if (coinsToCollect > 0)
            {
                collection.Add(coin, coinsToCollect);
                targetSum %= coin * coinsToCollect;

                if (targetSum == 0)
                {
                    break;
                }

            }
        }

        if (targetSum > 0)
        {
            throw new InvalidOperationException();
        }

        return collection;
    }
}
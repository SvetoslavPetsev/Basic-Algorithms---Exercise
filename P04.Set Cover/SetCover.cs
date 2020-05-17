using System;
using System.Collections.Generic;
using System.Linq;

public class SetCover
{
    public static void Main(string[] args)
    {
        int[] universe = new[] { 1, 3, 5, 7, 9, 11, 20, 30, 40 };
        int[][] sets = new[]
        {
                new[] { 20 },
                new[] { 1, 5, 20, 30 },
                new[] { 3, 7, 20, 30, 40 },
                new[] { 9, 30 },
                new[] { 11, 20, 30, 40 },
                new[] { 3, 7, 40 }
            };

        List<int[]> selectedSets = ChooseSets(sets.ToList(), universe.ToList());
        Console.WriteLine($"Sets to take ({selectedSets.Count}):");

        foreach (int[] set in selectedSets)
        {
            Console.WriteLine($"{{ {string.Join(", ", set)} }}");
        }
    }

    public static List<int[]> ChooseSets(List<int[]> sets, List<int> universe)
    {
        var list = new List<int[]>();
        while (universe.Any())
        {
            int mostEqual = 0;
            int[] mostEqualSet = null;
           
            for (int i = 0; i < sets.Count; i++)
            {
                var currentSet = sets[i];
                int countEqual = 0;
                
                if (currentSet.Length <= mostEqual)
                {
                    continue;
                }

                foreach (var item in currentSet)
                {
                    if (universe.Contains(item))
                    {
                        countEqual++;
                    }

                }

                if (countEqual > mostEqual)
                {
                    mostEqual = countEqual;
                    mostEqualSet = currentSet;
                }

            }
            list.Add(mostEqualSet);

            foreach (var item in mostEqualSet)
            {
                if (universe.Contains(item))
                {
                    universe.Remove(item);
                }

            }

            sets.Remove(mostEqualSet);
        }
        return list;
    }
}

namespace puzzle_01;

public static class MyExtensions
{
    public static string[] SplitByElf(this string data)
    {
        return data.Split("\n\n");
    }
    
    // do a simple SplitBySnack
    // the do a ConvertSnackToInt

    public static int[][] SplitBySnack(this string[] data)
    {
        return data.Select(elfData => elfData.Split('\n')
                                                  .Select(snack => int.Parse(snack))
                                                  .ToArray())
                   .ToArray();
    }

    public static int[] ComputeTotalCaloriesByElf(this int[][] data)
    {
        return data.Select(x => x.Sum()).ToArray();
    }

    public static int GetMaximumCalories(this int[] data)
    {
        return data.Max();
    }
}
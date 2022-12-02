namespace puzzle_01;

public static class MyExtensions
{
    public static string[] SplitByElf(this string rawData)
    {
        return rawData.Split("\n\n");
    }
}
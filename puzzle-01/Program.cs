using puzzle_01;

var filePath = "/Users/mario/Perso/repos/advent-of-code-2022/puzzle-01/data-test.txt";
var rawData = File.ReadAllText(filePath);
Console.WriteLine(rawData);
Console.WriteLine("**********");
var result = rawData
    .SplitByElf()
    .SplitBySnack()
    .ComputeTotalCaloriesByElf()
    .GetMaximumCalories();
Console.WriteLine(result);

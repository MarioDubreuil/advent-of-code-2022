using puzzle_01;

var filePath = "/Users/mario/Perso/repos/advent-of-code-2022/puzzle-01/data-real.txt";
var data = File.ReadAllText(filePath);
var expedition = new Expedition(data);
Console.WriteLine($"MaximumCalories: {expedition.MaximumCalories}");
Console.WriteLine($"TotalCaloriesForTop3Elves: {expedition.TotalCaloriesForTop3Elves}");

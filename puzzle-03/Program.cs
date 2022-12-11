using puzzle_03;

var filePath = "/Users/mario/Perso/repos/advent-of-code-2022/puzzle-03/data-real.txt";
var data = File.ReadAllText(filePath);
var journey = new Journey(data);
Console.WriteLine($"SumPriorities: {journey.SumPriorities}");
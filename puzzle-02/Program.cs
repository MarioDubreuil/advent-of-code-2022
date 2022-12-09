using puzzle_02;

var filePath = "/Users/mario/Perso/repos/advent-of-code-2022/puzzle-02/data-real.txt";
var data = File.ReadAllText(filePath);
var tournament = new Tournament(data);
Console.WriteLine($"MyScore: {tournament.MyScore}");

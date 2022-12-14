namespace puzzle_03;

public class Journey
{
    public List<Group> Groups { get; private set; }
    public int SumPriorities { get; private set; }

    public Journey(string data)
    {
        var rucksacks = data.Split('\n');
        Groups = Enumerable.Range(0, rucksacks.Length / 3)
            .Select(i => 3 * i)
            .Select(i => new Group(rucksacks[i], rucksacks[i + 1], rucksacks[i + 2]))
            .ToList();
        SumPriorities = Groups.Select(group => group.Priority).Sum();
    }
}
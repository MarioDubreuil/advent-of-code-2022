namespace puzzle_03;

public class Journey
{
    public List<Rucksack> Rucksacks { get; private set; }

    public int SumPriorities { get; private set; }

    public Journey(string data)
    {
        Rucksacks = data.Split('\n').Select(rucksackData => new Rucksack(rucksackData)).ToList();
        SumPriorities = Rucksacks.Select(rucksack => rucksack.Priority).Sum();
    }
}
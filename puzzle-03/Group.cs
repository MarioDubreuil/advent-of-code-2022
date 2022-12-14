namespace puzzle_03;

public class Group
{
    public string Rucksack1 { get; private set; }
    public string Rucksack2 { get; private set; }
    public string Rucksack3 { get; private set; }
    public char Badge { get; private set; }
    public int Priority { get; private set; }
    
    public Group(string rucksackData1, string rucksackData2, string rucksackData3)
    {
        Rucksack1 = rucksackData1;
        Rucksack2 = rucksackData2;
        Rucksack3 = rucksackData3;
        Badge = Rucksack1.Intersect(Rucksack2).Intersect(Rucksack3).First();
        Priority = char.IsLower(Badge) ? Badge - 'a' + 1 : Badge - 'A' + 26 + 1;
    }
}
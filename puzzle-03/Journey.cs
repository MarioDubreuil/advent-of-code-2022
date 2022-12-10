namespace puzzle_03;

public class Journey
{
    public Rucksack Rucksack { get; private set; }
    public Journey(string data)
    {
        Rucksack = new Rucksack(data);
    }
}
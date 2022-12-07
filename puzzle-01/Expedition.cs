namespace puzzle_01;

public class Expedition
{
    public List<Elf> Elves { get; private set; }

    public int MaximumCalories
    {
        get
        {
            return Elves.Select(elf => elf.TotalCalories).Max();
        }
    }
    
    public Expedition(string data)
    {
        Elves = data.Split("\n\n").Select(elfData => new Elf(elfData)).ToList();
    }
}
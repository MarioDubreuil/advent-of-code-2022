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
    
    public int TotalCaloriesForTop3Elves
    {
        get
        {
            return Elves.Select(elf => elf.TotalCalories).OrderByDescending(totalCalories => totalCalories).Take(3).Sum();
        }
    }
    public Expedition(string data)
    {
        Elves = data.Split("\n\n").Select(elfData => new Elf(elfData)).ToList();
    }
}
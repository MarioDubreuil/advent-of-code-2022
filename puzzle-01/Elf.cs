namespace puzzle_01;

public class Elf
{
    public List<Snack> Snacks { get; private set; }

    public int TotalCalories
    {
        get
        {
            return Snacks.Select(snack => snack.Calories).Sum();
        }
    }

    public Elf(string data)
    {
        Snacks = data.Split('\n').Select(snackData => new Snack(snackData)).ToList();
    }
}
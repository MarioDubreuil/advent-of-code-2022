namespace puzzle_01;

public class Snack
{
    public int Calories { get; private set; }
    
    public Snack(string calories)
    {
        Calories = int.Parse(calories);
    }
}
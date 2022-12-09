namespace puzzle_02;

public class Tournament
{
    public List<Round> Rounds { get; private set; }

    public int MyScore
    {
        get
        {
            return Rounds.Select(r => r.MyScore).Sum();
        }
    }
    
    public Tournament(string data)
    {
        Rounds = data.Split('\n').Select(roundData => new Round(roundData)).ToList();
    }
}
namespace puzzle_02;

public class Round
{
    public char OpponentShape { get; private set; }
    public char MyShape { get; private set; }
    
    public Outcome MyOutcome
    {
        get
        {
            if (MyShape == 'R' && OpponentShape == 'C' ||
                MyShape == 'P' && OpponentShape == 'R' ||
                MyShape == 'C' && OpponentShape == 'P')
            {
                return Outcome.Win;
            }
            else if (MyShape == OpponentShape)
            {
                return Outcome.Draw;
            }

            return Outcome.Loss;
        }
    }

    public int MyScore
    {
        get
        {
            var myScore = MyShape switch
            {
                'R' => 1,
                'P' => 2,
                _   => 3
            };
            myScore += MyOutcome switch
            {
                Outcome.Win => 6,
                Outcome.Draw => 3,
                _   => 0
            };
            return myScore;
        }
    }
    
    public Round(string data)
    {
        OpponentShape = data[0] switch
        {
            'A' => 'R',
            'B' => 'P',
            _   => 'C'
        };
        MyShape = data[2] switch
        {
            'X' => 'R',
            'Y' => 'P',
            _   => 'C'
        };
    }
}
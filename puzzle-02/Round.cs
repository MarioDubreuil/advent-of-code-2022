using System.Xml.Schema;

namespace puzzle_02;

public class Round
{
    public Shape OpponentShape { get; private set; }
    public Shape MyShape { get; private set; }
    
    public Outcome MyOutcome
    {
        get
        {
            if (MyShape == Shape.Rock && OpponentShape == Shape.Scissors ||
                MyShape == Shape.Paper && OpponentShape == Shape.Rock ||
                MyShape == Shape.Scissors && OpponentShape == Shape.Paper)
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
                Shape.Rock => 1,
                Shape.Paper => 2,
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
            'A' => Shape.Rock,
            'B' => Shape.Paper,
            _   => Shape.Scissors
        };
        MyShape = data[2] switch
        {
            'X' => Shape.Rock,
            'Y' => Shape.Paper,
            _   => Shape.Scissors
        };
    }
}
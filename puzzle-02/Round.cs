using System.Xml.Schema;

namespace puzzle_02;

public class Round
{
    public Shape OpponentShape { get; private set; }
    public Outcome MyOutcome { get; private set; }
    
    public Shape MyShape
    {
        get
        {
            var myShape = MyOutcome switch
            {
                Outcome.Win => OpponentShape switch
                {
                    Shape.Rock => Shape.Paper,
                    Shape.Paper => Shape.Scissors,
                    _ => Shape.Rock
                },
                Outcome.Loss => OpponentShape switch
                {
                    Shape.Rock => Shape.Scissors,
                    Shape.Paper => Shape.Rock,
                    _ => Shape.Paper
                },
                _ => OpponentShape
            };
            return myShape;
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
        
        MyOutcome = data[2] switch
        {
            'X' => Outcome.Loss,
            'Y' => Outcome.Draw,
            _   => Outcome.Win
        };
    }
}
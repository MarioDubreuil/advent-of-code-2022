using FluentAssertions;
using puzzle_02;

namespace puzzle_02_tests;

public class TestRound
{
    [Theory]
    [InlineData("A X", Shape.Rock, Outcome.Loss)]
    [InlineData("A Y", Shape.Rock, Outcome.Draw)]
    [InlineData("A Z", Shape.Rock, Outcome.Win)]
    [InlineData("B X", Shape.Paper, Outcome.Loss)]
    [InlineData("B Y", Shape.Paper, Outcome.Draw)]
    [InlineData("B Z", Shape.Paper, Outcome.Win)]
    [InlineData("C X", Shape.Scissors, Outcome.Loss)]
    [InlineData("C Y", Shape.Scissors, Outcome.Draw)]
    [InlineData("C Z", Shape.Scissors, Outcome.Win)]
    public void CreateRound(string shapes, Shape opponentShape, Outcome myOutcome)
    {
        var round = new Round(shapes);
        round.OpponentShape.Should().Be(opponentShape);
        round.MyOutcome.Should().Be(myOutcome);
    }
    
    [Theory]
    [InlineData("A X", Shape.Scissors)]
    [InlineData("A Y", Shape.Rock)]
    [InlineData("A Z", Shape.Paper)]
    [InlineData("B X", Shape.Rock)]
    [InlineData("B Y", Shape.Paper)]
    [InlineData("B Z", Shape.Scissors)]
    [InlineData("C X", Shape.Paper)]
    [InlineData("C Y", Shape.Scissors)]
    [InlineData("C Z", Shape.Rock)]
    public void MyShape(string shapes, Shape myShape)
    {
        var round = new Round(shapes);
        round.MyShape.Should().Be(myShape);
    }
    
    [Theory]
    [InlineData("A X", 3 + 0)]
    [InlineData("A Y", 1 + 3)]
    [InlineData("A Z", 2 + 6)]
    [InlineData("B X", 1 + 0)]
    [InlineData("B Y", 2 + 3)]
    [InlineData("B Z", 3 + 6)]
    [InlineData("C X", 2 + 0)]
    [InlineData("C Y", 3 + 3)]
    [InlineData("C Z", 1 + 6)]
    public void MyScore(string shapes, int myScore)
    {
        var round = new Round(shapes);
        round.MyScore.Should().Be(myScore);
    }
}
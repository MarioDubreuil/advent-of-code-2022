using FluentAssertions;
using puzzle_02;

namespace puzzle_02_tests;

public class TestRound
{
    [Theory]
    [InlineData("A X", 'R', 'R')]
    [InlineData("A Y", 'R', 'P')]
    [InlineData("A Z", 'R', 'C')]
    [InlineData("B X", 'P', 'R')]
    [InlineData("B Y", 'P', 'P')]
    [InlineData("B Z", 'P', 'C')]
    [InlineData("C X", 'C', 'R')]
    [InlineData("C Y", 'C', 'P')]
    [InlineData("C Z", 'C', 'C')]
    public void CreateRound(string shapes, char opponentShape, char myShape)
    {
        var round = new Round(shapes);
        round.OpponentShape.Should().Be(opponentShape);
        round.MyShape.Should().Be(myShape);
    }
    
    [Theory]
    [InlineData("A X", Outcome.Draw)]
    [InlineData("A Y", Outcome.Win)]
    [InlineData("A Z", Outcome.Loss)]
    [InlineData("B X", Outcome.Loss)]
    [InlineData("B Y", Outcome.Draw)]
    [InlineData("B Z", Outcome.Win)]
    [InlineData("C X", Outcome.Win)]
    [InlineData("C Y", Outcome.Loss)]
    [InlineData("C Z", Outcome.Draw)]
    public void MyOutcome(string shapes, Outcome myOutcome)
    {
        var round = new Round(shapes);
        round.MyOutcome.Should().Be(myOutcome);
    }
    
    [Theory]
    [InlineData("A X", 1 + 3)]
    [InlineData("A Y", 2 + 6)]
    [InlineData("A Z", 3 + 0)]
    [InlineData("B X", 1 + 0)]
    [InlineData("B Y", 2 + 3)]
    [InlineData("B Z", 3 + 6)]
    [InlineData("C X", 1 + 6)]
    [InlineData("C Y", 2 + 0)]
    [InlineData("C Z", 3 + 3)]
    public void MyScore(string shapes, int myScore)
    {
        var round = new Round(shapes);
        round.MyScore.Should().Be(myScore);
    }
}
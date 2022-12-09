using System.Globalization;
using FluentAssertions;
using puzzle_02;

namespace puzzle_02_tests;

public class Test_Round
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
    [InlineData("A X", 'D')]
    [InlineData("A Y", 'W')]
    [InlineData("A Z", 'L')]
    [InlineData("B X", 'L')]
    [InlineData("B Y", 'D')]
    [InlineData("B Z", 'W')]
    [InlineData("C X", 'W')]
    [InlineData("C Y", 'L')]
    [InlineData("C Z", 'D')]
    public void MyOutcome(string shapes, char myOutcome)
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
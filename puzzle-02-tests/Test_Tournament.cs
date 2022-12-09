using FluentAssertions;
using puzzle_02;

namespace puzzle_02_tests;

public class TestTournament
{
    [Fact]
    public void CreateTournamentWithOneRound()
    {
        var tournament = new Tournament("A Y");
        tournament.Rounds.Count.Should().Be(1);
        tournament.Rounds[0].MyScore.Should().Be(2 + 6);
        tournament.MyScore.Should().Be((2 + 6));
    }
    
    [Fact]
    public void CreateTournamentWithMultipleRounds()
    {
        var tournament = new Tournament("A Y\nB X\nC Z");
        tournament.Rounds.Count.Should().Be(3);
        tournament.Rounds[0].MyScore.Should().Be(2 + 6);
        tournament.Rounds[1].MyScore.Should().Be(1 + 0);
        tournament.Rounds[2].MyScore.Should().Be(3 + 3);
        tournament.MyScore.Should().Be(2 + 6 + 1 + 0 + 3 + 3);
    }
}
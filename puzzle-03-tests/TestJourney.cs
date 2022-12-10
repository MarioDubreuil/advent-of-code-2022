using FluentAssertions;
using puzzle_03;

namespace puzzle_03_tests;

public class TestJourney
{
    [Fact]
    public void CreateJourney()
    {
        var data = "vJrwpWtwJgWrhcsFMMfFFhFp";
        var journey = new Journey(data);
        journey.Rucksack.Data.Should().Be(data);
    }
}
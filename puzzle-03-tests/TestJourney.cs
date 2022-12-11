using FluentAssertions;
using puzzle_03;

namespace puzzle_03_tests;

public class TestJourney
{
    [Fact]
    public void CreateJourney_SingleRucksack()
    {
        var data = "vJrwpWtwJgWrhcsFMMfFFhFp";
        var journey = new Journey(data);
        journey.Rucksack.Priority.Should().Be(16);
    }

    [Fact]
    public void CreateJourney_MultipleRucksack()
    {
        var data = "vJrwpWtwJgWrhcsFMMfFFhFp";
        var journey = new Journey(data);
        journey.Rucksack.Data.Should().Be(data);
    }
}
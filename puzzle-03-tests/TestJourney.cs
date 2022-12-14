using FluentAssertions;
using puzzle_03;

namespace puzzle_03_tests;

public class TestJourney
{
    [Fact]
    public void CreateJourney_SingleGroup()
    {
        var data = "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn\nttgJtRGJQctTZtZT\nCrZsJsPPZsGzwwsLwLmpwMDw";
        var journey = new Journey(data);
        journey.Groups.Count.Should().Be(1);
        journey.SumPriorities.Should().Be(52);
    }

    [Fact]
    public void CreateJourney_MultipleRucksacks()
    {
        var data = "vJrwpWtwJgWrhcsFMMfFFhFp\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL\nPmmdzqPrVvPwwTWBwg\nwMqvLMZHhHMvwLHjbvcjnnSBnvTQFn\nttgJtRGJQctTZtZT\nCrZsJsPPZsGzwwsLwLmpwMDw";
        var journey = new Journey(data);
        journey.Groups.Count.Should().Be(2);
        journey.SumPriorities.Should().Be(70);
    }
}
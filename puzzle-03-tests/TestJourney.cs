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
        journey.Rucksacks.Count.Should().Be(1);
        journey.SumPriorities.Should().Be(16);
    }

    [Fact]
    public void CreateJourney_MultipleRucksacks()
    {
        var data = "vJrwpWtwJgWrhcsFMMfFFhFp\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL\nPmmdzqPrVvPwwTWBwg\nwMqvLMZHhHMvwLHjbvcjnnSBnvTQFn\nttgJtRGJQctTZtZT\nCrZsJsPPZsGzwwsLwLmpwMDw";
        var journey = new Journey(data);
        journey.Rucksacks.Count.Should().Be(6);
        journey.Rucksacks[0].CommonItemType.Should().Be('p');
        journey.Rucksacks[0].Priority.Should().Be(16);
        journey.Rucksacks[1].CommonItemType.Should().Be('L');
        journey.Rucksacks[1].Priority.Should().Be(38);
        journey.SumPriorities.Should().Be(157);
    }
}
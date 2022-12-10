using FluentAssertions;
using puzzle_03;

namespace puzzle_03_tests;

public class TestRusksack
{
    [Fact]
    public void CreateRucksack()
    {
        var data = "vJrwpWtwJgWrhcsFMMfFFhFp";
        var rucksack = new Rucksack(data);
        rucksack.Data.Should().Be(data);
    }
}
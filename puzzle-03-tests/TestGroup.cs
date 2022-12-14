using FluentAssertions;
using puzzle_03;

namespace puzzle_03_tests;

public class TestGroup
{
    [Fact]
    public void CreateGroup_simple()
    {
        var rucksack1 = "abcd";
        var rucksack2 = "xydg";
        var rucksack3 = "qdrs";
        var group = new Group(rucksack1, rucksack2, rucksack3);
        group.Rucksack1.Should().Be(rucksack1);
        group.Rucksack2.Should().Be(rucksack2);
        group.Rucksack3.Should().Be(rucksack3);
        group.Badge.Should().Be('d');
        group.Priority.Should().Be(4);
    }
    
    [Fact]
    public void CreateGroup_complex()
    {
        var rucksack1 = "vJrwpWtwJgWrhcsFMMfFFhFp";
        var rucksack2 = "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL";
        var rucksack3 = "PmmdzqPrVvPwwTWBwg";
        var group = new Group(rucksack1, rucksack2, rucksack3);
        group.Rucksack1.Should().Be(rucksack1);
        group.Rucksack2.Should().Be(rucksack2);
        group.Rucksack3.Should().Be(rucksack3);
        group.Badge.Should().Be('r');
        group.Priority.Should().Be(18);
    }
}
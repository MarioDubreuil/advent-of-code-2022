using FluentAssertions;
using puzzle_03;

namespace puzzle_03_tests;

public class TestRusksack
{
    [Fact]
    public void CreateRucksack_Data()
    {
        var data = "a23b47cd";
        var rucksack = new Rucksack(data);
        rucksack.Data.Should().Be(data);
    }
    
    [Fact]
    public void CreateRucksack_Compatements()
    {
        var leftData = "a23b";
        var rightData = "47cd";
        var data = leftData + rightData;
        var rucksack = new Rucksack(data);
        rucksack.FirstCompartment.Should().Be(leftData);
        rucksack.SecondCompartment.Should().Be(rightData);
    }
}
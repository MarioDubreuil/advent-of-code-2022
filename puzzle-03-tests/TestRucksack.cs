using FluentAssertions;
using puzzle_03;

namespace puzzle_03_tests;

public class TestRucksack
{
    [Fact]
    public void CreateRucksack_Data()
    {
        var data = "awRspEwz";
        var rucksack = new Rucksack(data);
        rucksack.Data.Should().Be(data);
    }
    
    [Fact]
    public void CreateRucksack_Compartments()
    {
        var data = "awRspEwz";
        var rucksack = new Rucksack(data);
        rucksack.FirstCompartment.Should().Be("awRs");
        rucksack.SecondCompartment.Should().Be("pEwz");
    }
    
    [Fact]
    public void CreateRucksack_CommonItemType()
    {
        var data = "awRspEwz";
        var rucksack = new Rucksack(data);
        rucksack.CommonItemType.Should().Be('w');
    }
    
    [Fact]
    public void CreateRucksack_Priority()
    {
        var data = "awRspEwz";
        var rucksack = new Rucksack(data);
        rucksack.Priority.Should().Be(23);
    }
}
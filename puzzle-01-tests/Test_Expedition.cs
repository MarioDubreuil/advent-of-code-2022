using FluentAssertions;
using puzzle_01;

namespace puzzle_01_tests;

public class Test_Expedition
{
    [Fact]
    public void CreateExpeditionWithOneElfOneSnack()
    {
        var expedition = new Expedition("2000");
        expedition.Elves.Count.Should().Be(1);
        expedition.Elves[0].Snacks.Count.Should().Be(1);
        expedition.Elves[0].Snacks[0].Calories.Should().Be(2000);
    }
    
    [Fact]
    public void CreateExpeditionWithOneElfMultipleSnacks()
    {
        var expedition = new Expedition("2000\n7000\n1000");
        expedition.Elves.Count.Should().Be(1);
        expedition.Elves[0].Snacks.Count.Should().Be(3);
        expedition.Elves[0].Snacks[0].Calories.Should().Be(2000);
        expedition.Elves[0].Snacks[1].Calories.Should().Be(7000);
        expedition.Elves[0].Snacks[2].Calories.Should().Be(1000);
    }
    
    [Fact]
    public void CreateExpeditionWithMultipleElvesMultipleSnacks()
    {
        var expedition = new Expedition("2000\n7000\n1000\n\n1000\n\n9000\n5000\n7000\n5000");
        expedition.Elves.Count.Should().Be(3);
        expedition.Elves[0].Snacks.Count.Should().Be(3);
        expedition.Elves[0].Snacks[0].Calories.Should().Be(2000);
        expedition.Elves[0].Snacks[1].Calories.Should().Be(7000);
        expedition.Elves[0].Snacks[2].Calories.Should().Be(1000);
        expedition.Elves[1].Snacks.Count.Should().Be(1);
        expedition.Elves[1].Snacks[0].Calories.Should().Be(1000);
        expedition.Elves[2].Snacks.Count.Should().Be(4);
        expedition.Elves[2].Snacks[0].Calories.Should().Be(9000);
        expedition.Elves[2].Snacks[1].Calories.Should().Be(5000);
        expedition.Elves[2].Snacks[2].Calories.Should().Be(7000);
        expedition.Elves[2].Snacks[3].Calories.Should().Be(5000);
    }
    
    [Fact]
    public void MaximumCaloriesWithOneElf()
    {
        var expedition = new Expedition("2000\n7000\n1000");
        expedition.MaximumCalories.Should().Be(10000);
    }
    
    [Fact]
    public void MaximumCaloriesWithMultipleElves()
    {
        var expedition = new Expedition("2000\n7000\n1000\n\n1000\n\n9000\n5000\n7000\n5000");
        expedition.MaximumCalories.Should().Be(26000);
    }
    
    [Fact]
    public void TotalCaloriesForTop3Elves()
    {
        var expedition = new Expedition("1000\n2000\n3000\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000");
        expedition.TotalCaloriesForTop3Elves.Should().Be(45000);
    }
}
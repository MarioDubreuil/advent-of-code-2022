using FluentAssertions;
using puzzle_01;

namespace puzzle_01_tests;

public class Test_Elf
{
    [Fact]
    public void CreateElfWithOneSnack()
    {
        var elf = new Elf("3000");
        elf.Snacks.Count.Should().Be(1);
        elf.Snacks[0].Calories.Should().Be(3000);
    }

    [Fact]
    public void CreateElfWithMultipleSnacks()
    {
        var elf = new Elf("6000\n9000\n4000\n8000");
        elf.Snacks.Count.Should().Be(4);
        elf.Snacks[0].Calories.Should().Be(6000);
        elf.Snacks[1].Calories.Should().Be(9000);
        elf.Snacks[2].Calories.Should().Be(4000);
        elf.Snacks[3].Calories.Should().Be(8000);
    }
    
    [Fact]
    public void TotalCaloriesWithOneSnack()
    {
        var elf = new Elf("3000");
        elf.TotalCalories.Should().Be(3000);
    }
    
    [Fact]
    public void TotalCaloriesWithMultipleSnacks()
    {
        var elf = new Elf("6000\n9000\n4000\n8000");
        elf.TotalCalories.Should().Be(27000);
    }
}
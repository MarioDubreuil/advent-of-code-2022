using FluentAssertions;
using puzzle_01;

namespace puzzle_01_tests;

public class Test_Snack
{
    [Fact]
    public void CreateSnack()
    {
        var snack = new Snack("1000");
        snack.Calories.Should().Be(1000);
    }
    
}
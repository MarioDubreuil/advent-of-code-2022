using puzzle_01;

namespace puzzle_01_tests;

public class Test_MyExtensions
{
    [Theory]
    [InlineData("1")]
    [InlineData("7000\n2000")]
    [InlineData("340\n1023\n78\n7")]
    public void SplitByElf_WhenOneElf_ShouldBeOk(string rawData)
    {
        var dataSplitByElf = rawData.SplitByElf();
        Assert.Equal(new string[] {rawData}, dataSplitByElf);
    }

    [Theory]
    [InlineData("1\n\n2", "1", "2")]
    [InlineData("10\n30\n\n200\n785\n3", "10\n30", "200\n785\n3")]
    public void SplitByElf_WhenTwoElves_ShouldBeOk(string rawData, string elf1, string elf2)
    {
        var dataSplitByElf = rawData.SplitByElf();
        Assert.Equal(new string[] {elf1, elf2}, dataSplitByElf);
    }

    [Fact]
    public void SplitByElf_WhenMultipleElves_ShouldBeOk()
    {
        var rawData = "1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000";
        var dataSplitByElf = rawData.SplitByElf();
        Assert.Equal(new string[] {"1000\n2000\n3000", "4000", "5000\n6000", "7000\n8000\n9000", "10000"}, dataSplitByElf);
    }
}
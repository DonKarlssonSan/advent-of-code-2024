namespace AdventOfCode2024.Tests;

public class Test03A
{
    [Fact]
    public void Test03a_ShouldReturn161()
    {
        var result = Multiplier.ParseResult("input03.txt");
        Assert.Equal(161, result);
    }
}
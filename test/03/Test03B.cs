namespace AdventOfCode2024.Tests;

public class Test03B
{
    [Fact]
    public void Test03B_ShouldReturn48()
    {
        var result = MultiplierB.ParseResult("input03.txt");
        Assert.Equal(48, result);
    }
}
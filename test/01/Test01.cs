using AdventOfCode2024;

namespace AdventOfCode2024.Tests;

public class Test01
{
    [Fact]
    public void Test1()
    {
        var distance = DistanceCalculator.Calculate("input.txt");
        Assert.Equal(11, distance);
    }
}
using AdventOfCode2024;
using Xunit;

namespace AdventOfCode2024.Tests;

public class Test01
{
    [Fact]
    public void Test01_A()
    {
        var distance = DistanceCalculator.Calculate("input.txt");
        Assert.Equal(11, distance);
    }

    [Fact]
    public void Test01_B()
    {
        var similarity = SimilarityCalculator.Calculate("input.txt");
        Assert.Equal(31, similarity);
    }
}
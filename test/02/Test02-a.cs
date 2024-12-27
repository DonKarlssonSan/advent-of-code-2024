using AdventOfCode2024;
using Xunit;

namespace AdventOfCode2024.Tests;

public class Test02A
{
    [Fact]
    public void Test02A_Row1_ShouldBeSafe()
    {
        var isSafe = ReportChecker.IsRowSafe("7 6 4 2 1");
        Assert.True(isSafe);
    }

    [Fact]
    public void Test02A_Row2_ShouldNotBeSafe()
    {
        var isSafe = ReportChecker.IsRowSafe("1 2 7 8 9");
        Assert.False(isSafe);
    }

    [Fact]
    public void Test02A_Row3_ShouldNotBeSafe()
    {
        var isSafe = ReportChecker.IsRowSafe("9 7 6 2 1");
        Assert.False(isSafe);
    }

    [Fact]
    public void Test02A_Row4_ShouldNotBeSafe()
    {
        var isSafe = ReportChecker.IsRowSafe("1 3 2 4 5");
        Assert.False(isSafe);
    }

    [Fact]
    public void Test02A_Row5_ShouldNotBeSafe()
    {
        var isSafe = ReportChecker.IsRowSafe("8 6 4 4 1");
        Assert.False(isSafe);
    }

    [Fact]
    public void Test02A_Row6_ShouldNotBeSafe()
    {
        var isSafe = ReportChecker.IsRowSafe("1 3 6 7 9");
        Assert.True(isSafe);
    }

    [Fact]
    public void Test02A_ShouldReturn2SafeReports()
    {
      var nrOfSafeReports = ReportChecker.CountSafeReports("input02.txt");
      Assert.Equal(2, nrOfSafeReports);
    }
}
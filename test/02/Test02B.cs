namespace AdventOfCode2024.Tests;

public class Test02B
{
    [Fact]
    public void Test02B_Row1_ShouldBeSafe()
    {
        var isSafe = ReportCheckerB.IsRowSafe("7 6 4 2 1");
        Assert.True(isSafe);
    }

    [Fact]
    public void Test02B_Row2_ShouldNotBeSafe()
    {
        var isSafe = ReportCheckerB.IsRowSafe("1 2 7 8 9");
        Assert.False(isSafe);
    }

    [Fact]
    public void Test02B_Row3_ShouldNotBeSafe()
    {
        var isSafe = ReportCheckerB.IsRowSafe("9 7 6 2 1");
        Assert.False(isSafe);
    }

    [Fact]
    public void Test02B_Row4_ShouldBeSafe()
    {
        var isSafe = ReportCheckerB.IsRowSafe("1 3 2 4 5");
        Assert.True(isSafe);
    }

    [Fact]
    public void Test02B_Row5_ShouldBeSafe()
    {
        var isSafe = ReportCheckerB.IsRowSafe("8 6 4 4 1");
        Assert.True(isSafe);
    }

    [Fact]
    public void Test02B_Row6_ShouldBeSafe()
    {
        var isSafe = ReportCheckerB.IsRowSafe("1 3 6 7 9");
        Assert.True(isSafe);
    }

    [Fact]
    public void Test02B_ShouldReturn4SafeReportsUsingDampener()
    {
      var nrOfSafeReports = ReportCheckerB.CountSafeReports("input02.txt");
      Assert.Equal(4, nrOfSafeReports);
    }
}
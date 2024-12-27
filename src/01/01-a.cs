namespace AdventOfCode2024;

public static class DistanceCalculator
{
  public static int Calculate(string fileName)
  {
    var (firstColumn, secondColumn) = Parser.ParseAndSort(fileName);
    return TotalDistance(firstColumn, secondColumn);
  }

  private static int Distance(int a, int b)
  {
    return Math.Abs(a - b);
  }

  private static int TotalDistance(List<int> a, List<int> b)
  {
    var length = a.Count;
    var sum = 0;
    for(var i = 0; i < length; i++)
    {
      sum += Distance(a[i], b[i]);
    }
    return sum;
  }
}

namespace AdventOfCode2024;

public static class Parser
{

  public static (List<int>, List<int>) ParseAndSort(string fileName)
  {
    var rows = File.ReadAllLines(fileName);
    List<int> firstColumn = new();
    List<int> secondColumn = new();
    foreach(var row in rows)
    {
      var columns = row.Split("   ");
      firstColumn.Add(int.Parse(columns[0]));
      secondColumn.Add(int.Parse(columns[1]));
    }
    firstColumn.Sort();
    secondColumn.Sort();
    return (firstColumn, secondColumn);
  }
}
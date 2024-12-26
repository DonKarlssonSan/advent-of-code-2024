namespace AdventOfCode2024;

public static class Parser {

  public static (List<int>, List<int>) ParseAndSort(string fileName) {
    var rows = File.ReadAllLines(fileName);
    List<int> firstColumn = new();
    List<int> secondColumn = new();
    foreach(var row in rows) {
      // Console.WriteLine("row:" + row);
      var columns = row.Split("   ");
      // Console.WriteLine(columns);
      firstColumn.Add(int.Parse(columns[0]));
      secondColumn.Add(int.Parse(columns[1]));
    }
    firstColumn.Sort();
    secondColumn.Sort();
    return (firstColumn, secondColumn);
  }
}
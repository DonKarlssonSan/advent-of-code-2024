
namespace AdventOfCode2024;
public class DistanceCalculator {

  public static int Calculate(string fileName) {
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
    return TotalDistance(firstColumn, secondColumn);
  }
  private static int Distance(int a, int b) {
    return Math.Abs(a - b);
  }

  private static int TotalDistance(List<int> a, List<int> b) {
    var lenght = a.Count;
    var sum = 0;
    for(var i = 0; i < lenght; i++) {
      sum += Distance(a[i], b[i]);
    }
    return sum;
  }
}

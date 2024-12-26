namespace AdventOfCode2024;

public class SimilarityCalculator {

  public static int Calculate(string fileName) {
    var (firstColumn, secondColumn) = Parser.ParseAndSort(fileName);
    var groupedWithCount = secondColumn.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
    var sum = 0;
    foreach(var number in firstColumn) {
      var count = groupedWithCount.GetValueOrDefault(number);
      sum += (number * count);
    }
    return sum;
  }
}
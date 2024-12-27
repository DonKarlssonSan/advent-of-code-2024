using System.Text.RegularExpressions;
namespace AdventOfCode2024;

public static class Multiplier
{
  public static int ParseResult(string fileName)
  {
    var input = File.ReadAllText(fileName);
    var regex = new Regex(@"mul\(\d{1,3},\d{1,3}\)", RegexOptions.Compiled);
    var regex2 = new Regex(@"\d{1,3}");
    var sum = 0;
    foreach (var match in regex.Matches(input))
    {
      var numbers = regex2.Matches(match.ToString()).Select(m => int.Parse(m.ToString())).ToList();
      sum += numbers[0] * numbers[1];
    }
    return sum;
  }
}
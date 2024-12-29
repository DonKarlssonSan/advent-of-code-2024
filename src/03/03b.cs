using System.Text.RegularExpressions;
namespace AdventOfCode2024;

public static class MultiplierB
{
  public static int ParseResult(string fileName)
  {
    var input = File.ReadAllText(fileName);
    var regexInstructions = new Regex(@"mul\(\d{1,3},\d{1,3}\)|do\(\)|don't\(\)", RegexOptions.Compiled);
    var regexNumbers = new Regex(@"\d{1,3}");
    var sum = 0;
    var enabled = true;
    foreach (var match in regexInstructions.Matches(input))
    {
      var matchedString = match.ToString();
      if(matchedString.StartsWith("mul") && enabled) {
        var numbers = regexNumbers.Matches(matchedString).Select(m => int.Parse(m.ToString())).ToList();
        sum += numbers[0] * numbers[1];
      }
      if(matchedString == "do()"){
        enabled = true;
      }
      if(matchedString == "don't()") {
        enabled = false;
      }
    }
    return sum;
  }
}
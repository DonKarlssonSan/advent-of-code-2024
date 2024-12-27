using System.Reflection.Metadata.Ecma335;

public class ReportChecker
{
  public static bool IsRowSafe(string row)
  {
    var levels = row.Split(" ").Select(x => int.Parse(x)).ToList();
    var previousLevel = levels[0];
    var sign = Math.Sign(levels[0] - levels[1]);
    for(int i = 1; i < levels.Count; i++) {
      var currentLevel = levels[i];
      var currentSign = Math.Sign(previousLevel - currentLevel);
      if(currentSign != sign)
      {
        return false;
      }
      var diff = Math.Abs(previousLevel - currentLevel);
      if(diff < 1 || diff > 3)
      {
        return false;
      }
      previousLevel = currentLevel;
    }
    return true;
  }

  public static int CountSafeReports(string fileName)
  {
    var rows = File.ReadAllLines(fileName);
    var nrOfSafeReports = 0;
    foreach(var row in rows)
    {
      if(IsRowSafe(row))
      {
        nrOfSafeReports++;
      }
    }
    return nrOfSafeReports;
  }
}
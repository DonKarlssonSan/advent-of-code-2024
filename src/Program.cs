using AdventOfCode2024;

var totalDistance = DistanceCalculator.Calculate("./src/01/input01.txt");
Console.WriteLine($"Total distance: {totalDistance}");

var similarity = SimilarityCalculator.Calculate("./src/01/input01.txt");
Console.WriteLine($"Similarity score: {similarity}");

var nrOfSafeReports = ReportChecker.CountSafeReports("./src/02/input02.txt");
Console.WriteLine($"Number of safe reports: {nrOfSafeReports}");

var nrOfSafeReportsB = ReportCheckerB.CountSafeReports("./src/02/input02.txt");
Console.WriteLine($"Number of safe reports, using Problem Dampener: {nrOfSafeReportsB}");

var sum3a = Multiplier.ParseResult("./src/03/input03.txt");
Console.WriteLine($"Sum of multiplications: {sum3a}");

var sum3b = MultiplierB.ParseResult("./src/03/input03.txt");
Console.WriteLine($"Sum of multiplications: {sum3b}");
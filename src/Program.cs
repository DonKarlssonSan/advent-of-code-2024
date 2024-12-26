using AdventOfCode2024;

var totalDistance = DistanceCalculator.Calculate("./src/01/input.txt");
Console.WriteLine($"Total distance: {totalDistance}");

var similarity = SimilarityCalculator.Calculate("./src/01/input.txt");
Console.WriteLine($"Similarity score: {similarity}");
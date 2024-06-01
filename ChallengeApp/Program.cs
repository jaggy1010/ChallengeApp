using ChallengeApp;

var employee = new Employee("Mateusz", "Malinowski");

employee.AddScore("Wenancjusz");
employee.AddScore("400");
employee.AddScore(200);
employee.AddScore(20L);
employee.AddScore(79UL);
employee.AddScore(99M);
employee.AddScore(7);

var statistics = employee.GetStatistics();

Console.WriteLine($"\nStatistics of employee {employee.Name} {employee.Surname}:");
Console.WriteLine($"Average score: {statistics.Average:N2}");
Console.WriteLine($"Min score: {statistics.Min}");
Console.WriteLine($"Max score: {statistics.Max}");


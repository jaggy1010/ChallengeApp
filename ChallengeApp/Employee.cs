using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp;

public class Employee
{
    public string Name { get; private set; }
    public string Surname { get; private set; }
    private List<float> scores = new List<float>();

    public Employee(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }

    public void AddScore(float score)
    {
        if (score >= 0 && score <= 100)
        {
            this.scores.Add(score);
        }
        else
        {
            Console.WriteLine("Acceptable scores from 0 to 100.");
        }
    }

    public void AddScore(string score)
    {
        if (float.TryParse(score, out float result))
        {
            this.AddScore(result);
        }
        else
        {
            Console.WriteLine("String is not like float.");
        }
    }

    public void AddScore(int score)
    {
        float result = score;
        this.AddScore(result);
    }

    public void Addscore(long score)
    {
        float result = score;
        this.AddScore(result);
    }

    public void AddScore(ulong score)
    {
        float result = score;
        this.AddScore(result);
    }

    public void AddScore(double score)
    {
        float result = (float)score;
        this.AddScore(result);
    }

    public void AddScore(decimal score)
    {
        float result = (float)score;
        this.AddScore(result);
    }

    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Min = float.MaxValue;
        statistics.Max = float.MinValue;
        foreach (var score in this.scores)
        {
            statistics.Min = Math.Min(statistics.Min, score);
            statistics.Max = Math.Max(statistics.Max, score);
            statistics.Average += score;
        }

        if (this.scores.Count != 0)
        {
            statistics.Average /= this.scores.Count;
        }
        else
        {
            statistics.Min = 0;
            statistics.Max = 0;
            string message = "Employeehas not been scored.";
            Console.WriteLine(message);
        }

        return statistics;
    }
}
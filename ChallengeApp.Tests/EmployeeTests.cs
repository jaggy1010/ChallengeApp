namespace ChallengeApp.Tests;

[TestFixture]
public class EmployeeTests
{
    [Test]
    public void CheckEmployeeName()
    {
        // arrange
         var employee = new Employee("Mieszko", "Pierwszy");

         // act
         var result = employee.Name;

         // assert
         Assert.AreEqual("Mieszko", result);
    }
    
    [Test]
    public void CheckEmployeeSurname()
    {
        // arrange
        Employee employee = new Employee("Bolesław", "Chrobry");
        
        // act
        var result = employee.Surname;
        
        // assert
        Assert.AreEqual("Chrobry",result);
    }

    [Test]
    public void CheckScoresStatisticsWhereEmployeeScored()
    {
        // arrange
        Employee employee = new Employee("Stefan", " Batory");
        employee.AddScore("1");
        employee.AddScore("2");
        employee.AddScore("4");
        
        // act
        var statistics = employee.GetStatistics();
        var resultAvg = Math.Round(statistics.Average, 2);
        var resultMin = statistics.Min;
        var resultMax = statistics.Max;
        
        // assert
        Assert.AreEqual(Math.Round(2.33,2), resultAvg);
        Assert.AreEqual(1.0, resultMin);
        Assert.AreEqual(4.0, resultMax);
    }

    [Test]
    public void CheckScoresStatistingsWhereEmployeeIsNotScored()
    {
        // arrange
        Employee employee = new Employee("Kazimierz", "Jagiellończyk");
        
        // act
        var statistics = employee.GetStatistics();
        var resultAvg = Math.Round(statistics.Average, 2);
        var resultMin = statistics.Min;
        var resultMax = statistics.Max;
        
        // assert
        Assert.AreEqual(Math.Round(0.0, 2), resultAvg);
        Assert.AreEqual(0.0, resultMin);
        Assert.AreEqual(0.0, resultMax);
    }
}
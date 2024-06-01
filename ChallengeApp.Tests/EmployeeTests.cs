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

}
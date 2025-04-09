namespace FirstProjectC_.Tests;

public class UnitTest1
{
    [Fact]
    public void PerformWork_Adds_FirstName_And_LastName()
    {
        //Arrange
        string firstName = "John";
        string lastName = "Doe";
        string expectedFullName = "John Doe";

        // Act
        string result = PerformWork(firstName, lastName);

        // Assert
        Assert.Equal(expectedFullName, result);
    }
    private string PerformWork(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }
}




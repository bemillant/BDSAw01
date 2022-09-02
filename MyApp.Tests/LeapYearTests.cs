namespace MyApp.Tests;


public class LeapYearTests
{
    [Fact]
    public void calculating_If_LeapYear_True()
    {
        // Arrange
        var year = new Year();

        // Act
        var result = year.isLeapYear(2016);
       
        // Assert
        result.Should().Be(true);

        
    }

    [Fact]
    public void calculating_If_LeapYear_False()
    {
        // Arrange
        var year = new Year();

        // Act
        var result = year.isLeapYear(2015);
       
        // Assert
        result.Should().Be(false);

    }
}
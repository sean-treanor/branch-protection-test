namespace SampleApplication.UnitTests.Controllers;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApplication.Controllers;

[TestClass]
public class WeatherForecastControllerTests
{
    private readonly WeatherForecastController _systemUnderTest = new();
    
    [TestMethod]
    public void Get_WhenCalled_ReturnsData()
    {
        // Arrange / Act
        var result = _systemUnderTest.Get();
        
        // Assert
        result.Should().HaveCount(5);
    }
}
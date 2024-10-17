using CiP;
using NUnit.Framework;
namespace CiP.RouteTests;
[TestFixture]
public class RouteTests
{
    private Routes routes;
    [TestCase("", 1)]
    [TestCase(">", 2)]
    [TestCase("><", 2)]
    [TestCase("^>v<", 4)]
    [TestCase("^v^v^v^v^v", 2)]

    public void TestHowManyHousesGetAtLeast1Present(string directions, int expectedHouses)
    {
        // Act
        int result = Routes.RouteCalculator(directions);

        // Assert
        Assert.That(result, Is.EqualTo(expectedHouses));
    }
}
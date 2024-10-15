using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CiP;
using NUnit.Framework;

[TestFixture]
public class RouteTests
{
    private Routes routes;
    [SetUp]
    public void SetUp()
    { 
        routes = new Routes(); 
    }
    [Test]
    public void TestHowManyHousesGetAtLeast1Present()
    {
        // Arrange
        int a = 2;
        int b = 3;

        // Act
        //int result = Calculator.Add(a, b);
        //int result = ;

        // Assert
        //Assert.AreEqual(5, result);
    }
}

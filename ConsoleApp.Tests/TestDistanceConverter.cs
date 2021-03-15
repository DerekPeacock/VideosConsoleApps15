using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            // Arrange

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 1.0;

            // Act

            converter.CalculateDistance();

            double expectedDistance = 5280;

            // Assert

            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }
        [TestMethod]
        public void TestFeetToMiles()
        {
            // Arrange

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 5280;

            // Act

            converter.CalculateDistance();

            double expectedDistance = 1.0;

            // Assert

            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }

    }
}

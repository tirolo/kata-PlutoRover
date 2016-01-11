using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirolo.CodeKata.PlutoRover.Tests
{
    [TestFixture]
    public class PlutoRoverTests
    {
        [Test]
        public void Rover_Should_Move_Forward_And_Keep_Same_Heading_When_F_Command_Given()
        {
            // Arrange
            PlutoRover plutoRover = new PlutoRover();

            // Act
            plutoRover.ExecuteCommand("F");

            // Assert
            var actualPlutoRoverPosition = plutoRover.ReportPostition();
            var expectedPlutoRoverPosition = "0,1,N";

            Assert.AreEqual(expectedPlutoRoverPosition, actualPlutoRoverPosition);
        }
    }
}

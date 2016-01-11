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
            Domain.PlutoRover plutoRover = new Domain.PlutoRover();

            // Act
            plutoRover.ExecuteCommand("F");

            // Assert
            var actualPlutoRoverPosition = plutoRover.ReportPosition();
            var expectedPlutoRoverPosition = "0,1,N";

            Assert.AreEqual(expectedPlutoRoverPosition, actualPlutoRoverPosition);
        }

        [Test]
        public void Rover_Should_Move_Backward_And_Keep_Same_Heading_When_B_Command_Given()
        {
            // Arrange
            Domain.PlutoRover plutoRover = new Domain.PlutoRover();

            // Act
            plutoRover.ExecuteCommand("B");

            // Assert
            var actualPlutoRoverPosition = plutoRover.ReportPosition();
            var expectedPlutoRoverPosition = "0,-1,N";

            Assert.AreEqual(expectedPlutoRoverPosition, actualPlutoRoverPosition);
        }

        [Test]
        public void Rover_Should_Process_Multiple_Commands_Given()
        {
            // Arrange
            Domain.PlutoRover plutoRover = new Domain.PlutoRover();

            // Act
            plutoRover.ExecuteCommand("FFBFFBBB");

            // Assert
            var actualPlutoRoverPosition = plutoRover.ReportPosition();
            var expectedPlutoRoverPosition = "0,0,N";

            Assert.AreEqual(expectedPlutoRoverPosition, actualPlutoRoverPosition);
        }
    }
}

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
            var expectedPlutoRoverPosition = "0,99,N"; // I had to fix this test, potentially a Open/Close principle issue here.

            Assert.AreEqual(expectedPlutoRoverPosition, actualPlutoRoverPosition);
        }

        [Test]
        public void Rover_Should_Be_At_0_0_N_When_FFBFFBBB_Command_Given()
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

        [Test]
        public void Rover_Should_Spin_Left_And_Keep_Same_Position_When_L_Command_Given()
        {
            // Arrange
            Domain.PlutoRover plutoRover = new Domain.PlutoRover();

            // Act
            plutoRover.ExecuteCommand("L");

            // Assert
            var actualRoverPosition = plutoRover.ReportPosition();
            var expectedRoverPosition = "0,0,W";

            Assert.AreEqual(expectedRoverPosition, actualRoverPosition);
        }

        [Test]
        public void Rover_Should_Be_At_1_0_E_When_FLFFLFLFFF_Command_Given()
        {
            // Arrange
            Domain.PlutoRover plutoRover = new Domain.PlutoRover();

            // Act
            plutoRover.ExecuteCommand("FLFFLFLFFF");

            // Assert
            var actualRoverPosition = plutoRover.ReportPosition();
            var expectedRoverPosition = "1,0,E";

            Assert.AreEqual(expectedRoverPosition, actualRoverPosition);
        }

        [Test]
        public void Rover_Should_Spin_Right_And_Keep_Same_Position_When_R_Command_Given()
        {
            // Arrange
            Domain.PlutoRover plutoRover = new Domain.PlutoRover();

            // Act
            plutoRover.ExecuteCommand("R");

            // Assert
            var actualRoverPosition = plutoRover.ReportPosition();
            var expectedRoverPosition = "0,0,E";

            Assert.AreEqual(expectedRoverPosition, actualRoverPosition);
        }

        [Test]
        public void Rover_Should_Be_At_0_0_W_When_FRFRFRFRL_Command_Given()
        {
            // Arrange
            Domain.PlutoRover plutoRover = new Domain.PlutoRover();

            // Act
            plutoRover.ExecuteCommand("FRFRFRFRL");

            // Assert
            var actualRoverPosition = plutoRover.ReportPosition();
            var expectedRoverPosition = "0,0,W";

            Assert.AreEqual(expectedRoverPosition, actualRoverPosition);
        }

        [Test]
        public void Rover_Should_Move_On_The_Grid_As_A_Sphere()
        {
            // Arrange
            Domain.PlutoRover plutoRover = new Domain.PlutoRover();

            // Act
            plutoRover.ExecuteCommand("BBLFRR");

            // Assert
            var actualRoverPosition = plutoRover.ReportPosition();
            var expectedRoverPosition = "99,98,E";

            Assert.AreEqual(expectedRoverPosition, actualRoverPosition);
        }

        [Test]
        public void Rover_Should_Be_At_2_2_E_When_FFRFF_Command_Given()
        {
            // Arrange
            Domain.PlutoRover plutoRover = new Domain.PlutoRover();

            // Act
            plutoRover.ExecuteCommand("FFRFF");

            // Assert
            var actualRoverPosition = plutoRover.ReportPosition();
            var expectedRoverPosition = "2,2,E";

            Assert.AreEqual(expectedRoverPosition, actualRoverPosition);
        }
    }
}

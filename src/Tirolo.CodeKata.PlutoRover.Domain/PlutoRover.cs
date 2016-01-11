using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirolo.CodeKata.PlutoRover.Domain
{
    public class PlutoRover
    {
        public PlutoRover()
        {
            this.CurrentRoverPosition = new RoverPosition();
            this.CurrentRoverHeadingDirection = new RoverHeadingDirection();
        }

        public void ExecuteCommand(string commands)
        {
            commands = commands.ToUpper();

            foreach (var command in commands)
            {
                ExecuteCommand(command);
            }
        }

        public void ExecuteCommand(char command)
        {
            if (command.Equals('F'))
            {
                this.CurrentRoverPosition.MoveForwards(this.CurrentRoverHeadingDirection);
            }
            else if (command.Equals('B'))
            {
                this.CurrentRoverPosition.MoveBackwards(this.CurrentRoverHeadingDirection);
            }
            else
            {
                throw new NotSupportedException("Command not supported.");
            }
        }

        public object ReportPosition()
        {
            return string.Format("{0},{1},{2}", this.CurrentRoverPosition.X, this.CurrentRoverPosition.Y, Enum.GetName(typeof(RoverHeadingDirection.HeadingDirections), this.CurrentRoverHeadingDirection.HeadingDirection));
        }

        public RoverPosition CurrentRoverPosition { get; private set; }
        public RoverHeadingDirection CurrentRoverHeadingDirection { get; set; }
    }
}

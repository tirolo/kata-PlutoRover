using System;

namespace Tirolo.CodeKata.PlutoRover.Domain
{
    public class RoverPosition
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void MoveForwards(RoverHeadingDirection currentRoverHeadingDirection)
        {
            switch (currentRoverHeadingDirection.HeadingDirection)
            {
                default:
                case RoverHeadingDirection.HeadingDirections.N:
                        Y += 1;
                    break;
                case RoverHeadingDirection.HeadingDirections.E:
                        X += 1;
                    break;
                case RoverHeadingDirection.HeadingDirections.S:
                        Y -= 1;
                    break;
                case RoverHeadingDirection.HeadingDirections.W:
                        X -= 1;
                    break;
            }
        }
    }
}
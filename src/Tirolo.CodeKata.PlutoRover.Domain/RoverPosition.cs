using System;

namespace Tirolo.CodeKata.PlutoRover.Domain
{
    public class RoverPosition
    {
        public RoverPosition() : this(100, 100)
        {
        }

        public RoverPosition(int maxX, int maxY)
        {
            this.MaxX = maxX - 1; // Zero based
            this.MaxY = maxY - 1; // Zero based
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public void MoveForwards(RoverHeadingDirection currentRoverHeadingDirection)
        {
            switch (currentRoverHeadingDirection.HeadingDirection)
            {
                default:
                case RoverHeadingDirection.HeadingDirections.N:
                    if (Y == MaxY)
                    {
                        Y = 0;
                    }
                    else
                    {
                        Y += 1;
                    }
                    break;
                case RoverHeadingDirection.HeadingDirections.E:
                    if (X == MaxX)
                    {
                        X = 0;
                    }
                    else
                    {
                        X += 1;
                    }
                    break;
                case RoverHeadingDirection.HeadingDirections.S:
                    if (Y == 0)
                    {
                        Y = MaxY;
                    }
                    else
                    {
                        Y -= 1;
                    }
                    break;
                case RoverHeadingDirection.HeadingDirections.W:
                    if (X == 0)
                    {
                        X = MaxX;
                    }
                    else
                    {
                        X -= 1;
                    }
                    break;
            }
        }

        public void MoveBackwards(RoverHeadingDirection currentRoverHeadingDirection)
        {
            switch (currentRoverHeadingDirection.HeadingDirection)
            {
                default:
                case RoverHeadingDirection.HeadingDirections.N:
                    if (Y == 0)
                    {
                        Y = MaxY;
                    }
                    else
                    {
                        Y -= 1;
                    }
                    break;
                case RoverHeadingDirection.HeadingDirections.E:
                    if (X == 0)
                    {
                        X = MaxX;
                    }
                    else
                    {
                        X -= 1;
                    }
                    break;
                case RoverHeadingDirection.HeadingDirections.S:
                    if (Y == MaxY)
                    {
                        Y = 0;
                    }
                    else
                    {
                        Y += 1;
                    }
                    break;
                case RoverHeadingDirection.HeadingDirections.W:
                    if (X == MaxX)
                    {
                        X = 0;
                    }
                    else
                    {
                        X += 1;
                    }
                    break;
            }
        }
    }
}
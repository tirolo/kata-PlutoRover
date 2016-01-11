using System;
using System.ComponentModel;

namespace Tirolo.CodeKata.PlutoRover.Domain
{
    public class RoverHeadingDirection
    {
        public RoverHeadingDirection() : this(HeadingDirections.N)
        {
        }

        public RoverHeadingDirection(HeadingDirections headingDirection)
        {
            this.HeadingDirection = headingDirection;
        }
        
        public HeadingDirections HeadingDirection { get; private set; }

        public enum HeadingDirections
        {
            [Description("North")]
            N = 0,
            [Description("East")]
            E = 1,
            [Description("South")]
            S = 2,
            [Description("West")]
            W = 3
        }

        public void Spin(string direction)
        {
            int currentHeadingDirection = (int)this.HeadingDirection;

            if (string.Equals(direction.ToUpper(), "L"))
            {
                if (this.HeadingDirection == HeadingDirections.N)
                    this.HeadingDirection = HeadingDirections.W;
                else
                    this.HeadingDirection = (HeadingDirections)currentHeadingDirection - 1;
            }
        }
    }
}
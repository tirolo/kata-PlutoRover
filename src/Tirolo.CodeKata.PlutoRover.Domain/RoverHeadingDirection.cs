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
    }
}
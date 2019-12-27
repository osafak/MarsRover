using MarsRover.Library.Enum;

namespace MarsRover.Library.Helper
{
    public static class DirectionExtension
    {
        public static Directions FindLeft(this Directions input)
        {
            return (input - 1) < Directions.N ? Directions.W : input - 1;
        }

        public static Directions FindRight(this Directions input)
        {
            return (input + 1) > Directions.W ? Directions.N : input + 1;
        }
    }
}

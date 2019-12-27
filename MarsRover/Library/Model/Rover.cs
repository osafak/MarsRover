using System;
using MarsRover.Library.Enum;
using MarsRover.Library.Helper;

namespace MarsRover.Library.Model
{
    public interface IRover
    {
        void Process(string commands);

        string CurrentPosition();
    }

    public class Rover : IRover
    {
        private IPlateau RoverPlateau { get; }
        private IPosition RoverPosition { get; }
        private Directions RoverDirection { get; set; }

        public Rover(IPlateau roverPlateau, IPosition roverPosition, Directions roverDirection)
        {
            RoverDirection = roverDirection;
            RoverPlateau = roverPlateau;
            RoverPosition = roverPosition;
        }

        public void Process(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException($"Invalid value: {command}");
                }
            }
        }

        private void TurnLeft()
        {
            RoverDirection = RoverDirection.FindLeft();
        }

        private void TurnRight()
        {
            RoverDirection = RoverDirection.FindRight();
        }

        private void Move()
        {
            if (RoverDirection == Directions.N && RoverPosition.YLine < RoverPlateau.PlateauPosition.YLine)
            {
                RoverPosition.YLine++;
            }
            else if (RoverDirection == Directions.E && RoverPosition.XLine < RoverPlateau.PlateauPosition.XLine)
            {
                RoverPosition.XLine++;
            }
            else if (RoverDirection == Directions.S && RoverPosition.YLine > 0)
            {
                RoverPosition.YLine--;
            }
            else if (RoverDirection == Directions.W && RoverPosition.XLine > 0)
            {
                RoverPosition.XLine--;
            }
        }

        public string CurrentPosition()
        {
            return $"{RoverPosition.XLine} {RoverPosition.YLine} {RoverDirection}";
        }
    }
}

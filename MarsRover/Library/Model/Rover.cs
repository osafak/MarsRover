using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Library.Enum;

namespace MarsRover.Library.Model
{
    public interface IRover
    {
        IPlateau RoverPlateau { get; set; }
        IPosition RoverPosition { get; set; }
        Directions RoverDirection { get; set; }
        void Process(string commands);
        string ToString();

    }
    public class Rover : IRover
    {
        public IPlateau RoverPlateau { get; set; }
        public IPosition RoverPosition { get; set; }
        public Directions RoverDirection { get; set; }

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
                        throw new ArgumentException(string.Format("Invalid value: {0}", command));
                }
            }
        }

        private void TurnLeft()
        {
            RoverDirection = (RoverDirection - 1) < Directions.N ? Directions.W : RoverDirection - 1;
        }

        private void TurnRight()
        {
            RoverDirection = (RoverDirection + 1) > Directions.W ? Directions.N : RoverDirection + 1;
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

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", RoverPosition.XLine, RoverPosition.YLine, RoverDirection);
        }
    }
}

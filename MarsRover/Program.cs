using System;
using MarsRover.Library.Enum;
using MarsRover.Library.Model;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var plateauOne = new Plateau(new Position(5, 5));

            var firstRover = new Rover(plateauOne, new Position(1, 2), Directions.N);
            firstRover.Process("LMLMLMLMM");

            var secondRover = new Rover(plateauOne, new Position(3, 3), Directions.E);
            secondRover.Process("MMRMMRMRRM");

            Console.WriteLine(firstRover.CurrentPosition());

            Console.WriteLine(secondRover.CurrentPosition());
        }
    }
}

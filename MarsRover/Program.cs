using System;
using MarsRover.Library.Enum;
using MarsRover.Library.Model;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Plateau plateauOne = new Plateau(new Position(5, 5));
            Rover firstRover = new Rover(plateauOne, new Position(1, 2), Directions.N);
            firstRover.Process("LMLMLMLMM");

             
            
            Rover secondRover = new Rover(plateauOne, new Position(3, 3), Directions.E);
            secondRover.Process("MMRMMRMRRM");

            Console.WriteLine(firstRover.ToString());
            Console.WriteLine(secondRover.ToString());
        }
    }
}

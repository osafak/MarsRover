using System;
using MarsRover.Library.Enum;
using MarsRover.Library.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverUnitTest
{
    [TestClass]
    public class MarsRoverTest
    {

        [TestMethod]
        public void FirstRoverTest()
        {
            var plateauOne = new Plateau(new Position(5, 5));
            var rover = new Rover(plateauOne, new Position(1, 2), Directions.N);
            rover.Process("LMLMLMLMM");
            Assert.AreEqual(rover.CurrentPosition(), "1 3 N");
        }

        [TestMethod]
        public void SecondRoverTest()
        {
            var plateauOne = new Plateau(new Position(5, 5));
            var rover = new Rover(plateauOne, new Position(3, 3), Directions.E);
            rover.Process("MMRMMRMRRM");
            Assert.AreEqual(rover.CurrentPosition(), "5 1 E");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void InvalidInputTest()
        {
            Plateau plateauOne = new Plateau(new Position(5, 5));
            Rover secondRover = new Rover(plateauOne, new Position(3, 3), Directions.E);
            secondRover.Process("MMLLMRMA");
        }
    }
}

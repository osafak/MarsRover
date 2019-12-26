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
            Plateau plateauOne = new Plateau(new Position(5, 5));
            Rover firstRover = new Rover(plateauOne, new Position(1, 2), Directions.N);
            firstRover.Process("LMLMLMLMM");
            Assert.AreEqual(firstRover.ToString(), "1 3 N");
        }
        [TestMethod]
        public void SecondRoverTest()
        {
            Plateau plateauOne = new Plateau(new Position(5, 5));
            Rover secondRover = new Rover(plateauOne, new Position(3, 3), Directions.E);
            secondRover.Process("MMRMMRMRRM");
            Assert.AreEqual(secondRover.ToString(), "5 1 E");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void InvalidýnputTest()
        {
            Plateau plateauOne = new Plateau(new Position(5, 5));
            Rover secondRover = new Rover(plateauOne, new Position(3, 3), Directions.E);
            secondRover.Process("MMLLMRMA");
        }
    }
}

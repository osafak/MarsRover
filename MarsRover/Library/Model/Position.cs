using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Library.Model
{
    public interface IPosition
    {
        int XLine { get; set; }
        int YLine { get; set; }
    }
    public class Position : IPosition
    {
        public int XLine { get; set; }
        public int YLine { get; set; }

        public Position(int x,int y)
        {
            XLine = x;
            YLine = y;
        }
    }
}

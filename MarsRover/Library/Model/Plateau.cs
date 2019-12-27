using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Library.Model
{
    public interface IPlateau
    {
        IPosition PlateauPosition { get; }
    }
    public class Plateau : IPlateau
    {
        public IPosition PlateauPosition { get; private set; }

        public Plateau(IPosition position)
        {
            PlateauPosition = position;
        }
    }
}

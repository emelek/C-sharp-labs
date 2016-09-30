using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Regular_Polygon: Figure
    {
        public int numberOfSides { get; set; }
        public double sizeOfSides { get; set; }
        public const double pi = 3.14;

        public override double GetArea()
        {
            return 1/(Math.Tan(pi/numberOfSides)) * sizeOfSides * sizeOfSides * (numberOfSides / 4);
        }
    }
}

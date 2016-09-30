using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Rhombus: Figure
    {
        public double longestDiagonal { get; set; }
        public double shortestDiagonal { get; set; }

        public override double GetArea()
        {
            return longestDiagonal * shortestDiagonal * 0.5;
        }
    }
}

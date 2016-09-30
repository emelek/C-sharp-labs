using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Triangle: Figure
    {
        public double baseTriangle { get; set; }
        public double altitudeTriangle { get; set; }

        public override double GetArea()
        {
            return 0.5 * baseTriangle * altitudeTriangle;
        }
    }
}

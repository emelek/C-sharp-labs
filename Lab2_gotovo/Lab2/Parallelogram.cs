using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lab2
{
    class Parallelogram: Figure
    {
        public double aSide { get; set; }
        public double bSide { get; set; }
        public double angleA { get; set; }

        public override double GetArea()
        {
            return aSide*bSide*Math.Cos(angleA);
        }
    }
}

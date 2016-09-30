using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Trapeze: Figure
    {
        public double topBase { get; set; }
        public double bottomBase { get; set; }
        public double altitudeTrapeze { get; set; }

        public override double GetArea()
        {
            return topBase * bottomBase * altitudeTrapeze * 0.5;
        }
    }
}

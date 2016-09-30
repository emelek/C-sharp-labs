using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Rectangle: Figure
    {
        public double width { get; set; }
        public double height { get; set; }

        public override double GetArea()
        {
            return width * height;
        }
    }
}

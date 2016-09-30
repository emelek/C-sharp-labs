using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Circle: Figure
    {
        public double radius { get; set; }
        public const double pi = 3.14;
        
        public override double GetArea()
        {
            return radius * radius * pi;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public abstract class Figure
    {
        public string name { get; set; }

        public abstract double GetArea();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Student
    {
        public string name { get; set; }
        public double age { get; set; }
        public bool sex { get; set; }
        public string colourHair { get; set; }

        public void Add(Student x)
        {
            age += x.age;
            name =name + " and " + x.name;
            colourHair = colourHair + " and " + x.colourHair;
        }
    }
}
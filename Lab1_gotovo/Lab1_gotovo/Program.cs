using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student() { name = "Bob", age = 13, sex = true, colourHair = "Black" };
            Student b = new Student() { name = "Mayson", age = 12, sex = true, colourHair = "Red" };
            Student c = new Student() { name = "Marta", age = 14, sex = false, colourHair = "Brown" };
            
            a.Add(b);
            Console.WriteLine("{0}\n{1} years per person\n{2} and {3}\n{4}", a.name,a.age/2,a.sex,b.sex,a.colourHair);
            
            a.Add(c);
            Console.WriteLine();
            Console.WriteLine("{0}\n{1} years per person\n{2} and {3} and {4}\n{5}", a.name, a.age / 3, a.sex, b.sex, c.sex, a.colourHair);
            
            Console.Read();
        }
    }
}

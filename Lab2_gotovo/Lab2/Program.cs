using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лаба 2");
            Console.WriteLine("Выполнил Сидоренко Михаил");

            Rectangle a = new Rectangle()
            {
                name = "Прямоугольник А", width = 15.2, height = 13.7
            };

            Rectangle b = new Rectangle()
            {
                name = "Прямоугольник Б",
                width = 5.1,
                height = 2.8
            };

            Circle c = new Circle()
            {
                name = "Круг С", radius = 17.1
            };

            Triangle d = new Triangle()
            {
                name = "Треугольник Д", 
                baseTriangle= 3.3,
                altitudeTriangle = 5.12
            };

            Trapeze e = new Trapeze()
            {
                name = "Трапеция Е",
                altitudeTrapeze = 2.4,
                bottomBase = 1.3,
                topBase = 9
            };

            Rhombus f = new Rhombus()
            {
                name = "Ромб Ф",
                longestDiagonal = 10.4,
                shortestDiagonal = 4.2
            };

            Parallelogram g = new Parallelogram()
            {
                name = "Параллелограмм Г",
                angleA = 30,
                aSide = 8.8,
                bSide = 4.5
            };

            Regular_Polygon h = new Regular_Polygon()
            {
                name = "Правильный пятиугольник Х",
                numberOfSides = 5,
                sizeOfSides = 3.9
            };

            Regular_Polygon j = new Regular_Polygon()
            {
                name = "Правильный пятиугольник Ж",
                numberOfSides = 10,
                sizeOfSides = 1.8
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", a.name);
            Console.WriteLine("Площадь: {0}", a.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", b.name);
            Console.WriteLine("Площадь: {0}", b.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", c.name);
            Console.WriteLine("Площадь: {0}", c.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", d.name);
            Console.WriteLine("Площадь: {0}", d.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", e.name);
            Console.WriteLine("Площадь: {0}", e.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", f.name);
            Console.WriteLine("Площадь: {0}", f.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", g.name);
            Console.WriteLine("Площадь: {0}", g.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", h.name);
            Console.WriteLine("Площадь: {0}", h.GetArea()); Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", j.name);
            Console.WriteLine("Площадь: {0}", j.GetArea());
            Console.ReadKey();
        }
    }
}
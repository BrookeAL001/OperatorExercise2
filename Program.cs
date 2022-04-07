using System;

namespace OperatorExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            Console.WriteLine("What is the radius of your circle");
            var radius = double.Parse(Console.ReadLine());

            var areaOfCircle = CalculateArea(radius);

            { Console.WriteLine($"The area of a circle with a radius of {radius} is {areaOfCircle}"); }
        }

        public static double CalculateArea(double radius) 
        {
            return Math.PI * (radius * radius);
        }
    }
}

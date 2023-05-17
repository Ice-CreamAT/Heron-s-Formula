using System;
using System.Xml.Linq;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Write your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            DateTime now = DateTime.Now;
            Console.WriteLine(" The date is " + now.ToLongDateString());

            double xA, xB, xC, yA, yB, yC;


            Console.WriteLine("Enter the measurements of triangle X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the measurements of triangle Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + yC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("X Area = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Y Area = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("The X Triangle is larger");
            }

            else
            {
                Console.WriteLine("The X Triangle is larger");
            }





        }
    }

}
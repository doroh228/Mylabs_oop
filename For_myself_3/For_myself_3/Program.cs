using System;
using System.Collections.Generic;

namespace For_myself_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car(){Name="Ford",Number="A001AA01"},
                new Car(){Name="LADA",Number="B727ET77"}
            };
            var parking = new Parking();

            foreach (var car in cars)
            {
                parking.Add(car);
            }

            Console.WriteLine(parking["A001AA01"]?.Name);
            Console.WriteLine(parking["A001AA02"]?.Name);
            
            Console.ReadLine();
        }
    }
}

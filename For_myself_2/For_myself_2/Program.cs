using System;
using System.Collections.Generic;

namespace For_myself_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            var input = Console.ReadLine();

            if(int.TryParse(input, out int result))
            {
                //var isEven = IsEven(result);
               
                if (result.IsEven())
                {
                    Console.WriteLine("Чётное число ");
                }
                else
                {
                    Console.WriteLine("Нечётное");
                }
            }
            else
            {
                Console.WriteLine("пургу гонишь");
            }

            int h = 182;

            if (h.IsDividedBy(2))
            {
                Console.WriteLine("Делиться");
            }
            else
            {
                Console.WriteLine("NoDivided");
            }

            var roads = new List<Road>();
            for (int i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreatRandomRoad(1000, 10000);
                roads.Add(road);
            }
            var roadsName = roads.ConvertToString();
            Console.WriteLine(roadsName);


            Console.ReadLine();
        }
    }
}

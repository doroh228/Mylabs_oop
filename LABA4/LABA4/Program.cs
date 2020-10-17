using System;

namespace LABA4
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Красное яблоко", 100, 100);
            Apple apple2 = new Apple("Зелённое яблоко", 90, 110);

            var sumApple = apple + apple2;
            var minApple = apple - apple2;

            Console.WriteLine(sumApple);
            Console.WriteLine(minApple);

            Console.ReadLine();
        }
    }
}

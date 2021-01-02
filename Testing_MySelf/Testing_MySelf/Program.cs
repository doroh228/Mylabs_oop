using System;
using System.Threading;

namespace Testing_MySelf
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = 10;
            int y = 15;
            Addition(ref x, y); // вызов метода
            Console.WriteLine(x);   // 25

            Console.ReadLine();
        }
        // параметр x передается по ссылке
        static void Addition(ref int x, int y)
        {
            x += y;
        }

    }


}

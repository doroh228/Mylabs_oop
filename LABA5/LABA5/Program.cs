using System;

namespace LABA5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Plans flower1 = new rose_flower("Rose","Red",15.0);
            Plans[] plans = new Plans[10];
            plans[1] = new rose_flower("Rose", "Red", 15.0);
            Console.WriteLine(plans[1]);
            ((Iflower)plans[1]).DoClone();
            ((flower)plans[1]).DoClone();
            Console.WriteLine();
            if(((flower)plans[1]).Name is string)
            {
                Console.WriteLine("good");
            }
            flower obj1 = plans[1] as flower;
            Console.WriteLine(obj1);
            Console.WriteLine();
            Console.WriteLine("new flower");
            plans[2] = new Gladiolus("Gladiolus", "Yellow", 5);
            Console.WriteLine(plans[2]);
        }
    }
}

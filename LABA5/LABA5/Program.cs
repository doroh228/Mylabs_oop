using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

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
            if (((flower)plans[1]).Name is string)
            {
                Console.WriteLine("good");
            }
            flower obj1 = plans[1] as flower;
            Console.WriteLine(obj1);
            Console.WriteLine();
            Console.WriteLine("new flower");
            plans[2] = new Gladiolus("Gladiolus", Enum.Yellow, 5);
            Console.WriteLine(plans[2]);
            Console.WriteLine();
            plans[3] = new Bouquet(plans[1], plans[2]);
            Console.WriteLine(plans[3]);

            Struct_Client client = new Struct_Client("Sergo", 15, plans[3]);


            Console.WriteLine();
            Console.WriteLine(client);

            Agency agency = new Agency();
            agency.AddItem(plans[1]);
            agency.AddItem(plans[2]);
            agency.AddItem(plans[2]);
            Controller.Sum(agency._container);

            agency.Delete(plans[1]);
            agency.Delete(plans[2]);
            agency.Delete(plans[2]);

            plans[4] = new Paper();
            ((Paper)plans[4]).Weight = 1 ;
        }

    }
       
}


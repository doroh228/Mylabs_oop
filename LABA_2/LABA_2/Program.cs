using InviteCustomer;
using System;

namespace LABA_2
{
    class Program
    {
        static void Main(string[] args)
        {


            /*Customer[] cust = new Customer[10];
            cust[0] = new Customer();
            cust[1] = new Customer();
            cust[2] = new Customer();
            long a = 42250189221;
            for(int i = 0; i < 3; i++)
            {

                cust[i].NumbersKard = a;
                Console.WriteLine($"номер карты {i}-го чела = {cust[i].NumbersKard}");
                a++;
            }*/
            Customer cust1 = new Customer(1, "Drugov", "Anton", "Bek", 4255200354322348, 2000);
            Console.WriteLine(Customer.Id);
            Console.WriteLine(cust1.Balance);

            Customer cust2 = new Customer(justTry: true);
            Console.WriteLine(Customer.Id);
            Console.WriteLine(cust2.Balance);

            Customer cust3 = new Customer();

            Console.WriteLine(cust3.NumbersKard);
            if (cust1.Balance == cust2.Balance)
            {
                Console.WriteLine($"user {cust1.First_name} and user {cust2.First_name} have equal amount money");
            }
            Console.WriteLine($"Prrson how have this numders of card it");
            for (int i = 1; i < +Customer.Id; i++)
            {
                if (findKard(4255200354322346, 4255200354322349, cust1.NumbersKard))
                {
                    Console.WriteLine(cust1.NumbersKard);
                }
            }
            Console.ReadKey();
            Person p1 = new Person("Bill");
            p1.Display(); // вызов метода Display из класса Person

            Employee p2 = new Employee("Tom", "Microsoft");
            p2.Display(); // вызов метода Display из класса Person

            Console.ReadKey();

            var someType = new { Name = "Anna" };
        }

        static bool findKard(long firstLess, long secondMore, long kard)
        {
            if (firstLess <= kard && kard <= secondMore)
            {
                return true;
            }
            else
                return false;
        }
        public void fun1(ref int a, out int out1)
        {
            a = +1;
            out1 = a + 1;
        }

        class Person
        {
            public string Name { get; set; }
            public Person(string name)
            {
                Name = name;
            }
            public virtual void Display()
            {
                Console.WriteLine(Name);
            }
        }
        class Employee : Person
        {
            public string Company { get; set; }
            public Employee(string name, string company) : base(name)
            {
                Company = company;
            }
        }
    }
}

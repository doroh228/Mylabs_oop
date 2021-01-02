using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LABA_10
{
    interface IEnumerable<T>
    {
        void AddEl(T el);
        void DelEl(int key);
        void Find(int key);
        void Print();
    }

    class Worker : IEnumerable<Worker>
    {
        public static int Ip = 0;
        public int ip = 0;
        public int Efficiency { get; set; }

        public Worker()
        {
            Ip++;
            ip = Ip;
        }

        public Worker(int efficiency)
        {
            Efficiency = efficiency;
            Ip++;
            ip = Ip;
        }
        Hashtable list = new Hashtable();

        public void Hash()
        {
            Console.WriteLine(GetHashCode());
        }

        public override string ToString()
        {
            return $"Работник имеет КПД = {Efficiency}%";
        }

        public void AddEl(Worker el)
        {
            Ip++;
            list.Add(Ip, el);
        }

        public void DelEl(int key)
        {
            list.Remove(key);
        }

        public void Find(int key)
        {
            ICollection keys = list.Keys;
            foreach (int s in keys)
            {
                if (s == key)
                {
                    Console.WriteLine($"Был найден ключ: {s} со значение {list[s]}");
                }
                else
                {
                    Console.WriteLine("NotFound");
                }
            }
        }

        public void Print()
        {
            ICollection keys = list.Keys;

            foreach (int s in keys)
                Console.WriteLine(s + ": " + list[s]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Worker worker1 = new Worker(73);
            Worker worker2 = new Worker(50);
            Worker worker3 = new Worker(10);
            Worker worker4 = new Worker(89);


            Hashtable workers = new Hashtable();

            workers.Add(worker1.ip, worker1);
            workers.Add(worker2.ip, worker2);
            workers.Add(worker3.ip, worker3);
            workers.Add(worker4.ip, worker4);

            ICollection keys = workers.Keys;

            foreach (int s in keys)
            {
                Console.WriteLine(s + ": " + workers[s]);
            }
            Console.WriteLine();
        }
    }
}

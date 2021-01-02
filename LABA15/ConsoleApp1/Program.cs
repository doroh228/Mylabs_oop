using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var allProcess = Process.GetProcesses();
            foreach (var item in allProcess)
            {
                var threadsProcess = item.Threads;
                Console.WriteLine($"Id: {item.Id}, Name: {item.ProcessName}, ");
                foreach (ProcessThread thread in threadsProcess)
                {
                    Console.Write($"Priorety: {thread.CurrentPriority}");
                    break;
                }
                break;
            }
            AppDomain domain = AppDomain.CurrentDomain;
            Console.WriteLine($"Nama: {domain.FriendlyName}");
            Console.WriteLine($"Base Directory: {domain.BaseDirectory}");
            Assembly[] assemblies = domain.GetAssemblies();
            foreach (var item in assemblies)
            {
                Console.WriteLine(item.GetName().Name);
            }

            Thread th1 = new Thread(ThreadClass.Func1);
            Thread th2 = new Thread(ThreadClass.Func2);
            th1.Start();
            th2.Start();
            Thread.Sleep(3000);
            th1.Abort();
            th2.Abort();
        }
        
    }
    static public class ThreadClass
    {
        public static void Func1()
        {
            try
            {
                for (int i = 1; i < 1000; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine("Abort");
            }
        }
        public static void Func2()
        {
            try
            {
            for (int i = 1; i < 1000; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Abort");
            }
        }
    }
}

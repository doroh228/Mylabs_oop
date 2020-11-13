using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace LABA_8
{
    class Program
    {
        interface IEat<T>
        {
            void AddItem(T item);

            void DeleteItem(int position);

            void Show();
        }

        public class Product
        {
            public string Name { get; set; }

            public int Value { get; set; }

            public int Mass { get; set; }
            public Product()
            {

            }
            public Product(string name, int value, int mass)
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException("пустая строка");
                }
                else
                {
                    Name = name;
                }
                Value = value;
                Mass = mass;
            }
            public override string ToString()
            {
                return $"Product = {Name}, Value = {Value}, Mass = {Mass}";
            }
        }
            public class Mylist<T>:IEnumerable<T> ,IEat<T>where T: new()
        {
            List<T> list = new List<T>();
            public void AddItem(T item)
            {
                list.Add(item);
            }
           
            public void DeleteItem(int position)
            {
                list.RemoveAt(position - 1);
            }

            public void Show()
            {
                foreach (T item in list)
                {
                    Console.WriteLine($"{item}");
                }
            }


            public override string ToString()
            {
                string str = "";
                foreach (T el in list)
                {
                    str += $"{el} ";
                }
                return str;
            }


            public IEnumerator<T> GetEnumerator()
            {
                return ((IEnumerable<T>)list).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)list).GetEnumerator();
            }

            public class Date
            {
                public DateTime date { get; set; } = new DateTime();
                public Date()
                {
                    date = DateTime.Now;
                }
            }
            Date date = new Date();


            public static Mylist<T> operator +(Mylist<T> list, Mylist<T> Item)
            {
                Mylist<T> result = new Mylist<T>();
                foreach (T item in list) result.AddItem(item);
                foreach (T item in Item) result.AddItem(item);
                return result;
            }
        }

        public class Apple : Product
        {
            public Apple(string name, int value, int mass)
            {
                Name = name;
                Value = value;
                Mass = mass;
            }

        }

        


        static void Main(string[] args)
        {
            try
            {
                Mylist<Product> product1 = new Mylist<Product>();


                Product prod1 = new Product("Банан", 100, 100);
                Product prod2 = new Product("Яблоко", 150, 90);
                product1.AddItem(prod1);
                product1.AddItem(prod2);
                Console.WriteLine(product1);
                Console.WriteLine();
                product1.Show();


                FileStream file = new FileStream("d:\\kurs\\LABS\\infotext.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(prod1.ToString());
                writer.Write("\n");
                writer.Write(prod2.ToString());
                writer.Write("\n");
                writer.Close();
                FileStream file1 = new FileStream("d:\\kurs\\LABS\\infotext.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file);
                Console.WriteLine(reader.ReadToEnd());
                reader.Close();
            }
            finally
            {
                Console.WriteLine("End");
            }

        }
    }
}

using System;
using System.IO;
using System.Reflection;

namespace LABA_12
{
    class Program
    {
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

        static public class Reflector
        {
            static public void Build(object obj)
            {
                using (StreamWriter sw = new StreamWriter(@"info.txt", true))
                {
                    sw.WriteLine("Имя сборки:");
                    Type type = obj.GetType();
                    sw.WriteLine(type.Assembly.GetName().Name);
                    sw.WriteLine("\n");
                }
            }

            static public void Constructs(object obj)
            {
                using(StreamWriter sw = new StreamWriter(@"info.txt", true))
                {
                    sw.WriteLine("Конструткоры:");
                    Type type = obj.GetType();
                    foreach (ConstructorInfo item in type.GetConstructors())
                    {
                        sw.WriteLine(item.ReflectedType.Name);
                    }
                    sw.WriteLine("\n");
                }
            }

            static public void Methods(object obj)
            {
                using (StreamWriter sw = new StreamWriter(@"info.txt", true))
                {
                    sw.WriteLine("Методы:");
                    Type type = obj.GetType();
                    foreach (MethodInfo item in type.GetMethods())
                    {
                        sw.WriteLine(item.Name);
                    }
                    sw.WriteLine("\n");
                }
            }
            static public void Interfaces(object obj)
            {
                using (StreamWriter sw = new StreamWriter(@"info.txt", true))
                {
                    sw.WriteLine("Интерфейсы");
                    Type type = obj.GetType();
                    foreach (Type item in type.GetInterfaces())
                    {
                        sw.WriteLine(item.Name);
                    }
                    sw.WriteLine("\n");
                }
            }
            static public void MethodsWithParam(object obj, string str)
            {
                using (StreamWriter sw = new StreamWriter(@"info.txt", true))
                {
                    Type type = obj.GetType();
                    sw.WriteLine("Методы с параметрами:");
                    foreach (MethodInfo item in type.GetMethods())
                    {
                        foreach (ParameterInfo el in item.GetParameters())
                        {
                            if (el.Name.Contains(str))
                            {
                                sw.WriteLine(el.Name);
                            }
                        }
                    }
                    sw.WriteLine("\n");
                }
            }
            static public void RunMethod<T>(object obj, string str) where T : class
            {
                using (StreamReader sr = new StreamReader(@"info.txt"))
                {
                    string par = sr.ReadLine();
                    Type type = obj.GetType();
                    MethodInfo info = type.GetMethod(str);
                    object objj = Activator.CreateInstance(typeof(T));
                    info.Invoke(objj, new object[] { par });
                }
            }

            static public T Create<T>(object obj) where T : class
            {
                var constr = obj.GetType().GetConstructor(new Type[] { });
                if (constr != null)
                {
                    return (T)constr.Invoke(new object[] { });
                }
                return default(T);
            }
        }

        static void Main(string[] args)
        {
            Product product = new Product("Persik", 100, 100);
            Reflector.Build(product);
            Reflector.Constructs(product);
            Reflector.Interfaces(product);
            Reflector.Methods(product);
            Reflector.MethodsWithParam(product, "str");
            Reflector.RunMethod<Product>(product, "GetInfo");
            Reflector.Create<Product>(product);
        }
    }
}

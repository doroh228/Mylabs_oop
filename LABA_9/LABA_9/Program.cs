using System;

namespace LABA_9
{

    public class Person
    {
        /// <summary>
        /// Задаём Имя Человеку
        /// </summary>
        string name;
        public string Name
        {
            get
            {
                if (name == null)
                {
                    return "";
                }
                else
                {
                    return name;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Имя введено не коректно");
                }
                else
                {
                    name = value;
                }
            }
        }

        /// <summary>
        /// Задаём Должность человеку
        /// </summary>
        string position;
        public string Position
        {
            get
            {
                if (position == null)
                {
                    return "";
                }
                else
                {
                    return position;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Должность введена не коректно");
                }
                else
                {
                    position = value;
                }
            }
        }

        /// <summary>
        /// Задаём зарплату человеку
        /// </summary>
        decimal salary;
        decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Некоректное значение");
                }
                else
                {
                    salary = value;
                }
            }
        }
           
        /// <summary>
        /// задаёи события
        /// </summary>

        public event EventHandler Raising;

        public event EventHandler Fine;



        public Person()
        {

        }

        public Person(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public void fRaising(decimal howMuch)
        {
            Raising?.Invoke(this,null);
            Salary += howMuch;
        }  
        public void fFine(decimal howMuch)
        {
            Fine?.Invoke(this, null);
            Salary -= howMuch;
        }
        public override string ToString()
        {
            return $"{Name} занимает должность - {Position}, c зарплатой - {Salary}$";
        }
    }

    public class Director
    {

        public void DoRasing(Person person, decimal howmuch,bool what)
        {
            if (what)
            {
                person.fRaising(howmuch);
            }
            else
            {
                person.fFine(howmuch);
            }
        }
    }



        class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Director director1 = new Director();

                Person person1 = new Person("Толик", "Столер", 80m);
                Person person2 = new Person("Виталя", "Главный-Столер", 140m);

                person1.Fine += Person1_Fine;
                person1.Raising += Person1_Raising;
                person2.Fine += Person2_Fine;
                Console.WriteLine(person1);
                Console.WriteLine(person2);

                director1.DoRasing(person1, 10m, true);
                director1.DoRasing(person2, 25m, false);
                Console.WriteLine();
                Console.WriteLine(person1);
                Console.WriteLine();
                Console.WriteLine(person2);
            }
            catch (ArgumentNullException x)
            {
                Console.WriteLine(x);
            }
            catch(Exception x)
            {
                Console.WriteLine(x);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Работа программы завершена ");
            }
        }

        private static void Person2_Fine(object sender, EventArgs e)
        {
            Console.WriteLine($"{((Person)sender).Position} {((Person)sender).Name} был понижен!");
        }

        private static void Person1_Raising(object sender, EventArgs e)
        {
            Console.WriteLine( $"{((Person)sender).Position} {((Person)sender).Name} был повышен!");
        }

        private static void Person1_Fine(object sender, EventArgs e)
        {
            Console.WriteLine($"{((Person)sender).Position} {((Person)sender).Name} был Оштрафован!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LABA_11
{
    class Program
    {
        static Random rnd = new Random();
        class Player
        {
            public string Name { get; set; }
            public string Team { get; set; }
        }
        class Team
        {
            public string Name { get; set; }
            public string Country { get; set; }
        }


        static void Main(string[] args)
        {
            #region for_example
            /*var rnd = new Random();
            var collection = new List<Product>();

            for (int i = 0; i < 10; i++)
            {
                var product = new Product
                {
                    Name = "Product" + i,
                    Energy = rnd.Next(10, 12)
                };
                collection.Add(product);
            }

            var result = from item in collection
                         where item.Energy < 200
                         select item;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var result2 = collection.Where(item => item.Energy < 200);
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadLine();

            var selectCollection = collection.Select(item => item.Energy).OrderBy(item=>item);
            foreach (var item in selectCollection) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadLine();


            var groupByCollection = collection.GroupBy(item => item.Energy);
            foreach (var group in groupByCollection)
            {
                Console.WriteLine($"Key: {group.Key}");
                foreach (var item in group)
                {
                    Console.Write($"\t Value: {item}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
            collection.Reverse();
            
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine( collection.All(item => item.Energy == 10));//only all
            Console.WriteLine(collection.Any(item => item.Energy == 10));//хотя бы один 


            Console.WriteLine(collection.Contains(collection[5]));//проверяет наналичие экземпляра в коллекции


            collection.Distinct();//удаляет повторяющиеся

            var array = new int[] { 1, 2, 3, 4 };
            var array1 = new int[] {3, 4, 5, 6 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            var union = array.Union(array1);//обьеденение без повторений
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var intersect = array.Intersect(array1);// только повторения выводит

            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var except = array.Except(array1);// есть в 1 но нет во втором
            foreach (var item in except)
            {
                Console.WriteLine(item);
            }*/
            #endregion

            string[] mounth = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September","October","November","December" };
            Console.WriteLine("Input n");
            var N = int.Parse(Console.ReadLine());
            var result1 = mounth.Where(item => item.Length < N);
            foreach (var item in result1)
            {
                Console.Write($"{item} \t");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");

            var result2 = mounth.Where(item=> item== "January" || item == "February" || item == "December" || item == "June" || item == "July" || item == "August");
            foreach (var item in result2)
            {
                Console.Write($"{item} \t");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");

            var result3 = mounth.OrderBy(item => item).ToArray();
            foreach (var item in result3)
            {
                Console.Write($"{item} \t");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");

            var collection = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                var product = new Product
                {
                    Name = "Product" + i,
                    Energy = rnd.Next(10, 500)
                };
                collection.Add(product);
            }

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            var sortCollectionByEnergy = collection.Where(item => item.Energy < 100 || item.Energy > 350).OrderBy(item=>item.Energy);
            foreach (var item in sortCollectionByEnergy)
            {
                Console.WriteLine($"\t {item}");
            }

            List<Team> teams = new List<Team>()
{
                new Team { Name = "Бавария", Country ="Германия" },
                new Team { Name = "Барселона", Country ="Испания" }
};
            List<Player> players = new List<Player>()
{
                new Player {Name="Месси", Team="Барселона"},
                new Player {Name="Неймар", Team="Барселона"},
                new Player {Name="Роббен", Team="Бавария"}
};

            var result = from pl in players
                         join t in teams on pl.Team equals t.Name
                         select new { Name = pl.Name, Team = pl.Team, Country = t.Country };

            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.Team} ({item.Country})");

        }


    }
}

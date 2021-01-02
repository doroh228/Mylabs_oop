using System;
using System.Collections.Generic;
using System.Text;

namespace LABA_14
{
    [Serializable]
    public class Group
    {
        [NonSerialized]
        private readonly Random rnd = new Random(DateTime.Now.Millisecond);
        
        public string Name { get; set; }
        public int Number { get; set; }

        public Group()
        {
            Number = rnd.Next(1, 10);
            Name = "Группа " + rnd;
        }

        public Group(string name, int number)
        {
            //проверку

            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Number-{Number}";
        }
    }
}

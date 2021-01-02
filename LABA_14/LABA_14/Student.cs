using System;
using System.Collections.Generic;
using System.Text;

namespace LABA_14
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public Group group { get; set; }

        public Student(string name, int age)
        {
            //прокверка входных параметров

            Name = name;
            Age = age;
        }


        public override string ToString()
        {
            return $"Name: {Name}, Age {Age}";
        }
    }
}

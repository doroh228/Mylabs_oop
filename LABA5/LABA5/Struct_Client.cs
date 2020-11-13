using System;
using System.Collections.Generic;
using System.Text;

namespace LABA5
{
    public struct Struct_Client
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public double Info_about_buy { get; set; }

        public Struct_Client(string name, int age, Plans plans)
        {
            Name = name;
            Age = age;
            Info_about_buy = ((flower)plans).HowMuch;
        }
        public override string ToString()
        {
            return $"Имя покупвателя: {Name}, Возраст: {Age}; Сколько должен за букет: {Info_about_buy}";
        }
    }
}

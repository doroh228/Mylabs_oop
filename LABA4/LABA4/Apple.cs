using System;
using System.Collections.Generic;
using System.Text;

namespace LABA4
{
    public class Apple : Set
    {
        public Apple(string name, int caloria, int volume) : base(name, caloria, volume)
        {

        }

        public Apple Add(Apple apple1, Apple apple2)
        {
            var calories = (int)Math.Round((apple1.Caloria + apple2.Caloria) / 2.0);
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", calories, volume);
            return apple;
        }
        public static Apple operator +(Apple apple1, Apple apple2)
        {
            var calories = (int)Math.Round((apple1.Caloria + apple2.Caloria) / 2.0);
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", calories, volume);
            return apple;
        }

        public Apple Comparison(Apple apple1, Apple apple2)
        {
            var calories = (int)Math.Round((apple1.Caloria - apple2.Caloria) / 1.0);
            var volume = apple1.Volume - apple2.Volume;
            var apple = new Apple("Разница",calories, volume);
            return apple;
        }

        public static Apple operator -(Apple apple1, Apple apple2)
        {
            var calories =0;
            if(apple1.Caloria > apple2.Caloria)
            {
                calories = apple1.Caloria - apple2.Caloria;
            }
            else
            {
                calories = apple2.Caloria - apple1.Caloria;
            }
            var volume = 0;
            if (apple1.Volume > apple2.Volume)
            {
                volume = apple1.Volume - apple2.Volume;
            }
            else if (apple1.Volume < apple2.Volume)
            {
                volume = apple2.Volume - apple1.Volume;
            }
            var apple = new Apple("Разница", calories, volume);
            return apple;
        }
        public static bool operator > (Apple apple1, Apple apple2)
        {
            if (apple1.Volume > apple2.Volume)
                return true;
            else
                return false;
        }

        public static bool operator <(Apple apple1, Apple apple2)
        {
            if (apple1.Volume < apple2.Volume)
                return true;
            else
                return false;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LABA5
{
    class rose_flower : flower,Iflower
    {
        public rose_flower(string name, string color, double howmuch)
        {
            Name = name;
            Color = color;
            HowMuch = howmuch;
        }

        void Iflower.DoClone()
        {
            Console.WriteLine("it's interface");
        }
        public override void DoClone()
        {
            Console.WriteLine("it's abstract class");
        }
    }
}

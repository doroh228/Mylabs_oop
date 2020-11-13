using System;
using System.Collections.Generic;
using System.Text;

namespace LABA5
{
    class Gladiolus:flower
    {
        public Enum colors { get; set; }
        public Gladiolus(string name, Enum color, double howmuch)
        {
            Name = name;
            colors = color;
            HowMuch = howmuch;
        }
        public override void DoClone()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Flower: " + Name + "; Color: " + colors + "; HowMuch: " + HowMuch + "$";
        }
    }
}

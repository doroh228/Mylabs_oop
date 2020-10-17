using System;
using System.Collections.Generic;
using System.Text;

namespace LABA5
{
    class Gladiolus:flower
    {
        public Gladiolus(string name, string color, double howmuch)
        {
            Name = name;
            Color = color;
            HowMuch = howmuch;
        }
        public override void DoClone()
        {
            throw new NotImplementedException();
        }
    }
}

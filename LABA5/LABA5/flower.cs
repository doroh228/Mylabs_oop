using System;
using System.Collections.Generic;
using System.Text;

namespace LABA5
{
    interface Iflower
    {
        public void DoClone();
    }

    abstract class flower:Plans
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public double HowMuch { get; set; }

        public abstract void DoClone();
        public override string ToString()
        {
            return "Flower: " + Name + "; Color: " + Color + "; HowMuch: " + HowMuch + "$";
        }
    }
}

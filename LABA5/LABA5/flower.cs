using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LABA5
{
    interface Iflower
    {
        public void DoClone();
    }

    public class Exceptions
    {
        public class HowMuchException : Exception
        {
            public HowMuchException(string message) : base(message)
            {

            }
        }
        public class ColorException : ArgumentException
        {
            public string Color { get; }
            public ColorException(string message, string val) : base(message)
            {
                Color = val;
            }
        }
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

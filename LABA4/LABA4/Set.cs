using System;
using System.Collections.Generic;
using System.Text;

namespace LABA4
{
    public  abstract class Set
    {
        public string Name { get; }

        public int Caloria { get; }

        public int Volume { get; set; }

        public int Enargy
        {
            get
            {
                return Volume * Caloria / 100;
            }
        }
        public Set(string name, int caloria, int volume)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (caloria<=0)
            {
                throw new ArgumentException(nameof(caloria));
            }
            if (volume<0)
            {
                throw new ArgumentException(nameof(volume));
            }
            Name = name;
            Caloria = caloria;
            Volume = volume;
        }

        public override string ToString()
        {

            return $"{Name}. Калорийность: {Caloria}, Объём: {Volume}";
        }

    }
}

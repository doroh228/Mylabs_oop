using System;
using System.Collections.Generic;
using System.Text;

namespace LABA5
{
    class Cactus:shrub
    {

        public Cactus(string name, int height, int weight) : base(name, height, weight)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }
    }
}

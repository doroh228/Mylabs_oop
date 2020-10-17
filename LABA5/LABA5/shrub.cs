using System;
using System.Collections.Generic;
using System.Text;

namespace LABA5
{
    abstract public class shrub:Plans
    {
        public string Name;
       public shrub(string name,int height, int weight)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }

        public double Processing(int height, int weight)
        {
            return (double)(weight/height) *0.1;
        }
    }
}

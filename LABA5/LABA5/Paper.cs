using System;
using System.Collections.Generic;
using System.Text;

namespace LABA5
{
    sealed class Paper
    {
       string Name { get; set; }

       int Weight { get; set; }

        public Paper(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Name of paper: {Name}; Weight paper = {Weight} ";
        }
    }
}

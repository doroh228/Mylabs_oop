using System;
using System.Collections.Generic;
using System.Text;

namespace LABA5
{
    sealed class Paper:Plans
    {
       string Name { get; set; }

        int weight;
       public int Weight {
            get
            {
                return weight;
            } 
            set
            {
                if (value <= 0)
                {
                    throw new Exceptions.HowMuchException("Exception");
                }
                else
                {
                    weight = value;
                }
            }
        }
        public Paper()
        {

        }
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

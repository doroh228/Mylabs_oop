using System;
using System.Collections.Generic;
using System.Text;

namespace For_myself_2
{
    public sealed class Road
    {   
        public string Number { get; set; }
        public int Lenght { get; set; }

        public override string ToString()
        {
            return $"Дорога: {Number}, общей протяжённостью: {Lenght}"; 
        }
    }
}

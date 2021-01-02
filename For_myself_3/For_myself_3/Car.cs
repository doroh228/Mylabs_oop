using System;
using System.Collections.Generic;
using System.Text;

namespace For_myself_3
{
    class Car
    {
        public string Name { get; set; }

        public string Number { get; set; }

        public override string ToString()
        {
            return $"Машина: {Name} с номером: {Number}";
        }
    }
}

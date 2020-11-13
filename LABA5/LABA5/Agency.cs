using System;
using System.Collections.Generic;
using System.Text;

namespace LABA5
{
    public class Agency
    {
        public List<Plans> _container { get; set; }

        public Agency()
        {
            _container = new List<Plans>();
        }

        public Plans this[int index]
        {
            get { return _container[index]; }
            set { _container[index] = value; }
        }

        public void AddItem(Plans plans) => _container.Add(plans);
        public void Delete(Plans plans) => _container.Remove(plans);
        public void Print()
        {
            for (int i = 0; i < _container.Count - 1; i++)
            {
                Console.WriteLine(_container[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace For_myself_3
{
    class Parking
    {
        private List<Car> _cars = new List<Car>();
        private const int MAX_CARS = 100;
        public string Name { get; set; }

        public Car this[string number]
        {
            get
            {
                var car = _cars.FirstOrDefault(car => car.Number == number);
                return car;
            }
        }
        public Car this[int position]
        {
            get
            {
                if (position < _cars.Count) {
                    return _cars.[position];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (position < _cars.Count)
                {
                    _cars[position] = value; 
                }
            }
        }
        public int Count => _cars.Count;

        public int Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car is null");
            }
            if (_cars.Count < MAX_CARS)
            {
                _cars.Add(car);
                return _cars.Count - 1;
            }
            return -1;
        }
        public void GoOut(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentNullException(nameof(number),"Number is null");
            }

            var car = _cars.Single(car => car.Number == number);
            if (car != null)
            {
                _cars.Remove(car);
            }
        }
    }
}

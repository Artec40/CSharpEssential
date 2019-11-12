using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11._1
{
    public interface ICar
    {
        string Name { get; }
        int Year { get; }


    }
    class CarCollection<T> : MyList<T> where T : ICar
    {
        private readonly MyList<T> _cars;
        // private readonly MyList<string> _carName;
        // private readonly MyList<int> _carYear;

        public CarCollection()
        {
            _cars = new MyList<T>();
            //_carYear = new MyList<int>();
        }

        public void AddCar(T newCar)
        {
            _cars.Add(newCar);
            // _carName.Add(newCar.Name);
            // _carYear.Add(newCar.Year);
        }

        public new T this[int index]
        {
            get
            {
                if (index <= _cars.ListLength)
                    return _cars[index];
                throw new Exception("Car not found.");
            }
        }

        public int CarCollectionLength
        {
            get
            {
                return _cars.ListLength;
            }
        }

        public void Delete()
        {
            _cars.Clear();
        }
    }
}
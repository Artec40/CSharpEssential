using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11._1
{
    class CarCollection<T> : MyList<T>
    {
        private readonly MyList<string> _carName;
        private readonly MyList<int> _carYear;

        public CarCollection()
        {
            _carName = new MyList<string>();
            _carYear = new MyList<int>();
        }

        public void AddCar(string newCarName, int newCarYear)
        {
            _carName.Add(newCarName);
            _carYear.Add(newCarYear);
        }

        public new string this[int index]
        {
            get
            {
                if (index <= _carName.ListLength)
                    return _carName[index] + " " + _carYear[index];
                return "wrong command";
            }
        }

        public int CarCollectionLength
        {
            get
            {
                return _carName.ListLength;
            }
        }

        public void Delete()
        {
            _carName.Clear();
            _carYear.Clear();
        }
    }
}
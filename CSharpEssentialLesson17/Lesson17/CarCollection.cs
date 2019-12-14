using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson17
{
    class CarCollection : List<Car>
    {
        public void Add(string mark, string model, int year, string color)
        {
            base.Add(new Car(mark, model, year, color));
        }
    }
}

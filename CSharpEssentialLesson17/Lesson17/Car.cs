using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson17
{
    class Car
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public Car(string mark, string model, int year, string color)
        {
            this.Mark = mark;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }
    }
}

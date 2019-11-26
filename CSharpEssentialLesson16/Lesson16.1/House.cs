using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson16._1
{
    class House
    {
        private string name;
        private int year;

        public string Name { get; set; }
        public string Year { get; set; }

        public House(string name, string year)
        {
            this.Name = name;
            this.Year = year;
        }

        // Поверхностное клонирование.
        public House Clone()
        {
            return this;
        }

        // Глубокое клонирование.
        public House DeepClone()
        {
            return this.MemberwiseClone() as House;
        }

        public House ChangeClone()
        {
            this.Name = "Another name";
            this.Year = "Another year";
            return this;
        }
    }
}

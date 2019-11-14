using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson15
{
    struct Worker
    {
        string name;
        string position;
        int year;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
        }

        public Worker(string name, string position, int year)
        {
            this.name = name;
            this.position = position;
            this.year = year;
        }

        public void FindWorkExperienceMoreThan(int experience)
        {
            if (Year >= experience)
                Console.WriteLine($"Worker: name {Name}, position {Position}, year {Year}");
        }
    }
}


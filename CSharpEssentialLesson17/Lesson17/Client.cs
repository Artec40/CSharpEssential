using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson17
{
    class Client
    {
        public string Mark { get; set; }
        public string Name { get; set; }
        public long PhoneNumber { get; set; }

        public Client(string mark, string name, long phoneNumber)
        {
            this.Mark = mark;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }
    }
}

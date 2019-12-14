using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson17
{
    class ClientCollection : List<Client>
    {
        public void Add(string mark, string name, long phoneNumber)
        {
            base.Add(new Client(mark, name, phoneNumber));
        }
    }
}

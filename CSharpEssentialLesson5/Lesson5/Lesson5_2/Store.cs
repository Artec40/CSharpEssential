using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5_2
{
    public class Store
    {
        private Article[] _store = new Article[5];

        public int ProductCount
        {
            get
            {
                return _store.Length;
            }
        }

        public Store()
        {
            _store[0] = new Article("computer", "DNS", "100000");
            _store[1] = new Article("monitor", "DNS", "20000");
            _store[2] = new Article("headphone", "ELDORADO", "5000");
            _store[3] = new Article("mouse", "ELDORADO", "5000");
            _store[4] = new Article("keyboard", "DNS", "5000");
        }

        public Article this[int index]
        {
            get
            {
                if (index >= 0 && index < _store.Length)
                    return _store[index];
                else
                    return null;
            }
        }
    }
}

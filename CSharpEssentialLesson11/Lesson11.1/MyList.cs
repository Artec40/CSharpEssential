using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11._1
{
    public interface IMyList<T>
    {
        void Add(T a);
        T this[int index] { get; }
        int ListLength { get; }
    }

    public class MyList<T> : IMyList<T>
    {
        private T[] _currentList;

        public MyList()
        {
            _currentList = new T[0];
        }

        public void Add(T newListItem)
        {
            T[] tempList = new T[_currentList.Length + 1];
            for (int i = 0; i < _currentList.Length; i++)
            {
                tempList[i] = _currentList[i];
            }
            tempList[_currentList.Length] = newListItem;
            _currentList = tempList;
        }

        public T this[int index]
        {
            get { return _currentList[index]; }
        }

        public int ListLength
        {
            get { return _currentList.Length; }
        }

        public void Clear()
        {
            _currentList = new T[0];
        }
    }
}
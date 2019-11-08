using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10._1
{
    public interface IMyList<T>
    {
        void Add(T a);
        T this[int index] { get; }
        int arrayLength { get; }
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
            T[] tempArray = new T[_currentList.Length + 1];
            for (int i = 0; i < _currentList.Length; i++)
            {
                tempArray[i] = _currentList[i];
            }
            tempArray[_currentList.Length] = newListItem;
            _currentList = tempArray;
        }

        public T this[int index]
        {
            get { return _currentList[index]; }
        }

        public int arrayLength
        {
            get { return _currentList.Length; }
        }

    }
}

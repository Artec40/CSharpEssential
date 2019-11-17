using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lesson10._1
{
    public interface IMyList<T>
    {
        void Add(T a);
        T this[int index] { get; }
        int listLength { get; }
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

        public int listLength
        {
            get { return _currentList.Length; }
        }

        //Для работы foreach добавлены реализации методов IEnumerable и Ienumerator.

        int position = -1;

        public void Reset()
        {
            position = -1;
        }

        //GetEnumerator().
        public IEnumerator<T> GetEnumerator() //Перечислитель который возвращает элементы
        {
            while (true) //Бесконечный цикл
            {
                if (position < _currentList.Length - 1)//Проверяем позицию в массиве 
                {
                    position++; //Инкрементируем 
                    yield return _currentList[position];
                }
                else
                {
                    Reset(); //Вызов метода Reset
                    yield break;
                }
            }
        }
    }
}
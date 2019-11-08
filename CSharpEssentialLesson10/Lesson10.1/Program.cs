using System;

namespace Lesson10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размерность массива ");
            int userValue = Convert.ToInt32(Console.ReadLine());
            var list = new MyList<int>();
            for (int i = 0; i < userValue; i++)
            {
                list.Add(i);
                Console.WriteLine("Элемент массива {0}", list[i]);
            }

            Console.Write("Номер массива ");
            userValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(list[userValue]);

            Console.WriteLine("Размер массива {0}", list.arrayLength);
        }
    }
}

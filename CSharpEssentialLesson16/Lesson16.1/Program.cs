using System;

namespace Lesson16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            House newHouse = new House("Original name", "Original year");

            Console.WriteLine("Clone");
            House cloneHouse = newHouse.Clone();
            cloneHouse.ChangeClone();
            Console.WriteLine($"Original name:{newHouse.Name}, Original year:{newHouse.Year}");
            Console.WriteLine($"Clone name:{cloneHouse.Name}, Clone year:{cloneHouse.Year}");
            Console.WriteLine();

            // Возвращаем значение оригинала после поверхностного копирования.
            newHouse.Name = "Original name";
            newHouse.Year = "Original year";

            Console.WriteLine("Deep Clone");
            House deepCloneHouse = newHouse.DeepClone();
            deepCloneHouse.ChangeClone();
            Console.WriteLine($"Original name:{newHouse.Name}, Original year:{newHouse.Year}");
            Console.WriteLine($"Clone name:{deepCloneHouse.Name}, Clone year:{deepCloneHouse.Year}");
        }
    }
}

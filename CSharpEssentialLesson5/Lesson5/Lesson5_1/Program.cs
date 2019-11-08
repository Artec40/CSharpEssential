using System;

namespace Lesson5_1
{

    /// <summary>
    /// Создать массив размерностью N элементов, заполнить его призвольными целыми значениями.
    /// Вывести наибольшее значение массива, наименьшее значение массива,
    /// общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(5);
            Console.WriteLine();
            array.MaxMeaning();
            array.MinMeaning();
            array.SumMeaning();
            array.AverageMeaning();
            array.Odd();
        }
    }
}

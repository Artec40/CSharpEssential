using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5_1
{

    /// <summary>
    /// Создать массив размерностью N элементов, заполнить его призвольными целыми значениями.
    /// Вывести наибольшее значение массива, наименьшее значение массива,
    /// общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения.
    /// </summary>

    class Array
    {
        /// <summary>
        /// Одномерный массив array.
        /// </summary>
        int[] array;
        /// <summary>
        /// Конструктор класса Array.
        /// </summary>
        /// <param name="n">Инициализация количества членов массива.</param>
        public Array(int n)
        {
            this.array = new int[n];
            // Создание экземпляра класса Random для заполнения массива array случайными числами от 0 до 15.
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 15);
                Console.Write("{0} ", array[i]);
            }
        }

        /// <summary>
        /// Метод, определяющий максимальное значение массива.
        /// </summary>
        public void MaxMeaning()
        {
            int maxMeaning = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                    maxMeaning = array[i];
            }
            Console.WriteLine("Max = {0}", maxMeaning);
        }

        /// <summary>
        /// Метод, определяющий минимальное значение массива.
        /// </summary>
        public void MinMeaning()
        {
            int minMeaning = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                    minMeaning = array[i];
            }
            Console.WriteLine("Min = {0}", minMeaning);
        }

        /// <summary>
        /// Метод, суммирующий элементы массива.
        /// </summary>
        public void SumMeaning()
        {
            int sumMeaning = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumMeaning = sumMeaning + array[i];
            }
            Console.WriteLine("Sum = {0}", sumMeaning);
        }

        /// <summary>
        /// Метод, считающий среднеарифметическую сумму массива.
        /// </summary>
        public void AverageMeaning()
        {
            int sumMeaning = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumMeaning = sumMeaning + array[i];
            }
            double averageMeaning = Convert.ToDouble(sumMeaning) / Convert.ToDouble(array.Length);
            Console.WriteLine("Average = {0}", averageMeaning);
        }

        /// <summary>
        /// Метод, выводящий нечетные числа.
        /// </summary>
        public void Odd()
        {
            Console.WriteLine("Odd Numbers:");
            for (int i = 0; i < array.Length; i++)
            {
                int odd = array[i] % 2;
                if (odd != 0)
                    Console.Write("{0} ", array[i]);
            }
        }
    }
}

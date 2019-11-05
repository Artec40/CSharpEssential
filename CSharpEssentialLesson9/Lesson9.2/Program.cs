using System;

namespace Lesson9._2
{
    class Program
    {

        static Random random = new Random();

        delegate int ArrayDelegate();

        delegate double AverageMeaning(ArrayDelegate[] arrayDelegate);

        static int GetRandomNumber()
        {
            return random.Next(100);
        }

        static void Main(string[] args)
        {
            Console.Write("Число элементов массива-");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            Console.Write("Элементы массива: ");
            var array = new ArrayDelegate[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = () => new ArrayDelegate(GetRandomNumber).Invoke();
                Console.Write("{0} ", array[i].Invoke());
            }

            AverageMeaning average = delegate (ArrayDelegate[] arrayDelegate)
            {
                double averageMeaning = 0;
                for (int i = 0; i < arrayDelegate.Length; i++)
                {
                    averageMeaning += arrayDelegate[i].Invoke();
                }
                return averageMeaning / array.Length;
            };
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое-{0}", average(array));
        }
    }
}

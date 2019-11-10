using System;

namespace Lesson11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much car in collection? ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            var carCollection = new CarCollection<string>();

            for (int i = 0; i < userInput; i++)
            {
                Console.Write("№{0} Model? ", i + 1);
                string newCarName = Console.ReadLine();
                Console.Write("№{0} Year? ", i + 1);
                int newCarYear = Convert.ToInt32(Console.ReadLine());
                carCollection.AddCar(newCarName, newCarYear);
            }

            Console.Write("Car Index? ");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("№{0} {1}", userInput, carCollection[userInput - 1]);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Collection included {0} cars", carCollection.CarCollectionLength);

            Console.WriteLine(new string('-', 50));
            carCollection.Delete();
            Console.WriteLine("Collection included {0} cars after method Delete", carCollection.CarCollectionLength);
        }
    }
}

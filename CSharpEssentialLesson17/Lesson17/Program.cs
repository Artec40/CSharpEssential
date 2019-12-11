using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            var carCollection = new List<CarCollection>();
            carCollection.Add(new CarCollection("Bentley", "Mulsanne", 2018, "Black"));
            carCollection.Add(new CarCollection("Shevrolet", "Camaro", 2010, "Yellow"));
            carCollection.Add(new CarCollection("Zaporojec", "ZAZ-965", 1965, "Red"));

            List<ClientCollection> clientCollection = new List<ClientCollection>();
            clientCollection.Add(new ClientCollection("Bentley", "BentleyHandler", 88005553535));
            clientCollection.Add(new ClientCollection("Shevrolet", "CamaroHandler", 3101010));
            clientCollection.Add(new ClientCollection("Zaporojec", "WhoAreYou", 1111111111));

            Console.WriteLine("CarCollection include: ");
            foreach (CarCollection car in carCollection)
            {
                Console.Write($"{car.Mark}, ");
            }

            Console.WriteLine();

            Console.Write("Information about car: ");
            string userInput = Console.ReadLine();

            var query =
                from car in carCollection
                from client in clientCollection
                where car.Mark == userInput && client.Mark == userInput
                select new
                {
                    Mark = car.Mark,
                    Model = car.Model,
                    Year = car.Year,
                    Color = car.Color,
                    Name = client.Name,
                    PhoneNumber = client.PhoneNumber
                };

            foreach (var item in query)
            {
                Console.WriteLine($"Mark: {item.Mark}, Model: {item.Model}, Year: {item.Year}, Color: {item.Color}, Client: {item.Name}, Phone: {item.PhoneNumber}");
            }
        }
    }
}

using System;

namespace Lesson5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            int userInputIndex = Convert.ToInt32(Console.ReadLine());
            // Сокращенная форма выводит только свойство store[userInputIndex].Name, из-за чего переделал в полноценный if else.
            //   Console.WriteLine(store[userInputIndex] == null ? "Product not found" : store[userInputIndex].Name, store[userInputIndex].Shop, store[userInputIndex].Price);
            if (store[userInputIndex] == null)
                Console.WriteLine("Product not found");
            else
                Console.WriteLine("Product name:{0}, Shop: {1}, Price: {2}", store[userInputIndex].Name, store[userInputIndex].Shop, store[userInputIndex].Price);


            string userInputName = Console.ReadLine();
            bool checkInputName = false;
            for (int storeLength = 0; storeLength < store.ProductCount; storeLength++)
            {
                if (userInputName == store[storeLength].Name)
                {
                    Console.WriteLine("Product name:{0}, Shop: {1}, Price: {2}", store[storeLength].Name, store[storeLength].Shop, store[storeLength].Price);
                    checkInputName = true;
                }

                if ((storeLength == store.ProductCount - 1) && (userInputName != store[storeLength].Name) && (checkInputName == false))
                    Console.WriteLine("Product not found");
            }

        }
    }
}

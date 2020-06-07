using System;

namespace Lesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Andrew", "Ebay");
            invoice.Article = "pen";
            invoice.Quantity = 6;

            Console.WriteLine($"cost with nds: {invoice.CostCalculate(true)}, without nds {invoice.CostCalculate(false)} ");
        }
    }
}

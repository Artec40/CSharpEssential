using System;
using System.Linq;

namespace Lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string position;
            string yearNotChecked;
            int yearChecked;

            Worker[] company = new Worker[5];

            for (int i = 0; i < company.Length; i++)
            {
                Console.Write("Worker's name= ");
                name = Console.ReadLine();
                Console.Write("Worker's position= ");
                position = Console.ReadLine();
                Console.Write("Worker's year= ");
                yearNotChecked = Console.ReadLine();

                try
                {
                    yearChecked = Convert.ToInt32(yearNotChecked);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong year value");
                    Console.WriteLine(e.Message);
                    yearChecked = 0;
                }

                company[i] = new Worker(name, position, yearChecked);
            }

            company = company.OrderBy(worker => worker.Name).ToArray<Worker>();

            Console.Write("Work experience more then ");
            int userValue = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < company.Length; j++)
            {
                if (company[j].Year <= userValue)
                    Console.WriteLine($"Worker: name {company[j].Name}, position {company[j].Position}, year {company[j].Year}");
            }
        }
    }
}

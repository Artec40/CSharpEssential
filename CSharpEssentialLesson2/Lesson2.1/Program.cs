using System;

/// <summary>
/// Создать класс Converter.
/// В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента
/// и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне -
/// - public Converter(double usd, double eur, double rub).
/// Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
/// также программа должна производить конвертацию из указанных валют в гривну.
/// </summary>

namespace Lesson2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вопрос - конвертируем в гривну или из гривны.
            Console.WriteLine("if 'Convert to' press 1, if 'Convert from' press 2");
            string userQueryPick = Console.ReadLine();
            //Если конверт из гривны вопрос в какую валюту.
            if (userQueryPick == "1")
            {
                Console.Write("Count of hryvnia: ");
                int hryvnia = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Press 1 to usd, 2 to eur, 3 to rub");
                string userQueryCurrency = Console.ReadLine();
                //Создаем экземпляр конвертера.
                Converter converterTo = new Converter(usd: hryvnia, eur: hryvnia, rub: hryvnia);
                //Если доллар выдаем 1 параметр класса через метод, если евро 2 параметр класса через метод, если рубли 3 параметр класса через метод.
                switch (userQueryCurrency)
                {
                    case "1":
                        Console.WriteLine("{0} usd", converterTo.ConvertToUsd());
                        break;
                    case "2":
                        Console.WriteLine("{0} eur", converterTo.ConvertToEur());
                        break;
                    case "3":
                        Console.WriteLine("{0} rub", converterTo.ConvertToRub());
                        break;
                    default:
                        Console.WriteLine("Wrong command");
                        break;
                }
            }
            //Если конверт в гривну.
            else if (userQueryPick == "2")
            {
                //Вопрос из какой валюты.
                Console.WriteLine("Press 1 from usd, 2 from eur, 3 from rub");
                string userQueryCurrency = Console.ReadLine();
                Console.Write("Count of currency: ");
                //Создаем экземпляр конвертера.
                int currency = Convert.ToInt32(Console.ReadLine());
                Converter converterFrom = new Converter(usd: currency, eur: currency, rub: currency);
                switch (userQueryCurrency)
                {
                    case "1":
                        Console.WriteLine("{0} hryvnias", converterFrom.ConvertFromUsd());
                        break;
                    case "2":
                        Console.WriteLine("{0} hryvnias", converterFrom.ConvertFromEur());
                        break;
                    case "3":
                        Console.WriteLine("{0} hryvnias", converterFrom.ConvertFromRub());
                        break;
                    default:
                        Console.WriteLine("Wrong command");
                        break;
                }
            }
            else
                Console.WriteLine("Wrong command");
        }
    }
}


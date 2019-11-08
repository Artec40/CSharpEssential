using System;

namespace Lesson4_1

/// Создайте класс AbstractHandler.
/// В теле класса создать методы void Open(), void Create(), void Change(), void Save().
/// Создать производные классы XMLHanler, TXTHandler, DOCHandler от базового класса
/// AbstractHandler.
/// Написать программу, которая будет выполнять определение документа и для каждого формата должны
/// быть метода открытия, создания, редактирования, сохранения определенного формата документа.

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type of document? XML, TXT, DOC ");
            // userInput - ввод пользователем типа документа.
            string userInput = Console.ReadLine();
            // Оператор выбора типа документа.
            switch (userInput)
                {
                case "XML":
                    AbstractHandler XML = new XMLHandler();
                    XML.Open();
                    XML.Create();
                    XML.Change();
                    XML.Save();
                    break;
                case "TXT":
                    AbstractHandler TXT = new TXTHandler();
                    TXT.Open();
                    TXT.Create();
                    TXT.Change();
                    TXT.Save();
                    break;
                case "DOC":
                    AbstractHandler DOC = new DOCHandler();
                    DOC.Open();
                    DOC.Create();
                    DOC.Change();
                    DOC.Save();
                    break;
                default:
                    Console.WriteLine("Wrong Command");
                    break;
            }
        }
    }
}

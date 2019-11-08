using System;

namespace Lesson3._3
{

    /// <summary>
    /// Создайте класс DocumentWorker.
    /// В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
    /// В теле каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт",
    /// "Редактирование документа доступно в версии Про", "Сохранение документа доступно в версии Про".
    /// Создайте производный класс ProDocumentWorker.
    /// Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
    /// "Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии эксперт", 
    /// Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker. 
    /// Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран "Документ сохранен в новом формате".
    /// В теле метода Main()  реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
    /// Если пользователь не вводит ключ, он может пользоваться только бесплатной версией
    /// (создается экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp,
    /// то должен создаться экземпляр соответствующей версии класса, приведенный к базовому - DocumentWorker. 
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write a key product: (1-trial, 2-pro, 3-expert ");
            int keyFromUser = Convert.ToInt32(Console.ReadLine());
            switch (keyFromUser)
            {
                case 1:
                    {
                        DocumentWorker document = new DocumentWorker();
                        document.OpenDocument();
                        document.EditDocument();
                        document.SaveDocument();
                        break;
                    }
                case 2:
                    {
                        ProDocumentWorker document = new ProDocumentWorker();
                        document.OpenDocument();
                        document.EditDocument();
                        document.SaveDocument();
                        break;
                    }
                case 3:
                    {
                        ExpertDocumentWorker document = new ExpertDocumentWorker();
                        document.OpenDocument();
                        document.EditDocument();
                        document.SaveDocument();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}

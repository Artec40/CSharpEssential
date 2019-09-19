using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4_1
{
    /// Создайте класс AbstractHandler.
    /// В теле класса создать методы void Open(), void Create(), void Change(), void Save().
    /// Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса
    /// AbstractHandler.
    /// Написать программу, которая будет выполнять определение документа и для каждого формата должны
    /// быть метода открытия, создания, редактирования, сохранения определенного формата документа.
    public class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXTHandler Open");
        }
        public override void Create()
        {
            Console.WriteLine("TXTCreate");
        }
        public override void Change()
        {
            Console.WriteLine("TXTChange");
        }
        public override void Save()
        {
            Console.WriteLine("TXTSave");
        }
    }
}

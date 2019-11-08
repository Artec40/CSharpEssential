using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4_1

/// Создайте класс AbstractHandler.
/// В теле класса создать методы void Open(), void Create(), void Change(), void Save().
/// Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса
/// AbstractHandler.
/// Написать программу, которая будет выполнять определение документа и для каждого формата должны
/// быть метода открытия, создания, редактирования, сохранения определенного формата документа.
{
    public abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
}

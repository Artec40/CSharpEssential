using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3._1
{

    /// <summary>
    /// Создать класс, представляющий учебный класс ClassRoom.
    /// Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void Write()
    /// void Relax(). Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil, класс должен 
    /// состоять из 4 учениковю Предусмотрите возможность тогоЮ что пользователь может передать 2 или 3 аргументаю
    /// Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.
    /// </summary>

    public class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Study");
        }
        public virtual void Read()
        {
            Console.WriteLine("Read");
        }

        public virtual void Write()
        {
            Console.WriteLine("Write");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Relax");
        }
        public void ShowAction()
        {
            Study();
            Read();
            Write();
            Relax();
        }
    }
}

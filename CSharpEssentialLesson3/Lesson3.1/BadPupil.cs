using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3._1
{
    /// <summary>
    /// Создать класс, представляющий учебный класс ClassRoom.
    /// Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void Write()
    /// void Relax(). Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil, класс должен 
    /// состоять из 4 учеников. Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
    /// Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.
    /// </summary>

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadStudy");
        }
        public override void Read()
        {
            Console.WriteLine("BadRead");
        }

        public override void Write()
        {
            Console.WriteLine("BadWrite");
        }

        public override void Relax()
        {
            Console.WriteLine("BadRelax");
        }
    }
}

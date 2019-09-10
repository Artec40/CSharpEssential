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

    public class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study");
        }
        public override void Read()
        {
            Console.WriteLine("ExcelentRead");
        }

        public override void Write()
        {
            Console.WriteLine("ExcelentWrite");
        }

        public override void Relax()
        {
            Console.WriteLine("ExcelentRelax");
        }
    }
}

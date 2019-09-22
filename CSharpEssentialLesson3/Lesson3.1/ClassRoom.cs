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

    class ClassRoom
    {
        public string FirstPupil
        { get; set; }
        public string SecondPupil
        { get; set; }
        public string ThirdPupil
        { get; set; }
        public string FourthPupil
        { get; set; }
        public ClassRoom(string firstPupil, string secondPupil, string thirdPupil, string fourthPupil)
        {
            this.FirstPupil = firstPupil;
            this.SecondPupil = secondPupil;
            this.ThirdPupil = thirdPupil;
            this.FourthPupil = fourthPupil;
        }
    }
}

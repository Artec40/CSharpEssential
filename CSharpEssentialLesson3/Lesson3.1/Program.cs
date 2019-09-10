using System;

namespace Lesson3._1
{

    /// <summary>
    /// Создать класс, представляющий учебный класс ClassRoom.
    /// Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void Write()
    /// void Relax(). Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil, класс должен 
    /// состоять из 4 учеников. Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
    /// Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number of pupil in da class? - ");
            // pupilInClassroom - количество учеников в классе. pupilCounter - счетчик учеников в цикле.
            int pupilInClassroom = Convert.ToInt32(Console.ReadLine());
            int pupilCounter = 0;
            while (pupilCounter < pupilInClassroom)
            {
                Console.WriteLine("1 - ExcelentPupil, 2 - GoodPupil, 3 - BadPupil");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ExcelentPupil excelentPupil = new ExcelentPupil();
                        excelentPupil.Study();
                        excelentPupil.Read();
                        excelentPupil.Write();
                        excelentPupil.Relax();
                        pupilCounter++;
                        continue;
                    case "2":
                        GoodPupil goodPupil = new GoodPupil();
                        goodPupil.Study();
                        goodPupil.Read();
                        goodPupil.Write();
                        goodPupil.Relax();
                        pupilCounter++;
                        continue;
                    case "3":
                        BadPupil badPupil = new BadPupil();
                        badPupil.Study();
                        badPupil.Read();
                        badPupil.Write();
                        badPupil.Relax();
                        pupilCounter++;
                        continue;
                    default:
                        continue;
                }

            }
        }
    }
}

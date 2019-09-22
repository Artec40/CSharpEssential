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
            ClassRoom classRoom = new ClassRoom("ExcelentPupil", "GoodPupil", "BadPupil", "BadPupil");
            Console.WriteLine("Classroom contain {0}, {1}, {2}, {3}", classRoom.FirstPupil, classRoom.SecondPupil, classRoom.ThirdPupil, classRoom.FourthPupil);
            switch (classRoom.FirstPupil)
            {
                case "ExcelentPupil":
                    ExcelentPupil excelentPupil = new ExcelentPupil();
                    excelentPupil.ShowAction();
                    Console.WriteLine(new string('-', 50));
                    break;
                case "GoodPupil":
                    GoodPupil goodPupil = new GoodPupil();
                    goodPupil.ShowAction();
                    Console.WriteLine(new string('-', 50));
                    break;
                case "BadPupil":
                    BadPupil badPupil = new BadPupil();
                    badPupil.ShowAction();
                    Console.WriteLine(new string('-', 50));
                    break;
            }

            switch (classRoom.SecondPupil)
            {
                case "ExcelentPupil":
                    ExcelentPupil excelentPupil = new ExcelentPupil();
                    excelentPupil.ShowAction();
                    Console.WriteLine(new string('-', 50));
                    break;
                case "GoodPupil":
                    GoodPupil goodPupil = new GoodPupil();
                    goodPupil.ShowAction();
                    Console.WriteLine(new string('-', 50));
                    break;
                case "BadPupil":
                    BadPupil badPupil = new BadPupil();
                    badPupil.ShowAction();
                    Console.WriteLine(new string('-', 50));
                    break;
            }

            switch (classRoom.ThirdPupil)
            {
                case "ExcelentPupil":
                    ExcelentPupil excelentPupil = new ExcelentPupil();
                    excelentPupil.ShowAction();
                    Console.WriteLine(new string('-', 50));
                    break;
                case "GoodPupil":
                    GoodPupil goodPupil = new GoodPupil();
                    goodPupil.ShowAction();
                    Console.WriteLine(new string('-', 50));
                    break;
                case "BadPupil":
                    BadPupil badPupil = new BadPupil();
                    badPupil.ShowAction();
                    Console.WriteLine(new string('-', 50));
                    break;
            }

            switch (classRoom.FourthPupil)
            {
                case "ExcelentPupil":
                    ExcelentPupil excelentPupil = new ExcelentPupil();
                    excelentPupil.ShowAction();
                    Console.WriteLine(new string('-', 50));
                    break;
                case "GoodPupil":
                    GoodPupil goodPupil = new GoodPupil();
                    goodPupil.ShowAction();
                    Console.WriteLine(new string('-', 50));
                    break;
                case "BadPupil":
                    BadPupil badPupil = new BadPupil();
                    badPupil.ShowAction();
                    Console.WriteLine(new string('-', 50));
                    break;
            }
        }
    }
}

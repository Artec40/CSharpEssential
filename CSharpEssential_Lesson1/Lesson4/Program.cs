using System;

namespace Lesson4
/// Создать классы Point и Figure.
/// Класс Point должен содержать два целочисленных поля и одно строковое поле.
/// Создать три свойства с одним методом доступа get.
/// Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
/// Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
/// Создать два метода: double LengthSide (Point A, Point B), который рассчитывает длину стороны
/// многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
/// Написать программу, которая выводит на экран название и периметр многоугольника.
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Переменная pointCount - счетчик точек. 1 точка задаётся до цикла while. переменная perimeter - счетчик длин сторон фигуры.
            int POINT_COUNT = 1; double PERIMETER = 0;
            Console.Write("Point count - 3-5? pointCount= ");
            int userPointCount = Convert.ToInt32(Console.ReadLine());

            // Проверка на ввод от 3-х до 5-ти аргументов типа Point.
            if ((userPointCount >= 3) && (userPointCount <= 5))
            {
                Console.Write("Point name = ");
                string firstPointName = Console.ReadLine();
                Console.Write("{0}(X;Y) = ", firstPointName);
                int firstPointX = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0}({1};Y) = ", firstPointName, firstPointX);
                int firstPointY = Convert.ToInt32(Console.ReadLine());
                Point lastPoint = new Point(firstPointName, firstPointX, firstPointY);

                while (POINT_COUNT < userPointCount)
                {
                    Console.Write("Point name = ");
                    string secondPointName = Console.ReadLine();
                    Console.Write("{0}(X;Y) = ", secondPointName);
                    int secondPointX = Convert.ToInt32(Console.ReadLine());
                    Console.Write("{0}({1};Y) = ", secondPointName, secondPointX);
                    int secondPointY = Convert.ToInt32(Console.ReadLine());
                    Point firstPoint = new Point(firstPointName, firstPointX, firstPointY);
                    Point secondPoint = new Point(secondPointName, secondPointX, secondPointY);

                    Figure side = new Figure(firstPoint, secondPoint);
                    PERIMETER = (PERIMETER + side.Perimeter);
                    if ((userPointCount - POINT_COUNT) == 1)
                    {
                        Figure lastSide = new Figure(lastPoint, secondPoint);
                        PERIMETER = (PERIMETER + lastSide.Perimeter);
                    }
                    POINT_COUNT++;
                    firstPointX = secondPointX; firstPointY = secondPointY;
                }
            }
            else
            {
                Console.WriteLine("Wrong meaning of pointCount");
            }
            Console.Write("Perimeter ={0} ", PERIMETER);
            switch (POINT_COUNT)
            {
                case 3:
                    Console.Write("Figure triangle");
                    break;
                case 4:
                    Console.Write("Figure quadrangle");
                    break;
                case 5:
                    Console.Write("Figure pentagon");
                    break;
            }
        }
    }
}

using System;

namespace Lesson2
/// Требуется создать класс с именем Rectangle.
/// В теле класса создать два поля, описывающие длины сторон double side1, side2.
/// Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
/// поля side1 и side2 инициализируются значениями аргументов. 
/// Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
/// прямоугольника - double  PerimeterCalculator().
/// Создать два свойства double Area и double Perimeter с одним методом доступа get.
/// Написать программу, которая принимает от пользователя длины двух сторон прямоугольника
/// и выводит на экран периметр и площадь.
/// 
{
    public class Rectangle
    {
        private double Side1, Side2;
        public Rectangle(double side1, double side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }
        private double AreaCalculator()
        {
            return Side1 * Side2;
        }
        private double PerimeterCalculator()
        {
            return Side1 + Side1 + Side2 + Side2;
        }
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side 1 = ");
            double side1ByUser = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side 2 = ");
            double side2ByUser = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1ByUser, side2ByUser);
            Console.WriteLine("Perimeter = {0}", rectangle.Perimeter);
            Console.WriteLine("Area = {0}", rectangle.Area);
        }
    }

}

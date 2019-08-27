using System;
using System.Collections.Generic;
using System.Text;

/// Создать классы Point и Figure.
/// Класс Point должен содержать два целочисленных поля и одно строковое поле.
/// Создать три свойства с одним методом доступа get.
/// Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
/// Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
/// Создать два метода: double LengthSide (Point A, Point B), который рассчитывает длину стороны
/// многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
/// Написать программу, которая выводит на экран название и периметр многоугольника.

namespace Lesson4
{
    public class Figure
    {
        private int pointAX, pointAY, pointBX, pointBY;

        /// <summary>
        /// Конструктор, собирающий отрезок по координатам начала и конца.
        /// </summary>
        public Figure(Point firstPoint, Point secondPoint)
        {
            this.pointAX = firstPoint.PointX;
            this.pointAY = firstPoint.PointY;
            this.pointBX = secondPoint.PointX;
            this.pointBY = secondPoint.PointY;
        }

        /// <summary>
        /// Метод, расчитывающий длину отрезка по точкам firstPoint и secondPoint.
        /// </summary>
        /// <returns></returns>
        private double MathLenghtSide()
        {
            return (Math.Sqrt(Math.Pow((pointBX - pointAX), 2) + Math.Pow((pointBY - pointAY), 2)));
        }

        /// <summary>
        /// Свойство, описывающее длину стороны фигуры по точкам firstPoint и secondPoint.
        /// </summary>
        public double LenghtSide
        {
            get
            {
                return MathLenghtSide();
            }
        }
        private double perimeter = 0;

        /// <summary>
        /// Метод, расчитывающий периметр фигуры.
        /// </summary>
        /// <returns></returns>
        private double MathPerimeter()
        {
            perimeter = (perimeter + LenghtSide);
            return perimeter;
        }

        /// <summary>
        /// Свойство фигуры - периметр.
        /// </summary>
        public double Perimeter
        {
            get
            {
                return MathPerimeter();
            }
        }
    }
}

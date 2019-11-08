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
    /// <summary>
    /// Класс, описывающий точку.
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Name - свойство, определяющее название точки.
        /// </summary>
        private string Name { get; }

        /// <summary>
        /// PointX - свойство, определяющее первую координату.
        /// </summary>
        public int PointX { get; }

        /// <summary>
        /// PointY - свойство, определяющее вторую координату.
        /// </summary>
        public int PointY { get; }

        /// <summary>
        /// Пользовательский контруктор класса "точка".
        /// </summary>
        /// <param name="name">Инициализируем название точки.</param>
        /// <param name="pointX">Инициализируем первую координату.</param>
        /// <param name="pointY">Инициализируем вторую координату.</param>
        public Point(string name, int pointX, int pointY)
        {
            this.Name = name;
            this.PointX = pointX;
            this.PointY = pointY;
        }
    }
}

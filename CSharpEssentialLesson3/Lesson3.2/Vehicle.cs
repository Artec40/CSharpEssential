using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3._2
{

    /// <summary>
    /// Создать класс Vehicle.
    /// В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
    /// Создайте 3 производных класса Plane,Car и Ship.
    /// Для класса Plane должна быть определена высота и количество пассажиров.
    /// Для класса Ship - количество пассажиров и порт приписки.
    /// Написаь программу, которая выводит на экран информацию о каждом средстве передвижения.
    /// </summary>

    public class Vehicle
    {
        protected int coordX;
        protected int coordY;
        protected int price;
        protected int speed;
        protected int yearIssue;
        public Vehicle (int coordX, int coordY, int price, int speed, int yearIssue)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.price = price;
            this.speed = speed;
            this.yearIssue = yearIssue;
        }
    }
}

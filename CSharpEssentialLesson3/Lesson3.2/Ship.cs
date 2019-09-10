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
    /// Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
    /// </summary>

    public class Ship : Vehicle
    {
        protected int capacity;
        protected int portID;
        public Ship(int coordX, int coordY, int price, int speed, int yearIssue, int capacity, int portID)
    : base(coordX, coordY, price, speed, yearIssue)
        {
            this.capacity = capacity;
            this.portID = portID;
        }
        public void showShip()
        {
            Console.WriteLine("Ship: coord({0},{1}), price {2}, speed {3}, yearIssue {4}, capacity {5}, portID {6}", coordX, coordY, price, speed, yearIssue, capacity, portID);
        }
    }
}

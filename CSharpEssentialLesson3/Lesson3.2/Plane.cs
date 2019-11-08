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

    public class Plane : Vehicle
    {
        private int _height;
        private int _capacity;
        public Plane(int coordX, int coordY, int price, int speed, int yearIssue, int height, int capacity)
            : base(coordX,coordY,price,speed,yearIssue)
        {
            this._height = height;
            this._capacity = capacity;
        }
        public void showPlane()
        {
            Console.WriteLine("Plane: coord({0},{1}), price {2}, speed {3}, yearIssue {4}, height {5}, capacity {6}", coordX, coordY, price, speed, yearIssue, height, capacity);
        }
    }
}

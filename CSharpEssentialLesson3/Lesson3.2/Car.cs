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

    public class Car : Vehicle
    {
        public Car(int coordX, int coordY, int price, int speed, int yearIssue)
    : base(coordX, coordY, price, speed, yearIssue)
        { }
        public void ShowCar()
        {
            Console.WriteLine("Car: coord({0},{1}), price {2}, speed {3}, yearIssue {4}", coordX, coordY, price, speed, yearIssue);
        }
    }
}

using System;

namespace Lesson3._2
{

    /// <summary>
    /// Создать класс Vehicle.
    /// В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
    /// Создайте 3 производных класса Plane,Car и Ship.
    /// Для класса Plane дложна быть определена высота и количество пассажиров.
    /// Для класса Ship - количество пассажиров и порт приписки.
    /// Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            var plane = new Plane(coordX: 10, coordY: 10, price: 100000, speed: 160, yearIssue: 1990, height: 100, capacity: 200);
            var car = new Car(coordX: 5, coordY: 5, price: 10000, speed: 60, yearIssue: 2000);
            var ship = new Ship(coordX: 1, coordY: 1, price: 1000000, speed: 100, yearIssue: 2010,capacity:250, portID:1050);
            plane.ShowPlane();
            car.ShowCar();
            ship.ShowShip();
        }
    }
}

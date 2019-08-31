using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Создать класс Employee.
/// В теле класса создать пользовательский конструктор, который принимает два строковых аргумента,
/// и инициализирует поля, соответствующие фамилии и имени сотрудника.
/// Создать метод, рассчитывающий оклад сотрудника (в зависимости от должности и стажа)
/// и налоговый сбор. Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), оклад  налоговый сбор.
/// </summary>

namespace Lesson2._2
{
    class Program
    {
        // Спрашиваем имя фамилию.
        // Выдаем свойство оклад.
        // Выдаем свойство налоговый сбор.
        static void Main(string[] args)
        {
            string EmployeeName = Console.ReadLine();
            string EmployeeSurname = Console.ReadLine();

            Employee employee = new Employee(EmployeeName, EmployeeSurname);
            Employee.ShowEmployeesName();
        }

    }
}


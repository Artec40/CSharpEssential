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
        static void Main(string[] args)
        {
            Employee ivan = new Employee("Ivan", "Ivanov");
            ivan.Position = "Junior";
            ivan.Experience = 1;

            Employee petr = new Employee("Petr", "Petrov");
            petr.Position = "Middle";
            petr.Experience = 3;

            Employee vasya = new Employee("Vasya", "Vasil'ev");
            vasya.Position = "Senior";
            vasya.Experience = 10;

            Console.WriteLine($"{ivan.Name} {ivan.Surname} salary - {Employee.SalaryCalculation(ivan)}");
            Console.WriteLine($"{petr.Name} {petr.Surname} salary - {Employee.SalaryCalculation(petr)}");
            Console.WriteLine($"{ivan.Name} {vasya.Surname} salary - {Employee.SalaryCalculation(vasya)}");
        }
    }
}


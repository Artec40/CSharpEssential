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
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Experience { get; set; }
        public string Position { get; set; }
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public static double SalaryCalculation(Employee employee)
        {
            double salary = 0;
            switch (employee.Position)
            {
                case "Junior":
                    salary = 50000;
                    break;
                case "Middle":
                    salary = 75000;
                    break;
                case "Senior":
                    salary = 100000;
                    break;
            }

            double addForExperience = 1;
            if (employee.Experience <= 1)
                addForExperience = 1;

            else if (employee.Experience > 1 && employee.Experience < 5)
                addForExperience = addForExperience * 1.2;

            else
                addForExperience = addForExperience * 1.4;

            salary = salary * addForExperience;
            return salary;
        }
    }
}

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
        // Создаем поля фамилия и имя.
        private string name, surname;
        // Создаем список сотрудников (фамилия, имя, должность, стаж).
        private List<string> employessName = new List<string>() { "Ivan, Petr, Genadiy" };
        private List<string> employessSurname = new List<string>() { "Ivanov, Petrov, Petrov" };
        private List<string> employessPosition = new List<string>() { "Junior, Middle, Senior" };
        // employessExperience измеряется в годах.
        private List<int> employessExperience = new List<int>() { 1, 2, 5};

        public void ShowEmployessName()
        {
            Console.WriteLine(employessName);
        }
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        // Создаем свойство - оклад и свойство - налоговый сбор, с методами-мутаторами, работающими на выдачу.
        // Создаем пользовательский конструктор, в котором инициализируем фамилию, имя.
    }
}

using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Создать класс Converter.
/// В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента
/// и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне -
/// - public Converter(double usd, double eur, double rub).
/// Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
/// также программа должна производить конвертацию из указанных валют в гривну.
/// </summary>

namespace Lesson2._1
{
    public class Converter
    {

        private double usd;
        private double eur;
        private double rub;

        public double ConvertToUsd()
        {
            return (usd*hryvniaToUsd);
        }
        public double ConvertToEur()
        {
            return (eur*hryvniaToEur);
        }
        public double ConvertToRub()
        {
            return (rub*hryvniaToRub);
        }

        public double ConvertFromUsd()
        {
            return (usd / hryvniaToUsd);
        }
        public double ConvertFromEur()
        {
            return (eur / hryvniaToEur);
        }
        public double ConvertFromRub()
        {
            return (rub / hryvniaToRub);
        }

        private const double hryvniaToUsd = 0.04;
        private const double hryvniaToEur = 0.036;
        private const double hryvniaToRub = 2.64;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
    }
}

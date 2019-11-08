using System;

namespace Lesson9._1
{
    class Program
    {

        public delegate double Result(double arg1, double arg2);

        static void Main(string[] args)

        {

            Console.Write("First argument: ");
            double arg1FromUser = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second argument: ");
            double arg2FromUser = Convert.ToDouble(Console.ReadLine());
            Console.Write("Action? +,-,*,/: ");
            string actionFromUser = Console.ReadLine();

            Result calcDelegate;

            switch (actionFromUser)
            {

                case "+":
                    // Лямбда-метод задокументирован для осознания формирования лямбда-оператора.
                    //calcDelegate = delegate (int arg1, int arg2) { return (arg1 + arg2); };
                    calcDelegate = (arg1, arg2) => { return (arg1 + arg2); };
                    double add = calcDelegate(arg1FromUser, arg2FromUser);
                    Console.WriteLine("{0} + {1} = {2}", arg1FromUser, arg2FromUser, add);
                    break;

                case "-":
                    calcDelegate = (arg1, arg2) => { return (arg1 - arg2); };
                    double sub = calcDelegate(arg1FromUser, arg2FromUser);
                    Console.WriteLine("{0} - {1} = {2}", arg1FromUser, arg2FromUser, sub);
                    break;

                case "*":
                    calcDelegate = (arg1, arg2) => { return (arg1 * arg2); };
                    double mul = calcDelegate(arg1FromUser, arg2FromUser);
                    Console.WriteLine("{0} * {1} = {2}", arg1FromUser, arg2FromUser, mul);
                    break;

                case "/":
                    if (arg2FromUser != 0)
                    {
                        calcDelegate = (arg1, arg2) => { return (arg1 / arg2); };
                        double div = calcDelegate(arg1FromUser, arg2FromUser);
                        Console.WriteLine("{0} / {1} = {2}", arg1FromUser, arg2FromUser, div);
                    }
                    break;
            }
        }
    }
}

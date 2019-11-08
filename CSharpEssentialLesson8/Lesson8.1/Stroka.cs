using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8._1
{
    static class Stroka
    {

        enum StringColor
        {
            red = 0,
            green = 1,
            blue = 2
        }

        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;

                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }
    }
}

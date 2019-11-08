using System;

namespace Lesson8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Stroka - ");
            string inputStroka = Console.ReadLine();
            Console.Write("Color: 0-red,1-green,2-blue - ");
            int inputColor = Convert.ToInt32(Console.ReadLine());
            Stroka.Print(inputStroka, inputColor);
        }
    }

}

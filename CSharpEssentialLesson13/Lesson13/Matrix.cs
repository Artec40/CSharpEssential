using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lesson13
{
    class Matrix
    {
        //Список представляет набор знаков, используемых матрицей.
        List<string> letters = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        object block = new object();
        Random random = new Random();

        public void StartMatrix()
        {
            lock (block)
            {
                //Отступы перед началом матрицы.
                int counterMax = random.Next(1, 5);
                for (int counter = 0; counter < counterMax; counter++)
                {
                    Console.WriteLine();
                    Thread.Sleep(200);
                }

                //Первый знак матрицы (белый).
                Console.ForegroundColor = ConsoleColor.White;
                string letter = letters[random.Next(0, letters.Count)];
                Console.WriteLine(letter);
                Thread.Sleep(200);

                //Второй знак матрицы (светло-зелёный).
                Console.ForegroundColor = ConsoleColor.Green;
                letter = letters[random.Next(0, letters.Count)];
                Console.WriteLine(letter);
                Thread.Sleep(200);

                //Основная часть матрицы (тёмно-зелёная).
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                counterMax = random.Next(1, 10);
                for (int counter = 0; counter < counterMax; counter++)
                {
                    letter = letters[random.Next(0, letters.Count)];
                    Console.WriteLine(letter);
                    Thread.Sleep(200);
                    counterMax = random.Next(1, 10);
                }
            }
        }
    }
}

using System;
using System.Threading;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();

            while (true)
            {
                new Thread(matrix.StartMatrix).Start();
            }
        }
    }
}

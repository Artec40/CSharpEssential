using System;

namespace Lesson8._2
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Post: Manager, Senior, Middle, Junior? - ");
            string post = Console.ReadLine();
            Console.Write("Hours? - ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Accauntant accauntant = new Accauntant();

            switch (post)
            {
                case "Manager":
                    {
                        if (accauntant.AskForBonus(Post.Manager, hours)) Console.WriteLine("Выдать премию");
                        else Console.WriteLine("Не выдавать премию");
                        break;
                    }
                case "Senior":
                    {
                        if (accauntant.AskForBonus(Post.Senior, hours)) Console.WriteLine("Выдать премию");
                        else Console.WriteLine("Не выдавать премию");
                        break;
                    }
                case "Middle":
                    {
                        if (accauntant.AskForBonus(Post.Middle, hours)) Console.WriteLine("Выдать премию");
                        else Console.WriteLine("Не выдавать премию");
                        break;
                    }
                case "Junior":
                    {
                        if (accauntant.AskForBonus(Post.Junior, hours)) Console.WriteLine("Выдать премию");
                        else Console.WriteLine("Не выдавать премию");
                        break;
                    }
                default:
                    Console.WriteLine("No workers on this post");
                    break;
            }
        }
    }
}

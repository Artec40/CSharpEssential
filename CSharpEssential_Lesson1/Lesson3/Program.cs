using System;

namespace Lesson3
{
    /// Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать
    /// одно строковое поле и метод void Show().
    /// Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
    /// Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
    public class Book
    {
        /// <summary>
        /// Свойства класса - название книги, имя автора, содержание.
        /// </summary>
        public Title Title { get; }
        public Author Author { get; }
        public Content Content { get; }
        /// <summary>
        /// Конструктор класса книга
        /// </summary>
        /// <param name="title"> Инициализация названия книги</param>
        /// <param name="author"> Инициализация имени автора книги</param>
        /// <param name="content"> Инициализация содержания книги</param>
        public Book(Title title, Author author, Content content)
        {
            this.Title = title;
            this.Author = author;
            this.Content = content;
        }
    }
    public class Title
    {
        private string title;
        public Title(string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(title);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Author
    {
        private string author;
        public Author(string author)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(author);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Content
    {
        private string content;
        public Content(string content)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(content);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Title: ");
            string titleFromUser = Console.ReadLine();
            Console.Write("Author: ");
            string authorFromUser = Console.ReadLine();
            Console.Write("Content: ");
            string contentFromUser = Console.ReadLine();
            Title title = new Title(titleFromUser);
            Author author = new Author(authorFromUser);
            Content content = new Content(contentFromUser);
            Book book = new Book(title, author, content);
            Console.Write("Title: ");
            book.Title.Show();
            Console.Write(" Author: ");
            book.Author.Show();
            Console.Write(" Content: ");
            book.Content.Show();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BlaBlaTest.Model
{
    public class Book
    {
        // Id - это уникальный номер книги (как паспорт)
        // EF Core поймет, что это главный ключ
        public int Id { get; set; }

        // Название книги
        public string Title { get; set; }

        // Автор книги
        public string Author { get; set; }

        // Год издания
        public int Year { get; set; }
        public Book(string title, string author, int year)     
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
        }
        public Book() { }
    }
}

using System.IO;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore; // Подключаем EF Core
using BlaBlaTest.Model; // Подключаем наши модели

namespace BlaBlaTest.Dates
{
    public class AppDbContext : DbContext
    {
        // DbSet - это как коробка, в которой лежат книги
        // Эта коробка соответствует таблице в базе данных
        public DbSet<Book> Books { get; set; }

        // Этот метод настраивает подключение к базе
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            // Говорим: используй SQLite и сохраняй все в файл "mylibrary.db"
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\ASUS\\Desktop\\C# projects\\BlaBlaTest\\mylibrary.db");
        }
    }
}

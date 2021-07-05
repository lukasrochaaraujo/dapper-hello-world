using Dapper;
using System;
using System.Data.SQLite;
using System.Linq;

namespace dapper_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            using var connection = new SQLiteConnection("Data Source=.\\Company.db; Version=3");
            
            var bookList = connection.Query<Book>("SELECT * FROM Book").ToList();
            var authorWithBookList = connection.Query<Author, Book, Author>("SELECT * FROM Author a LEFT JOIN Book b on b.AuthorId = a.Id",
                                                (author, book) => {
                                                    author.Books.Add(book);
                                                    return author;
                                                })
                                                .ToList();
            var cleanCodeBook = connection.Query<Book>("SELECT * FROM Book where Title = @Title", new { Title = "Clean Code" }).First();

            bookList.ForEach(book => 
                Console.WriteLine(book));

            authorWithBookList.ForEach(author => 
                Console.WriteLine(author));

            Console.WriteLine(cleanCodeBook);
        }
    }
}

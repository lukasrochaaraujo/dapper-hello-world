using System.Collections.Generic;

namespace dapper_hello_world
{
    class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }

        public override string ToString()
            => $"Author: Id={Id}, Name={Name}, Books={Books?.Count ?? 0};";
    }
}
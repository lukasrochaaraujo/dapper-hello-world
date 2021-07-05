using System;

namespace dapper_hello_world
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishDate { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public override string ToString()
        {
            string book = $"Book: Id={Id}, Title={Title}, ISBN={ISBN}, PublisDate={PublishDate.ToShortDateString()}, AuthorId={AuthorId}";

            if (Author is not null)
                book += $", AuthorName={Author.Name}";
            
            return book;
        }
    }
}
using System;


namespace PersonApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string Style { get; set; }
        public int YearOfPublication { get; set; }
        public int NumberOfPages { get; set; }
    }
}

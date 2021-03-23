using System.Collections.Generic;
namespace BookStoreProject
{
    public class Book
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int categoryId { get; set; }
        public double unitPrice { get; set; }
        public double discountPercentage { get; set; }// For future, there might be a case if the book is on discount only.

        public List<Book> AddBook()
        {
            var booksList = new List<Book>();

            booksList.Add(new Book { Id = 1, Author = "Emily G. Thompson, Amber Hunt", Title = "Unsolved murders", unitPrice = 10.99, categoryId = 1, discountPercentage = 0.0 });
            booksList.Add(new Book { Id = 2, Author = "Lewis Carroll", Title = "Alice in Wonderland", unitPrice = 5.99, categoryId = 2, discountPercentage = 0.0 });
            booksList.Add(new Book { Id = 3, Author = "Roland Merullo", Title = "A Little Love Story", unitPrice = 2.40, categoryId = 3, discountPercentage = 0.0 });
            booksList.Add(new Book { Id = 4, Author = "S J Parris", Title = "Heresy", unitPrice = 6.80, categoryId = 2, discountPercentage = 0.0 });
            booksList.Add(new Book { Id = 5, Author = "Michael Ende", Title = "The Neverending Story", unitPrice = 7.99, categoryId = 2, discountPercentage = 0.0 });
            booksList.Add(new Book { Id = 6, Author = "Philip Sugden", Title = "Jack the Ripper", unitPrice = 16.00, categoryId = 1, discountPercentage = 0.0 });
            booksList.Add(new Book { Id = 7, Author = "Greg Hildebrandt", Title = "The Tolkien Years", unitPrice = 22.90, categoryId = 2, discountPercentage = 0.0 });

            return booksList;
        }
        public void DeleteBook()
        { //Not Implemented
        }

    }
}

using DIPatternDemo.Data;
using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext db;

        public BookRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddBook(Book book)
        {
            int result = 0;
            db.Books.Add(book);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteBook(int id)
        {
            int result = 0;
            var model = db.Books.Where(p =>p.Id== id).FirstOrDefault();
            if(model != null)
            {
                db.Books.Remove(model);
               result = db.SaveChanges();
                return result;
            }
            return result;
        }

        public Book GetBookById(int id)
        {
            return db.Books.Where(b => b.Id == id).FirstOrDefault();
        }

        public IEnumerable<Book> Getbooks()
        {
            return db.Books.ToList();
        }

        public int UpdateBook(Book book)
        {
            int result = 0;
            var model = db.Books.Where(p => p.Id == book.Id).FirstOrDefault();
            if (model != null)
            {
                model.BookName = book.BookName;
                model.Author = book.Author;
                model.Price = book.Price;
                result = db.SaveChanges();
                return result;
            }
            return result;
        }
    }
}

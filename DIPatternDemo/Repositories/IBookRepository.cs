using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> Getbooks();
        int AddBook(Book book);
        int UpdateBook(Book book);
        int DeleteBook(int id);
        Book GetBookById(int id);
    }
}

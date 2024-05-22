using DIPatternDemo.Models;

namespace DIPatternDemo.Services
{
    public interface IBookService
    {
        IEnumerable<Book> Getbooks();
        int AddBook(Book book);
        int UpdateBook(Book book);
        int DeleteBook(int id);
        Book GetBookById(int id);
    }
}
